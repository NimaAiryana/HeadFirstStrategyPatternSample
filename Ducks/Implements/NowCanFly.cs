using HeadFirstStrategyPatternSample.Ducks.Abstractions;

namespace HeadFirstStrategyPatternSample.Ducks.Implements
{
    public class NowCanFly : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Oh gosh, Now you can fly");
        }
    }
}
