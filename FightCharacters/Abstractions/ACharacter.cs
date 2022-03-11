namespace HeadFirstStrategyPatternSample.FightCharacters.Abstractions
{
    public abstract class ACharacter
    {
        protected ACharacter(string name, IWeaponBehavior weaponBehavior)
        {
            Name = name;
            WeaponBehavior = weaponBehavior;
        }

        public string Name { get; set; }
        public IWeaponBehavior WeaponBehavior { get; private set; }

        public void SetWeaponBehavior(IWeaponBehavior weaponBehavior) => WeaponBehavior = weaponBehavior;

        public virtual void Fight(string? text = null) => Console.WriteLine($"{text}A {Name} fight with {WeaponBehavior.Weapon()} \n");
    }
}
