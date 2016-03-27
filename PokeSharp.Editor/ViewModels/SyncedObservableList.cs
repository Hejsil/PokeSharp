using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace PokeSharp.Editor.ViewModels
{
    public class SyncedObservableList<T> : IList<T>, INotifyCollectionChanged
    {
        Func<IList<T>> _observedList;

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        public T this[int index]
        {
            get { return _observedList()[index]; }
            set { _observedList()[index] = value; }
        }

        public int Count
        {
            get { return _observedList().Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public SyncedObservableList(Func<IList<T>> observedList)
        {
            _observedList = observedList;
        }

        public void Add(T item)
        {
            _observedList().Add(item);
            OnCollectionChanged(NotifyCollectionChangedAction.Add, item);
        }

        public void Clear()
        {
            _observedList().Clear();
            OnCollectionChanged(NotifyCollectionChangedAction.Reset);
        }

        public bool Contains(T item)
        {
            return _observedList().Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            _observedList().CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _observedList().GetEnumerator();
        }

        public int IndexOf(T item)
        {
            return _observedList().IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            _observedList().Insert(index, item);
            OnCollectionChanged(NotifyCollectionChangedAction.Add, item, index);
        }

        public bool Remove(T item)
        {
            var res = _observedList().Contains(item);

            if (res)
            {
                var index = _observedList().IndexOf(item);
                res = _observedList().Remove(item);
                OnCollectionChanged(NotifyCollectionChangedAction.Remove, item, index);
            }

            return res;
        }

        public void RemoveAt(int index)
        {
            var removed = _observedList()[index];
            _observedList().RemoveAt(index);
            OnCollectionChanged(NotifyCollectionChangedAction.Remove, removed, index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _observedList().GetEnumerator();
        }

        public void NotifyBigChange()
        {
            OnCollectionChanged(NotifyCollectionChangedAction.Reset);
        }

        private void OnCollectionChanged(NotifyCollectionChangedAction action)
        {
            var handle = CollectionChanged;
            if (handle != null)
                handle(this, new NotifyCollectionChangedEventArgs(action));
        }

        private void OnCollectionChanged(NotifyCollectionChangedAction action, T changedItem)
        {
            var handle = CollectionChanged;
            if (handle != null)
                handle(this, new NotifyCollectionChangedEventArgs(action, changedItem));
        }

        private void OnCollectionChanged(NotifyCollectionChangedAction action, T changedItem, int index)
        {
            var handle = CollectionChanged;
            if (handle != null)
                handle(this, new NotifyCollectionChangedEventArgs(action, changedItem, index));
        }
    }
}
