namespace CSharpTasks;

public class Lettering
{
   

    private string lettered { get; }

    public Lettering(string lettered)
    {
        this.lettered = lettered;
    }
    
    public override string ToString()
    {
        return lettered.ToString();
    }
    
}