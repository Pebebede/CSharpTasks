

//cel: proszę o litere i dostaje jej ilość wystąpień(obiekt z listą wystąpień) 
using CSharpTasks;

Console.WriteLine("Hello! Please write your sentence to check how many times each character is spelled.");

List<CharacterOccurence> preparedSentence = new SentenceContentFactory().Create(new Sentence(Console.ReadLine()));
List<Lettering> spelled = new LetteringFactory().Create(preparedSentence);



bool programContinue = true;
while (programContinue)
{
        Console.WriteLine("Please write letter what occurrences you want to check in your sentence");
        CharDetails charDetails = new CharDetailsFactory().Create(preparedSentence, new string(Console.ReadLine()));
        Console.WriteLine(charDetails.character.ToString()+charDetails.numberOfCharOccurrences.ToString());
        Console.WriteLine("if you want to check another char occurrence write \"y\" if you want to exit write \"n\"");
        if (Console.ReadLine() != "y") programContinue = false;
}