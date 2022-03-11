using HeadFirstStrategyPatternSample.Ducks.Abstractions;
using HeadFirstStrategyPatternSample.Ducks.Implements;

namespace HeadFirstStrategyPatternSample.Ducks
{
    public class SpottedWhistlingDuck : ADuck
    {
        public SpottedWhistlingDuck() : base(nameof(SpottedWhistlingDuck), new LowFly(), new Swimable())
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
