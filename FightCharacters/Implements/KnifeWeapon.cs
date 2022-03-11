using HeadFirstStrategyPatternSample.FightCharacters.Abstractions;

namespace HeadFirstStrategyPatternSample.FightCharacters.Implements
{
    public class KnifeWeapon : IWeaponBehavior
    {
        public string Weapon()
        {
            return "a Knife";
        }
    }
}
