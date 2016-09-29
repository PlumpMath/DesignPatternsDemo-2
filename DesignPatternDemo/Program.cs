using DesignPatternDemo.Command;
using DesignPatternDemo.Decorator;
using DesignPatternDemo.Iterator;
using DesignPatternDemo.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * ITERATOR
             **/

            ConcreteAggregate collection = new ConcreteAggregate();
            Iterator.Iterator iterator = collection.createIterator();

            //use to iterator to go through the collection
            while (!iterator.isDone())
            {
                Console.WriteLine(iterator.Next().ToString());
            }

            /**
             * OBSERVER
             **/

            Subject subject = new ConcreteSubject(SubjectState.Red);

            subject.Attach(new ConcreteObserver());
            subject.Attach(new ConcreteObserver());
            subject.Attach(new ConcreteObserver());

            ((ConcreteSubject)subject).SubjectState = SubjectState.Blue;

            /**
             * DECORATOR
             **/

            //we create a class with a base function
            Component component = new ConcreteComponent();
            //we create the function we want the add to the first class
            Decorator.Decorator decorator = new ConcreteDecorator();

            //the decorator gets the functionality of the class we want to extend
            decorator.SetBaseFuntionality(component);

            //both ops are called
            decorator.Operation();

            /**
             * COMMAND
             **/

            Command.Command command = new ConcreteCommand(new Receiver());

            //create an invoker which in turn calls the command which IN TURN calls the receiver
            Invoker invoker = new Invoker();
            invoker.SetCommand(command);
            invoker.ExecuteCommand();

            /**
             * COMPOSITE
             **/

            //instanciate differents persons
            Composite.Component component1 = new Composite.Composite("Bob");
            Composite.Component component2 = new Composite.Composite("Patrick");
            Composite.Component component3 = new Composite.Composite("Johny");
            Composite.Component component4 = new Composite.Composite("Pierre");

            //affects differents persons to a superior
            component1.Add(component2);
            component2.Add(component3);
            component2.Add(component4);

            //default method for every objects in the tree  
            component1.Operation();

            Console.ReadKey();
        }
    }
}
