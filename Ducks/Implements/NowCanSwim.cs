using HeadFirstStrategyPatternSample.Ducks.Abstractions;

namespace HeadFirstStrategyPatternSample.Ducks.Implements
{
    public class NowCanSwim : ISwimable
    {
        public void Swim()
        {
            Console.WriteLine("Oh gosh, Now you can swim");
        }
    }
}
