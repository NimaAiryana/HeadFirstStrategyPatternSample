using HeadFirstStrategyPatternSample.FightCharacters.Abstractions;
using HeadFirstStrategyPatternSample.FightCharacters.Implements;

namespace HeadFirstStrategyPatternSample.FightCharacters
{
    public class Shark : ACharacter
    {
        public Shark() : base(nameof(Shark), new TeethWeapon())
        {
        }
    }
}
