using System;
using Strategy.DanceBehavior;
using Strategy.FlyBehavior;

namespace Strategy.Duck
{
    public class MallardDuck : Duck
    {
        public MallardDuck() : base(
            flyBehavior: new FlyWithWings(),
            quackBehavior: new QuackBehavior.QuackBehavior(),
            danceBehavior: new DanceWaltz()) {}

        public override void Display()
        {
            Console.WriteLine("I'm mallard duck");
        }
    }
}