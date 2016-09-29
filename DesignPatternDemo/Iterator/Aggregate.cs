using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.Iterator
{
    public interface Aggregate
    {
        Iterator createIterator();

    }
}
