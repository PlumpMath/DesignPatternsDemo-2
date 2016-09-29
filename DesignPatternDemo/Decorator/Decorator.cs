using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.Decorator
{
    public abstract class Decorator : Component
    {
        //retains the class we want to extend the functionality of
        protected Component _component;


        public void SetBaseFuntionality(Component component)
        {
            _component = component;
        }

        public override void Operation()
        {
            if(_component != null)
            {
                _component.Operation();
            }
        }
    }
}
