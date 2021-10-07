using System;

namespace Strategy.FlyBehavior
{
    public class TryFly : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Try fly!");
        }
    }
}