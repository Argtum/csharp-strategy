using System;
using Strategy.DanceBehavior;
using Strategy.FlyBehavior;

namespace Strategy.Duck
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck() : base(
            flyBehavior: new FlyWithWings(),
            quackBehavior: new QuackBehavior.QuackBehavior(),
            danceBehavior: new DanceMinuet()) {}

        public override void Display()
        {
            Console.WriteLine("I'm redhead duck");
        }
    }
}