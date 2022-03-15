namespace CSharpTasks;

public class SentenceContentFactory
{
    public List<CharacterOccurence> Create(Sentence originSentence)
    {
        Sentence trimmedSentence = WhiteCharTrigger(originSentence);
        char[] sentenceAsArray = SentenceAsArray(trimmedSentence);
        List<CharacterOccurence> literate = LiterateSentence(sentenceAsArray, trimmedSentence);
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

    private List<CharacterOccurence> LiterateSentence(char[] chars, Sentence trimmedSentence)
    {
        List<CharacterOccurence> lettersInAWord = new List<CharacterOccurence>();
        List<char> listOfCheckedChars = new List<char>();
        string str = trimmedSentence.GetSentence();
       

        for (int i = 0; i < chars.Length; i++)
        {
            if (!listOfCheckedChars.Contains(chars[i]))
            {
                int frequency = str.Count(f => (f == chars[i]));
                lettersInAWord.Add(new CharacterOccurence(frequency,chars[i]));
                listOfCheckedChars.Add(chars[i]);
            }

           
        }
        
        
        
        return lettersInAWord; 
        
    }
}