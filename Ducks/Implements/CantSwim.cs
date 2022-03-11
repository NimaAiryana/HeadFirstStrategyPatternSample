using HeadFirstStrategyPatternSample.Ducks.Abstractions;

namespace HeadFirstStrategyPatternSample.Ducks.Implements
{
    public class CantSwim : ISwimable
    {
        public void Swim()
        {
            Console.WriteLine("Can't swim");
        }
    }
}
