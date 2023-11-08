//using DemoSolutions;
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
        Assert.That(value, Is.EqualTo(100));
    }

    [Test]
    public void Test2()
    {
        //Program program = new Program();
        var value = Program.IsOk();
        Assert.IsTrue(value);
        
    }
    [TearUp]
    public void Up()
    {

    }

    [TearDown]
    public void Down()
}