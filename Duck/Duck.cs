using System;
using Strategy.DanceBehavior;
using Strategy.FlyBehavior;
using Strategy.QuackBehavior;

namespace Strategy.Duck
{
    public abstract class Duck
    {
        private readonly IQuackBehavior _quackBehavior;
        private IFlyBehavior _flyBehavior;
        private IDanceBehavior _danceBehavior;

        protected Duck( IQuackBehavior quackBehavior, IFlyBehavior flyBehavior, IDanceBehavior danceBehavior)
        {
            _quackBehavior = quackBehavior;
            _danceBehavior = danceBehavior;
            SetFlyBehavior(flyBehavior);
        }

        public void Quack()
        {
            _quackBehavior.Quack();
        }
        
        public static void Swim()
        {
            Console.WriteLine("I'm swimming");
        }

        public void Fly()
        {
            _flyBehavior.Fly();
        }
        
        public virtual void Dance()
        {
            _danceBehavior.Dance();
        }

        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            _flyBehavior = flyBehavior;
        }

        public abstract void Display();
    }
}