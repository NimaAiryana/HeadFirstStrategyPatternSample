using HeadFirstStrategyPatternSample.FightCharacters.Abstractions;

namespace HeadFirstStrategyPatternSample.FightCharacters.Implements
{
    public class BowAndArrowWeapon : IWeaponBehavior
    {
        public string Weapon()
        {
            return "a Bow and Arrow";
        }
    }
}
