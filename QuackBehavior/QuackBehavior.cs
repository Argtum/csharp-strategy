using System;

namespace Strategy.QuackBehavior
{
    public class TryQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}