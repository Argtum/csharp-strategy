using System;

namespace Strategy.DanceBehavior
{
    public class DanceWaltz : IDanceBehavior
    {
        public void Dance()
        {
            Console.WriteLine("I'm dancing the waltz");
        }
    }
}