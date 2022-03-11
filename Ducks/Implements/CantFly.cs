using HeadFirstStrategyPatternSample.Ducks.Abstractions;

namespace HeadFirstStrategyPatternSample.Ducks.Implements
{
    public class CantFly : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Can't fly");
        }
    }
}
