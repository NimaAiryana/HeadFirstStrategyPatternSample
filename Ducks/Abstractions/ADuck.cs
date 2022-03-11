namespace HeadFirstStrategyPatternSample.Ducks.Abstractions
{
    public abstract class ADuck
    {
        protected ADuck(string name, IFlyable flyBehavior, ISwimable swimBehavior)
        {
            Name = name;
            FlyBehavior = flyBehavior;
            SwimBehavior = swimBehavior;
        }

        public string Name { get; private set; }
        public IFlyable FlyBehavior { get; private set; }
        public ISwimable SwimBehavior { get; private set; }

        public void SetFlyBehavior(IFlyable flyBehavior) => FlyBehavior = flyBehavior;
        public void SetSwimBehavior(ISwimable swimBehavior) => SwimBehavior = swimBehavior;

        public abstract void Display();
    }
}
