using System.Linq;

namespace CSharpTasks;

public class CharDetailsFactory
{
    public CharDetails Create(List<CharacterOccurence> characterOccurrences, string wantedCharacter)
    {
        char character = ConvertToChar(wantedCharacter);
        CharDetails charDetails = CheckIfIsThere(characterOccurrences, character);

        return charDetails;
    }

    private char ConvertToChar(string wantedCharAsString)
    {
        string firstLetter = wantedCharAsString.Substring(0, 1);
      char character = char.Parse(firstLetter);
     
        return character;
    }

    private CharDetails CheckIfIsThere(List<CharacterOccurence> characterOccurrences, char wantedChar)
    {
        CharDetails charDetails = new CharDetails(' ', 0);
      
        foreach (var characterOccurence in characterOccurrences)
        {
            if (characterOccurence.character.Equals(wantedChar))
            {
                charDetails = new CharDetails(characterOccurence.character,
                    characterOccurence.numberOfCharOccurrences);
                break;
            }
            else
            {
                Console.WriteLine("There is no "+wantedChar+ " char in your sentence");
                break;
            }
          
        }

        return charDetails;
    }
}