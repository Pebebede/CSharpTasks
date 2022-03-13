// + zadanie domowe zeby napisac metoda ktora przyjmuje zdanie i policzy wystapienia wszystkich
// literek w tym zdaniu (w C#) zacznij od testow jednostkowych zeby bylo prosciej


using CSharpTasks;

Console.WriteLine("Hello! Please write your sentence to check how many times each letter is spelled.");

Sentence sentence = new Sentence(Console.ReadLine());   
List<string> spelled = new LetteringFactory().Create(sentence);
foreach(string a in spelled){
Console.WriteLine(a);
}