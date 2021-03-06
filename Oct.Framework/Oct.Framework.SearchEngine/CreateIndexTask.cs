﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lucene.Net.Analysis.PanGu;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.Store;
using Oct.Framework.Core.Args;
using Oct.Framework.Core.IOC;
using Oct.Framework.Core.Log;
using Oct.Framework.DB.Base;
using Oct.Framework.DB.Core;
using Oct.Framework.DB.Interface;
using Oct.Framework.Entities;

namespace Oct.Framework.SearchEngine
{
    public class CreateIndexTask<T> : IWork where T : BaseEntity<T>, new()
    {
        public event EventHandler<DataEventArgs<string>> OnStartDoWork;

        protected virtual void OnOnStartDoWork(DataEventArgs<string> e)
        {
            EventHandler<DataEventArgs<string>> handler = OnStartDoWork;
            if (handler != null) handler(this, e);
        }

        public event EventHandler<DataEventArgs<string>> OnDoWorkError;

        protected virtual void OnOnDoWorkError(DataEventArgs<string> e)
        {
            EventHandler<DataEventArgs<string>> handler = OnDoWorkError;
            if (handler != null) handler(this, e);
        }

        public event EventHandler<DataEventArgs<string, int>> OnDoWorked;

        protected virtual void OnOnDoWorked(DataEventArgs<string, int> e)
        {
            EventHandler<DataEventArgs<string, int>> handler = OnDoWorked;
            if (handler != null) handler(this, e);
        }



        private string _indexSavePath;

        private DoWorkStyle _style;

        private Action<T, Document> _addDocAction;

        public CreateIndexTask(string indexSavePath, DoWorkStyle style, Action<T, Document> addDocAction)
        {
            _indexSavePath = indexSavePath;
            _style = style;
            _addDocAction = addDocAction;
        }

        private List<T> GetLists()
        {
            using (var dbContext = new DBContextBase())
            {
                var allmodel = dbContext.GetContext<T>().Query("");
                return allmodel;
            }
        }

        private T GetOne(string key, object id)
        {
            using (var dbContext = new DBContextBase())
            {
                var models = dbContext.GetContext<T>().Query(" " + key + "=?", "", id);
                if (models.Count > 0)
                {
                    return models[0];
                }
                return null;
            }
        }

        private DateTime _doTime;

        public void DoWork()
        {
            if (_doTime == DateTime.MinValue)
            {
                _doTime = DateTime.Now;
                return;
            }
            if ((DateTime.Now - _doTime).TotalHours < 1 && _style == DoWorkStyle.PerHour)
            {
                return;
            }

            if ((DateTime.Now - _doTime).TotalDays < 1 && _style == DoWorkStyle.PerDay)
            {
                return;
            }

            OneDoWork();
        }

        public DoWorkStyle Style
        {
            get { return _style; }
        }

        public void UpdateUnitDoc(string key, object id)
        {
            FSDirectory directory = FSDirectory.Open(new DirectoryInfo(_indexSavePath), new NativeFSLockFactory());
            try
            {
                //表示将创建的索引文件保存在indexPath目录下
                bool isUpdate = IndexReader.IndexExists(directory); //)判断目录directory是否是一个索引目录
                if (isUpdate)
                {
                    //如果索引目录被锁定（比如索引过程中程序异常退出），则首先解锁
                    if (IndexWriter.IsLocked(directory)) //) 判断目录是否锁定，在对目录写之前会先把目录锁定
                    {
                        IndexWriter.Unlock(directory); //如果没有锁定则需要手动锁定因为。两个IndexWriter无法同时写一个索引文件
                    }
                }
                IndexWriter writer = new IndexWriter(directory, new PanGuAnalyzer(), !isUpdate,
                    IndexWriter.MaxFieldLength.UNLIMITED);
                //IndexWriter把输入写入索引的时候，Lucene.net是把写入的文件用指定的分词算法将文章分词（这样检索的时候才能查的快），然后将词放入索引文件。
                try
                {
                    var model = GetOne(key, id);
                    writer.DeleteDocuments(new Term(key, id.ToString()));


                    if (model != null)
                    {
                        Document document = new Document(); //创建一行记录
                        _addDocAction(model, document);
                        writer.AddDocument(document);
                    }

                    writer.Optimize();
                }
                catch (Exception ex)
                {
                    LogHelper.Error(ex);
                }
                finally
                {
                    writer.Close();
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex);
            }
            finally
            {
                directory.Close();
            }
        }

        public void DeleteDoc(string key, object id)
        {
            try
            {
                FSDirectory directory = FSDirectory.Open(new DirectoryInfo(_indexSavePath), new NativeFSLockFactory());//表示将创建的索引文件保存在indexPath目录下
                bool isUpdate = IndexReader.IndexExists(directory);//)判断目录directory是否是一个索引目录
                if (isUpdate)
                {
                    //如果索引目录被锁定（比如索引过程中程序异常退出），则首先解锁
                    if (IndexWriter.IsLocked(directory))//) 判断目录是否锁定，在对目录写之前会先把目录锁定
                    {
                        IndexWriter.Unlock(directory);//如果没有锁定则需要手动锁定因为。两个IndexWriter无法同时写一个索引文件
                    }
                }
                IndexWriter writer = new IndexWriter(directory, new PanGuAnalyzer(), !isUpdate, IndexWriter.MaxFieldLength.UNLIMITED);
                //IndexWriter把输入写入索引的时候，Lucene.net是把写入的文件用指定的分词算法将文章分词（这样检索的时候才能查的快），然后将词放入索引文件。
                writer.DeleteDocuments(new Term(key, id.ToString()));
                writer.Optimize();
                writer.Close();
                directory.Close();
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex);
            }
        }

        public void OneDoWork()
        {
            try
            {
                FSDirectory directory = FSDirectory.Open(new DirectoryInfo(_indexSavePath), new NativeFSLockFactory());//表示将创建的索引文件保存在indexPath目录下
                bool isUpdate = IndexReader.IndexExists(directory);//)判断目录directory是否是一个索引目录
                if (isUpdate)
                {
                    //如果索引目录被锁定（比如索引过程中程序异常退出），则首先解锁
                    if (IndexWriter.IsLocked(directory))//) 判断目录是否锁定，在对目录写之前会先把目录锁定
                    {
                        IndexWriter.Unlock(directory);//如果没有锁定则需要手动锁定因为。两个IndexWriter无法同时写一个索引文件
                    }
                }
                IndexWriter writer = new IndexWriter(directory, new PanGuAnalyzer(), !isUpdate, IndexWriter.MaxFieldLength.UNLIMITED);
                //IndexWriter把输入写入索引的时候，Lucene.net是把写入的文件用指定的分词算法将文章分词（这样检索的时候才能查的快），然后将词放入索引文件。

                var models = GetLists();
                writer.DeleteAll();
                models.ForEach(p =>
                {
                    Document document = new Document();//创建一行记录
                    _addDocAction(p, document);
                    writer.AddDocument(document);

                });
                writer.Optimize();
                writer.Close();
                directory.Close();
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex);
            }
        }
    }
}
