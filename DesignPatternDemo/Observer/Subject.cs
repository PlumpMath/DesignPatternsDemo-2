using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.Observer
{
    public interface Subject
    { 
        void Attach(Observer observer);
        void Dettach(Observer observer);
        void NotifyAll();
    }
}
