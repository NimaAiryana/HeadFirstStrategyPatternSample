using HeadFirstStrategyPatternSample.FightCharacters;
using HeadFirstStrategyPatternSample.FightCharacters.Abstractions;

namespace HeadFirstStrategyPatternSample
{
    public static class CharacterFinder
    {
        public static ACharacter Find(string characterName)
        {
            try
            {
                var character = typeof(CharacterFinder).Assembly.GetTypes()
                    .FirstOrDefault(t => t.Name == characterName && !t.IsAbstract 
                    && !t.IsInterface && t.BaseType == typeof(ACharacter));

                if (character is null) return new Nobody();

                return (ACharacter?)Activator.CreateInstance(character) ?? new Nobody();
            }
            catch
            {
                return new Nobody();
            }
        }
    }
}
