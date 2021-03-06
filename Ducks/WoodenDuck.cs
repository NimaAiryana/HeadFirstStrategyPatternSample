using HeadFirstStrategyPatternSample.Ducks.Abstractions;
using HeadFirstStrategyPatternSample.Ducks.Implements;

namespace HeadFirstStrategyPatternSample.Ducks
{
    public class WoodenDuck : ADuck
    {
        public WoodenDuck() : base(nameof(WoodenDuck), new CantFly(), new CantSwim())
        {
        }

        public override void Display()
        {
            Console.WriteLine($"{Name}:");
            FlyBehavior.Fly();
            SwimBehavior.Swim();
            Console.WriteLine();
        }
    }
}
