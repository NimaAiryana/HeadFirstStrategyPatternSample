using HeadFirstStrategyPatternSample.FightCharacters.Abstractions;
using HeadFirstStrategyPatternSample.FightCharacters.Implements;

namespace HeadFirstStrategyPatternSample.FightCharacters
{
    public class King : ACharacter
    {
        public King() : base(nameof(King), new SwordWeapon())
        {
        }
    }
}
