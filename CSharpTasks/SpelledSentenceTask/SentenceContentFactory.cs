namespace CSharpTasks;

public class SentenceContentFactory
{
    public List<SentenceContent> Create(Sentence originSentence)
    {
        Sentence trimmedSentence = WhiteCharTrigger(originSentence);
        char[] sentenceAsArray = SentenceAsArray(trimmedSentence);
        List<SentenceContent> literate = LiterateSentence(sentenceAsArray, trimmedSentence);
        return literate;
    }


    private Sentence WhiteCharTrigger(Sentence sentence)
    {
        string trimmed = String.Concat(sentence.GetSentence().Where(c => !Char.IsWhiteSpace(c)));
        Sentence trimmedSentence = new Sentence(trimmed);
        return trimmedSentence;
    }

    private char[] SentenceAsArray(Sentence sentence)
    {
        char[] array = sentence.GetSentence().ToCharArray();
        return array;
    }

    private List<SentenceContent> LiterateSentence(char[] chars, Sentence trimmedSentence)
    {
        List<SentenceContent> lettersInAWord = new List<SentenceContent>();
        List<char> listOfCheckedChars = new List<char>();
        string str = trimmedSentence.GetSentence();
       

        for (int i = 0; i < chars.Length; i++)
        {
            if (!listOfCheckedChars.Contains(chars[i]))
            {
                int frequency = str.Count(f => (f == chars[i]));
                lettersInAWord.Add(new SentenceContent(frequency,chars[i]));
                listOfCheckedChars.Add(chars[i]);
            }

           
        }
        
        
        
        return lettersInAWord; 
        
    }
}