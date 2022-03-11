using HeadFirstStrategyPatternSample.FightCharacters.Abstractions;
using HeadFirstStrategyPatternSample.FightCharacters.Implements;

namespace HeadFirstStrategyPatternSample.FightCharacters
{
    public class Nobody : ACharacter
    {
        public Nobody() : base(nameof(Nobody), new NoWeapon())
        {
        }
    }
}
