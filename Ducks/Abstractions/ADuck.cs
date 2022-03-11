namespace HeadFirstStrategyPatternSample.Ducks.Abstractions
{
    public abstract class ADuck
    {
        protected ADuck(string name, IFlyable flyable, ISwimable swimable)
        {
            Name = name;
            Flyable = flyable;
            Swimable = swimable;
        }

        public string Name { get; private set; }
        public IFlyable Flyable { get; private set; }
        public ISwimable Swimable { get; private set; }

        public void SetFlyable(IFlyable flyable) => Flyable = flyable;
        public void SetSwimable(ISwimable swimable) => Swimable = swimable;

        public abstract void Display();
    }
}
