using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.Memento
{
    public class Originator
    {
        public string State { get; set; }

        //save a state to a temporary object
        public Memento SaveToMemento()
        {
            return new Memento(State);
        }

        //restore state from an object to the originator
        public void RestoreStateFromMemento(Memento memento)
        {
            State = memento.State;
        }
    }
}
