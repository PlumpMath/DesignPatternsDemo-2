using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.Iterator
{
    public class ConcreteIterator : Iterator
    {
        private ConcreteAggregate _concreteAggregate;
        private int _currentIndex = 0;

        public ConcreteIterator(ConcreteAggregate concreteAggregate)
        {
            _concreteAggregate = concreteAggregate;
        }

        /**
         * Return first item of collection
         * */
        public object First()
        {
            return _concreteAggregate[0];
        }

        /**
         * Return the next item in collection, NULL if not possible
         * */
        public object Next()
        {
            object ret = null;
            //checks if we're not at the end of the list
            if (_currentIndex < (_concreteAggregate.Count()))
            {
                return _concreteAggregate[_currentIndex++];
            }
            return ret;
        }

        /**
         * Return current item of collection
         * */
        public object CurrentItem()
        {
            return _concreteAggregate[_currentIndex];
        }

        /**
         * Will return true if index of iterator reached end of collection
         * */
        public bool isDone()
        {
            return _currentIndex == _concreteAggregate.Count();
        }
    }
}
