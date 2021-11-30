using System;

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
