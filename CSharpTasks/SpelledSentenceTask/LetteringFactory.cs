namespace CSharpTasks;

public class LetteringFactory
{
    //1.wycięcie białych znaków
    //2.  rozdzielenie na tablice znaków, 
    //3. for w forze iterujący po każdym z elementów tablicy szukający równych wartości (a==b = 
    public List<string> Create(Sentence originSentence)
    {
        Sentence trimmedSentence = WhiteCharTrigger(originSentence);
        char[] sentenceAsArray = SentenceAsArray(trimmedSentence);
        List<string> literate = LiterateSentence(sentenceAsArray, trimmedSentence);
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

    private List<string> LiterateSentence(char[] chars, Sentence trimmedSentence)
    {
        List<string> lettersInAWord = new List<string>();
        List<char> listOfCheckedChars = new List<char>();
        string str = trimmedSentence.GetSentence();
       

        for (int i = 0; i < chars.Length; i++)
        {
            if (!listOfCheckedChars.Contains(chars[i]))
            {
                int frequency = str.Count(f => (f == chars[i]));
                lettersInAWord.Add("letter: "+chars[i]+" occurs in sentence "+frequency+" times.");
                listOfCheckedChars.Add(chars[i]);
            }

           
        }
        
        
        
        return lettersInAWord; 
        
    }
    
    
}