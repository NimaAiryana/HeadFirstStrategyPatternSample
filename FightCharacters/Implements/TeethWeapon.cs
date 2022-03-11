using HeadFirstStrategyPatternSample.FightCharacters.Abstractions;

namespace HeadFirstStrategyPatternSample.FightCharacters.Implements
{
    public class TeethWeapon : IWeaponBehavior
    {
        public string Weapon()
        {
            return "Own Teeth";
        }
    }
}
