using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.Observer
{
    public class ConcreteObserver : Observer
    {
        public SubjectState SubjectState { get; set; }

        public void Update(SubjectState subjectState)
        {
            SubjectState = subjectState;
        }
    }
}
