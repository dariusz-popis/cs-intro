using Day01.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01.Library
{
    public class CycleProvider : ICycleProvider
    {
        private int _currentItem = -1;
        private List<object> _items = new List<object>();

        public object CurrentItem => ValidateItemsCount()._items[_currentItem];

        public void Add(object item)
        {
            if (_items.Count == 0)
            {
                _currentItem = 0;
            }

            _items.Add(item);
        }

        public object Next()
        {
            ValidateItemsCount();

            _currentItem = _currentItem >= _items.Count - 1 ? 0 : ++_currentItem;
            return _items[_currentItem];
        }

        private CycleProvider ValidateItemsCount()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("Cycle provider has no items");
            }

            return this;
        }
    }
}
