using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.Memento
{
    public class CareTaker
    {
        List<Memento> _mementoList = new List<Memento>();

        public void Add(Memento memento)
        {
            _mementoList.Add(memento);
        }

        public Memento Get(int i)
        {
            return _mementoList[i];
        }
    }
}
