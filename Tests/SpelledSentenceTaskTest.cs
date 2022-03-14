using CSharpTasks;
using NUnit.Framework;
using static CSharpTasks.SentenceContentFactory;

namespace Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void NotNullSentence()
    {
        //Arrange
        string notNullString = "sentence with many letters lol";
        //Act
        Sentence notNullSentence = new Sentence(notNullString);
        //Asser
        Assert.AreEqual(notNullString,notNullSentence.GetSentence());
    }
    
    [Test]
    public void NullSentence()
    {
        //Arrange
        string nullString = "";
        //Act
        Sentence nullSentence = new Sentence(nullString);
        //Asser
        Assert.AreEqual(nullString, nullSentence.GetSentence());
    }
    
}