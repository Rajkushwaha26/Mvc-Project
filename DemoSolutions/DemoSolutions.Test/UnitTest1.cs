using DemoSolutions;
using DemoSolutions.WebApi.Controllers;
namespace DemoSolutions.Test;
using Microsoft.Extensions.Logging;

 class Dispossible : IDisposable
    {
        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
    public class MockObject : ILogger<WeatherForecastController>
    {
        public IDisposable BeginScope<TState>(TState state)
        {
            return new Dispossible();
            //throw new NotImplementedException();
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return false;
            //throw new NotImplementedException();
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
           // throw new NotImplementedException();
        }
    }
public class Tests
{
    
    Program program= null;

   WeatherForecastController controllerforecast = null;
    [SetUp]
    public void Setup()
    {
        program = new Program();
        controllerforecast = new WeatherForecastController(new MockObject());
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

    // [TearUp]
    // public void Up()
    // {

    // }

    // [TearDown]
    // public void Down(){

    // }

    [Test]
    public void Test3(){
        Assert.Throws<System.DivideByZeroException>(()=>{
            program.ThrowDivideByZeroExceptionMethod();
        });
    }


    

    [Test]
    public void Test4()
    {
        StringAssert.Contains("Demo", program.GetMyName("demothree"));
    }

    [Test]
    [Author("Green Tester")]
    [Description("Testing the default value for post data")]
    public void Test5(){
        var value=controllerforecast.PostData();
        Assert.That(value, Is.EqualTo(0));
    }

    public void  Test6(){
        Dispossible  id = new Dispossible();
        string value = controllerforecast.DemoTest(id);
        StringAssert .Contains("Idispose",value);

    }

    public void Test6(){
        var mock = new Mock<IDisposable>();
        var data = mock.Object;
        Assert.That("disposed",Is.EqualTo(controllerforecast.DemoTest(data)));
    }
        
}