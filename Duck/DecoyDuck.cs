using System;
using Strategy.DanceBehavior;
using Strategy.FlyBehavior;
using Strategy.QuackBehavior;

namespace Strategy.Duck
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck() : base(
            flyBehavior: new FlyNoWay(),
            quackBehavior: new MuteQuackBehavior(),
            danceBehavior: new NoDanceBehavior()) {}
        
        public override void Display()
        {
            Console.WriteLine("I'm decoy duck");
        }
    }
}