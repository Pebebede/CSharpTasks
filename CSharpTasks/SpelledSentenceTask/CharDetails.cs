namespace CSharpTasks;

public class CharDetails
{
    public int numberOfCharOccurrences { get; }
    public char character { get; }

    public CharDetails(char character, int numberOfCharOccurrences)
    {
        this.numberOfCharOccurrences = numberOfCharOccurrences;
        this.character = character;
    }

    public override string ToString()
    {
        return base.ToString();
    }
}