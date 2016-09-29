using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.Command
{
    public class Receiver
    {
        public void Action()
        {
            Console.WriteLine("Action");
        }
    }
}
