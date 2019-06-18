using Day01.Contracts;
using System;
using System.Collections.Generic;

namespace Day01.Library
{
    public class CycleProvider<T> : ICycleProvider<T>
    {
        private int _currentItem = -1;
        private List<T> _items = new List<T>();

        public T CurrentItem => ValidateItemsCount()._items[_currentItem];

        public ICycleProvider<T> Add(T item)
        {
            if (_items.Count == 0)
            {
                _currentItem = 0;
            }

            _items.Add(item);
            return this;
        }

        public T Next()
        {
            ValidateItemsCount();

            _currentItem = _currentItem >= _items.Count - 1 ? 0 : ++_currentItem;
            return _items[_currentItem];
        }

        private CycleProvider<T> ValidateItemsCount()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("Cycle provider has no items");
            }

            return this;
        }
    }
}
