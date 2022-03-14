namespace CSharpTasks;

public class LetteringFactory
{

   public List<Lettering> Create(List<SentenceContent> sentenceContents)
   {
      return sentenceContents.Select(sentence => new Lettering("char: " + sentence.character + " occurs in sentence " + sentence.numberOfCharOccurrences + " times")).ToList();
   }


}