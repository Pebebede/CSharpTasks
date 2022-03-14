


using CSharpTasks;

Console.WriteLine("Hello! Please write your sentence to check how many times each character is spelled.");

Sentence sentence = new Sentence(Console.ReadLine());
List<SentenceContent> preparedSentence = new SentenceContentFactory().Create(sentence);
List<Lettering> spelled = new LetteringFactory().Create(preparedSentence);
foreach (var lettering in spelled)
{
   
        Console.WriteLine(lettering);
    
}