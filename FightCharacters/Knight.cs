using HeadFirstStrategyPatternSample.FightCharacters.Abstractions;
using HeadFirstStrategyPatternSample.FightCharacters.Implements;

namespace HeadFirstStrategyPatternSample.FightCharacters
{
    public class Knight : ACharacter
    {
        public Knight() : base(nameof(Knight), new SwordWeapon())
        {
        }
    }
}
