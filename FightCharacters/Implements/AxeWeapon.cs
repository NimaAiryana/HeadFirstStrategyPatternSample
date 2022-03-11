using HeadFirstStrategyPatternSample.FightCharacters.Abstractions;

namespace HeadFirstStrategyPatternSample.FightCharacters.Implements
{
    public class AxeWeapon : IWeaponBehavior
    {
        public string Weapon()
        {
            return "an Axe";
        }
    }
}
