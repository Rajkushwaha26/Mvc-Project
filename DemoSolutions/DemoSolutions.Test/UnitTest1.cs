using DemoSolutions;
namespace DemoSolutions.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Program program = new Program();
        var value = program.Demo();
        Assert.Pass();
    }
}