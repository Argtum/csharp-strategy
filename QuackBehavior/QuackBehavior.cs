using System;

namespace Strategy.QuackBehavior
{
    public class QuackBehavior : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack Quack!!!");
        }
    }
}