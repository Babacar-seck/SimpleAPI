using SimpleAPI.Controllers;

namespace SimpleAPI.TEST;

public class UnitTest1
{
    WeatherForecastController controller = new WeatherForecastController();

    [Fact]
    public void GetReturnsForecast()
    {
        var returnValue = controller.Get(1);
        Assert.Equal("Babacar", returnValue.Value);
    }

    [Fact]
    public void Test1()
    {
    }
}