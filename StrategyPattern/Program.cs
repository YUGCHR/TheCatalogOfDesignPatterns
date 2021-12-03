using System;

// Strategy Design Pattern
// Define a family of algorithms, encapsulate each one, and make them interchangeable.
// Strategy lets the algorithm vary independently from the clients that use it.
// Capture the abstraction in an interface, bury implementation details in derived classes.

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create Duck mallard = new MallardDuck");
            Duck mallard = new MallardDuck();

            Console.WriteLine("Do quack (mallard.quackBehavior.quack)");
            mallard.quackBehavior.quack();

            Console.WriteLine("Do fly (mallard.quackBehavior.fly)");
            mallard.flyBehavior.fly();

            Console.WriteLine("The End!");
        }
    }
}
