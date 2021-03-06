﻿using Oct.Tools.Core.Common;
using Oct.Tools.Core.Unity;
using Oct.Tools.Plugin.CodeGenerator.Bll;
using Oct.Tools.Plugin.CodeGenerator.Entity;
using Oct.Tools.Plugin.CodeGenerator.Section;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Oct.Tools.Plugin.CodeGenerator.View
{
    public partial class UCBathCodeGenerator : UserControl, IUCCommunication
    {
        #region 变量

        private DBInfo _dbInfo = null;
        private List<string> _successTableList = null;
        private List<string> _failureTableList = null;
        private List<TempElement> _selectedTemps = null;

        #endregion

        #region 构造函数

        public UCBathCodeGenerator(DBInfo dbInfo)
        {
            this.InitializeComponent();

            this._dbInfo = dbInfo;
            this._successTableList = new List<string>();
            this._failureTableList = new List<string>();
        }

        #endregion

        #region 方法

        private void SetContorlsEnabled(bool isEnable)
        {
            this.panBtnMove.Enabled = isEnable;
            this.txtNameSpace.Enabled = isEnable;
            this.btnSelectOutputDirectory.Enabled = isEnable;
            this.btnExport.Enabled = isEnable;
        }

        #endregion

        #region 事件

        private void BathCodeGeneratorForm_Load(object sender, System.EventArgs e)
        {
            try
            {
                //InitializeControls
                this.lbSourceTable.Items.AddRange(this._dbInfo.TableList.ToArray());
                this.btnSignleToLeft.Enabled = this.btnAllToLeft.Enabled = false;
                this.btnSignleToRight.Enabled = this.btnAllToRight.Enabled = this._dbInfo.TableList.Count > 0;
                this.labTargetTableCount.Text = this.labSelectedTempsCount.Text = "0";
                this.txtNameSpace.Text = TableBll.DefaultNameSpace;
            }
            catch (Exception ex)
            {
                MessageUnity.ShowErrorMsg(ex.Message);
            }
        }

        /// <summary>
        /// 移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMove_Click(object sender, System.EventArgs e)
        {
            try
            {
                var menuItem = ((Button)sender);

                switch (menuItem.Text)
                {
                    case ">":
                        if (this.lbSourceTable.SelectedItems != null)
                        {
                            var items = this.lbSourceTable.SelectedItems;

                            for (int i = 0; i < items.Count; i++)
                            {
                                this.lbTargetTable.Items.Add(items[i]);

                                this.lbSourceTable.Items.Remove(items[i]);

                                i--;
                            }

                            if (this.lbSourceTable.SelectedIndex < this.lbSourceTable.Items.Count - 1)
                                this.lbSourceTable.SelectedIndex = this.lbSourceTable.SelectedIndex + 1;
                        }
                        break;

                    case ">>":
                        if (this.lbSourceTable.Items.Count > 0)
                        {
                            this.lbTargetTable.Items.AddRange(this.lbSourceTable.Items);

                            this.lbSourceTable.Items.Clear();
                        }
                        break;

                    case "<":
                        if (this.lbTargetTable.SelectedItems != null)
                        {
                            var items = this.lbTargetTable.SelectedItems;

                            for (int i = 0; i < items.Count; i++)
                            {
                                this.lbSourceTable.Items.Add(items[i]);

                                this.lbTargetTable.Items.Remove(items[i]);

                                i--;
                            }

                            if (this.lbTargetTable.SelectedIndex < this.lbTargetTable.Items.Count - 1)
                                this.lbTargetTable.SelectedIndex = this.lbTargetTable.SelectedIndex + 1;
                        }
                        break;

                    case "<<":
                        if (this.lbTargetTable.Items.Count > 0)
                        {
                            this.lbSourceTable.Items.AddRange(this.lbTargetTable.Items);

                            this.lbTargetTable.Items.Clear();
                        }
                        break;

                    default:
                        break;
                }

                this.btnSignleToRight.Enabled = this.btnAllToRight.Enabled = this.lbSourceTable.Items.Count > 0;
                this.btnSignleToLeft.Enabled = this.btnAllToLeft.Enabled = this.lbTargetTable.Items.Count > 0;

                this.labTargetTableCount.Text = this.lbTargetTable.Items.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageUnity.ShowErrorMsg(ex.Message);
            }
        }

        /// <summary>
        /// 选择输出目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectOutputDirectory_Click(object sender, System.EventArgs e)
        {
            try
            {
                var fbd = new FolderBrowserDialog();
                var result = fbd.ShowDialog();

                if (result == DialogResult.OK)
                    this.txtOutputDirectory.Text = fbd.SelectedPath;
            }
            catch (Exception ex)
            {
                MessageUnity.ShowErrorMsg(ex.Message);
            }
        }

        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExport_Click(object sender, System.EventArgs e)
        {
            try
            {
                var msg = string.Empty;

                if (this.lbTargetTable.Items.Count == 0)
                    msg = "请选择要导出的表！";
                else if (this._selectedTemps == null || this._selectedTemps.Count == 0)
                    msg = "请选择模板！";
                else if (string.IsNullOrEmpty(this.txtNameSpace.Text))
                {
                    this.txtNameSpace.Focus();

                    msg = "请输入命名空间！";
                }
                else if (string.IsNullOrEmpty(this.txtOutputDirectory.Text))
                {
                    this.btnSelectOutputDirectory.Focus();

                    msg = "请选择要输出的目录！";
                }
                else if (!Directory.Exists(this.txtOutputDirectory.Text))
                {
                    this.btnSelectOutputDirectory.Focus();

                    msg = "选择的输出目录不存在！";
                }

                if (!string.IsNullOrEmpty(msg))
                {
                    MessageUnity.ShowWarningMsg(msg);

                    return;
                }

                this._successTableList.Clear();
                this._failureTableList.Clear();

                this.SetContorlsEnabled(false);

                this.Core();
            }
            catch (Exception ex)
            {
                MessageUnity.ShowErrorMsg(ex.Message);
            }
        }

        private void Core()
        {
            var index = 1;
            var tables = this.lbTargetTable.Items;
            var tempList = this._selectedTemps;
            var codeBaseDict = new Dictionary<string, CodeBaseInfo>();

            //step1 获取表结构信息
            var taskArg1 = new TaskArg();
            taskArg1.BeginAction = () =>
            {
                foreach (string table in tables)
                {
                    var dt = TableBll.GetDBTableInfo(this._dbInfo.ConnectionString, table);

                    var codeBaseInfo = TableBll.GetCodeBaseInfoByDBTable(dt);
                    codeBaseInfo.NameSpace = this.txtNameSpace.Text;
                    codeBaseInfo.ClassName = TableBll.GetClassName(dt.TableName);

                    codeBaseDict.Add(table, codeBaseInfo);

                    Thread.Sleep(1);

                    TaskCenter.Instance.ReportProgress(
                        new TaskReportProgressArg
                        {
                            Index = index++,
                            Count = tables.Count,
                            Msg = string.Format("step1/3 获取 {0} 结构信息......", table)
                        });
                }

                return null;
            };
            taskArg1.EndAction = (result) =>
            {
                index = 1;
            };

            //step2 创建模板文件夹
            var taskArg2 = new TaskArg();
            taskArg2.BeginAction = () =>
            {
                foreach (var temp in tempList)
                {
                    //一个模板一个子文件夹
                    var savePath = Path.Combine(this.txtOutputDirectory.Text, temp.DirName);

                    if (!Directory.Exists(savePath))
                        Directory.CreateDirectory(savePath);

                    Thread.Sleep(100);

                    TaskCenter.Instance.ReportProgress(
                        new TaskReportProgressArg
                        {
                            Index = index++,
                            Count = tempList.Count,
                            Msg = string.Format("step2/3 创建模板文件夹{0}......", temp.DirName)
                        });
                }

                return null;
            };
            taskArg2.EndAction = (result) =>
            {
                index = 1;
            };

            //step3 生成代码
            var taskArg3 = new TaskArg();
            taskArg3.BeginAction = () =>
            {
                var list = tempList.Where(d => !d.IsRanOnlyOnceByBath);

                foreach (var temp in list)
                {
                    foreach (string table in tables)
                    {
                        var codeBaseInfo = codeBaseDict[table];
                        codeBaseInfo.ClassNameExtend = temp.ClassNameExtend;

                        var output = TableBll.CodeGenerator(codeBaseInfo, temp.Path);
                        var msg = string.Format(@"{0}\{1}", temp.Name, table);

                        if (output.StartsWith("error："))
                            this._failureTableList.Add(msg);
                        else
                        {
                            var fileName = string.IsNullOrEmpty(temp.FileName) ? codeBaseInfo.ClassName : temp.FileName;
                            fileName = string.Format("{0}{1}{2}", fileName, temp.ClassNameExtend, temp.FileNameExtend);

                            //一个模板一个子文件夹
                            var savePath = Path.Combine(this.txtOutputDirectory.Text, temp.DirName);

                            if (temp.IsCreateChildDirByTableName)
                            {
                                savePath = Path.Combine(savePath, codeBaseInfo.ClassName);

                                if (!Directory.Exists(savePath))
                                    Directory.CreateDirectory(savePath);
                            }

                            savePath = Path.Combine(savePath, fileName);

                            File.WriteAllText(savePath, output, Encoding.UTF8);

                            this._successTableList.Add(msg);
                        }

                        Thread.Sleep(1);

                        TaskCenter.Instance.ReportProgress(
                            new TaskReportProgressArg
                            {
                                Index = index++,
                                Count = list.Count() * tables.Count,
                                Msg = string.Format("step3/3 生成代码{0}/{1}......", temp.Name, table)
                            });
                    }
                }

                index = 1;

                //RanOnlyOnce
                list = tempList.Where(d => d.IsRanOnlyOnceByBath);

                foreach (var temp in list)
                {
                    var output = TableBll.CodeGenerator("dts", codeBaseDict.Values.Select(d => d.ClassName).ToList(), temp.Path, null);
                    var msg = temp.Name;

                    if (output.StartsWith("error："))
                        this._failureTableList.Add(msg);
                    else
                    {
                        var fileName = string.Format("{0}{1}{2}", temp.FileName, temp.ClassNameExtend, temp.FileNameExtend);
                        var savePath = Path.Combine(this.txtOutputDirectory.Text, temp.DirName);

                        savePath = Path.Combine(savePath, fileName);

                        File.WriteAllText(savePath, output, Encoding.UTF8);

                        this._successTableList.Add(msg);

                        Thread.Sleep(1);

                        TaskCenter.Instance.ReportProgress(
                            new TaskReportProgressArg
                            {
                                Index = index++,
                                Count = list.Count(),
                                Msg = string.Format("step3/3 生成代码{0}......", temp.Name)
                            });
                    }
                }

                return null;
            };
            taskArg3.EndAction = (result) =>
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    var msg = "导出完成";

                    //if (e.Error != null)
                    //{
                    //    msg = e.Error.Message;

                    //    this._successTableList.Clear();
                    //    this._failureTableList.Clear();
                    //}
                    //else if (e.Cancelled)
                    //    msg = "导出被取消！";
                    //else
                    //    msg = "导出完成！";

                    this.SetContorlsEnabled(true);

                    var form = new BathCodeGeneratorResultForm(msg, this.txtOutputDirectory.Text, this._successTableList, this._failureTableList);
                    form.ShowDialog();
                }));
            };

            TaskCenter.Instance.AddTask(taskArg1);
            TaskCenter.Instance.AddTask(taskArg2);
            TaskCenter.Instance.AddTask(taskArg3);
            TaskCenter.Instance.ExecuteTasks();
        }

        #endregion

        #region IUCCommunication 成员

        public void SaveFile()
        {

        }

        public void SetTempElement(TempElement temp)
        {

        }

        public void SetTempElements(List<TempElement> temps)
        {
            this._selectedTemps = temps;

            this.labSelectedTempsCount.Text = this._selectedTemps.Count.ToString();
        }

        #endregion
    }
}
