using HeadFirstStrategyPatternSample.FightCharacters.Abstractions;

namespace HeadFirstStrategyPatternSample.FightCharacters.Implements
{
    public class SwordWeapon : IWeaponBehavior
    {
        public string Weapon()
        {
            return "a Sword";
        }
    }
}
