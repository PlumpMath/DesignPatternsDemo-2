using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.Decorator
{
    public class ConcreteDecorator : Decorator
    {
        public override void Operation()
        {
            //first we call the base function 
            base.Operation();
            //the functionality the decorator adds to the class
            Console.WriteLine("Added behavior");
        }
    }
}
