using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.Observer
{
    public class ConcreteSubject : Subject
    {
        
        private SubjectState _currentState;

        public SubjectState SubjectState
        {
            get { return _currentState; }
            set
            {
                _currentState = value;
                NotifyAll();
            }
        }

        private List<Observer> _observerList = new List<Observer>();

        public ConcreteSubject(SubjectState subjectState)
        {
            SubjectState = subjectState;
        }

        public void AttachAll(List<Observer> observerList)
        {
            _observerList.AddRange(observerList);
        }

        public void Attach(Observer observer)
        {
            _observerList.Add(observer);
            Notify(observer);
        }

        public void Dettach(Observer observer)
        {
            _observerList.Remove(observer);
        }

        public void Notify(Observer observer)
        {
            observer.Update(_currentState);
        }

        public void NotifyAll()
        {
            foreach(Observer observer in _observerList)
            {
                observer.Update(_currentState);
            }
        }
    }
}
