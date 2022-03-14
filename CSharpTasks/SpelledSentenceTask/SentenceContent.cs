namespace CSharpTasks;

public class SentenceContent
{
    public int numberOfCharOccurrences { get; }
    public char character { get; }

    public SentenceContent(int numberOfCharOccurrences, char character)
    {
        this.numberOfCharOccurrences = numberOfCharOccurrences;
        this.character = character;
    }

}