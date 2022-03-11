using HeadFirstStrategyPatternSample.FightCharacters.Abstractions;
using HeadFirstStrategyPatternSample.FightCharacters.Implements;

namespace HeadFirstStrategyPatternSample.FightCharacters
{
    public class Bowman : ACharacter
    {
        public Bowman() : base(nameof(Bowman), new BowAndArrowWeapon())
        {
        }
    }
}
