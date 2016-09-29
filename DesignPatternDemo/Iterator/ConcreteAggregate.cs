using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.Iterator
{
    public class ConcreteAggregate : Aggregate
    {
        private ArrayList _items = new ArrayList();

        public ConcreteAggregate()
        {
            _items.Add(1);
            _items.Add(2);
            _items.Add(3);
            _items.Add(4);
        }

        public Iterator createIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count()
        {
            return _items.Count;
        }

        /**
         * Used to access the collection like an array
         * */
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }
    }
}
