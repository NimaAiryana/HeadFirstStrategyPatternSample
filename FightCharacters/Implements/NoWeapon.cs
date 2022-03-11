using HeadFirstStrategyPatternSample.FightCharacters.Abstractions;

namespace HeadFirstStrategyPatternSample.FightCharacters.Implements
{
    public class NoWeapon : IWeaponBehavior
    {
        public string Weapon()
        {
            return "No Weapon";
        }
    }
}
