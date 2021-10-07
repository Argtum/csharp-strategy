using System;
using Strategy.DanceBehavior;
using Strategy.FlyBehavior;
using Strategy.QuackBehavior;

namespace Strategy.Duck
{
    public class RubberDuck : Duck
    {
        public RubberDuck() : base(
            flyBehavior: new FlyNoWay(),
            quackBehavior: new SqueakBehavior(),
            danceBehavior: new NoDanceBehavior()) {}

        public override void Display()
        {
            Console.WriteLine("I'm rubber duck");
        }
    }
}