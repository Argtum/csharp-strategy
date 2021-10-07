using Strategy.Duck;
using Strategy.FlyBehavior;

namespace Strategy
{
    public class Program
    {
        private static void DrawDuck(Duck.Duck duck)
        {
            duck.Display();
        }
        
        private static void PlayWithDuck(Duck.Duck duck)
        {
            DrawDuck(duck);
            duck.Quack();
            duck.Fly();
            duck.Dance();
        }
        
        static void Main(string[] args)
        {
            MallardDuck mallardDuck = new MallardDuck();
            PlayWithDuck(mallardDuck);

            RedheadDuck redheadDuck = new RedheadDuck();
            PlayWithDuck(redheadDuck);

            RubberDuck rubberDuck = new RubberDuck();
            PlayWithDuck(rubberDuck);

            DecoyDuck decoyDuck = new DecoyDuck();
            PlayWithDuck(decoyDuck);

            ModelDuck modelDuck = new ModelDuck();
            PlayWithDuck(modelDuck);
            
            modelDuck.SetFlyBehavior(new FlyWithWings());
            PlayWithDuck(modelDuck);
        }
    }
}