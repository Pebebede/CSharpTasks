namespace CSharpTasks;

public class CharacterOccurence
{
    public int numberOfCharOccurrences { get; }
    public char character { get; }

    public CharacterOccurence(int numberOfCharOccurrences, char character)
    {
        this.numberOfCharOccurrences = numberOfCharOccurrences;
        this.character = character;
    }

}