using HeadFirstStrategyPatternSample.Ducks.Abstractions;
using HeadFirstStrategyPatternSample.Ducks.Implements;

namespace HeadFirstStrategyPatternSample.Ducks
{
    public class RubberDuck : ADuck
    {
        public RubberDuck() : base(nameof(RubberDuck), new CantFly(), new Swimable())
        {
        }

        public override void Display()
        {
            Console.WriteLine($"{Name}:");
            Flyable.Fly();
            Swimable.Swim();
            Console.WriteLine();
        }
    }
}
