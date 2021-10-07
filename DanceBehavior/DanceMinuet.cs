using System;

namespace Strategy.DanceBehavior
{
    public class DanceMinuet : IDanceBehavior
    {
        public void Dance()
        {
            Console.WriteLine("I'm dancing the minuet");
        }
    }
}