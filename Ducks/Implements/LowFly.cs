using HeadFirstStrategyPatternSample.Ducks.Abstractions;

namespace HeadFirstStrategyPatternSample.Ducks.Implements
{
    public class LowFly : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Och, low fly");
        }
    }
}
