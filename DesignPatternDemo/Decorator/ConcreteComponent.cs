using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.Decorator
{
    /**
     * The class we want to add functionality to
     */
    public class ConcreteComponent : Component
    {
        //Base operation
        public override void Operation()
        {
            Console.WriteLine("Base behavior");
        }
    }
}
