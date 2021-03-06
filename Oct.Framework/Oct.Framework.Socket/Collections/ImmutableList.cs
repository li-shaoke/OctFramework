using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Oct.Framework.Socket.Collections
{
    public class ImmutableList<T> : IList<T>
    {
        private List<T> list;

        public ImmutableList()
            : this(10)
        {
        }

        public ImmutableList(int capacity)
        {
            list = new List<T>(capacity);
        }

        public ImmutableList(IEnumerable<T> collection)
        {
            list = new List<T>(collection);
        }

        #region IList<T> Members

        public void Add(T item)
        {
            List<T> copy = CopyList();
            copy.Add(item);
            list = copy;
        }

        public void Clear()
        {
            list = new List<T>();
        }

        public bool Contains(T item)
        {
            return list.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            List<T> copy = CopyList();
            copy.CopyTo(array, arrayIndex);
            list = copy;
        }

        public bool Remove(T item)
        {
            List<T> copy = CopyList();
            bool result = copy.Remove(item);
            list = copy;
            return result;
        }

        public int Count
        {
            get { return list.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public int IndexOf(T item)
        {
            return list.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            List<T> copy = CopyList();
            copy.Insert(index, item);
            list = copy;
        }

        public void RemoveAt(int index)
        {
            List<T> copy = CopyList();
            copy.RemoveAt(index);
            list = copy;
        }

        public T this[int index]
        {
            get { return list[index]; }
            set { list[index] = value; }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion

        private List<T> CopyList()
        {
            return list.ToList();
        }
    }
}