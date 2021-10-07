using System;

namespace Strategy.DanceBehavior
{
    public class NoDanceBehavior : IDanceBehavior
    {
        public void Dance()
        {
            Console.WriteLine("I can't dance");
        }
    }
}