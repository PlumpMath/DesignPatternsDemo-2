using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.Composite
{
    public class Composite : Component
    {
        //list of "subordinates objects"
        private List<Component> _componentList = new List<Component>();

        public Composite(String name)
        {
            _name = name;
        }

        public override void Add(Component component)
        {
            _componentList.Add(component);
        }

        public override void Remove(Component component)
        {
            _componentList.Remove(component);
        }
        //triggers default method for all children and their children and so on ...
        public override void Operation()
        {
            Console.WriteLine(_name);
            foreach(Component component in _componentList){
                component.Operation();
            }
        }
    }
}
