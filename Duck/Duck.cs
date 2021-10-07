using Strategy.FlyBehavior;
using Strategy.QuackBehavior;

namespace Strategy.Duck
{
    public class CDuck
    {
        protected IQuackBehavior _quackBehavior;
        protected IFlyBehavior _flyBehavior;

        public void performQuack()
        {
            _quackBehavior.Quack();
        }
        
        public void performFly()
        {
            _flyBehavior.Fly();
        }
    }
}