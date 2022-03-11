using HeadFirstStrategyPatternSample.Ducks.Abstractions;

namespace HeadFirstStrategyPatternSample.Ducks.Implements
{
    public class Flyable : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Oh flyyyyyyyyyy :D, bye bye");
        }
    }
}
