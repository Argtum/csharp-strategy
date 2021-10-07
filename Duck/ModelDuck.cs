using System;
using Strategy.DanceBehavior;
using Strategy.FlyBehavior;

namespace Strategy.Duck
{
    public class ModelDuck : Duck
    {
        public ModelDuck() : base(
            flyBehavior: new FlyNoWay(),
            quackBehavior: new QuackBehavior.QuackBehavior(),
            danceBehavior: new NoDanceBehavior()) {}

        public override void Display()
        {
            Console.WriteLine("I'm model duck");
        }
    }
}