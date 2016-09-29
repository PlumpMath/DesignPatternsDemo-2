using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.Composite
{
    public abstract class Component
    {
        protected String _name;

        //default operation for all inheritant objects
        public abstract void Operation();
        public abstract void Add(Component component);
        public abstract void Remove(Component component);
    }
}
