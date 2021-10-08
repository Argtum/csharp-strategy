using System;

namespace Strategy.FlyBehavior
{
    public class FlyWithWings : IFlyBehavior
    {
        private int _count;
        
        public void Fly()
        {
            _count++;
            Console.WriteLine($"I'm flying with wings! {_count} fly");
        }
    }
}