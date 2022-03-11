using HeadFirstStrategyPatternSample.FightCharacters.Abstractions;
using HeadFirstStrategyPatternSample.FightCharacters.Implements;

namespace HeadFirstStrategyPatternSample.FightCharacters
{
    public class Queen : ACharacter
    {
        public Queen() : base(nameof(Queen), new KnifeWeapon())
        {
        }
    }
}
