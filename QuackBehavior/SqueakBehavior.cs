using System;

namespace Strategy.QuackBehavior
{
    public class SqueakBehavior : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeek!!!");
        }
    }
}