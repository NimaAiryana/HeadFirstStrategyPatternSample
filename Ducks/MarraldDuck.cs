using HeadFirstStrategyPatternSample.Ducks.Abstractions;
using HeadFirstStrategyPatternSample.Ducks.Implements;

namespace HeadFirstStrategyPatternSample.Ducks
{
    public class MarraldDuck : ADuck
    {
        public MarraldDuck() : base(nameof(MarraldDuck), new Flyable(), new Swimable())
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
