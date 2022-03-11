using HeadFirstStrategyPatternSample.Ducks.Abstractions;

namespace HeadFirstStrategyPatternSample.Ducks.Implements
{
    public class Swimable : ISwimable
    {
        public void Swim()
        {
            Console.WriteLine("Yeaaaaaah, swim babe");
        }
    }
}
