using HashimX.CoolMath.library;

namespace HashimX.CoolMath.Library.Tests;

public class AreaCalculatorTest
{

 [Fact]
    public void AdditionTest()
    {
        //Arrage
        var AreaCalculator = new AreaCalculator();

        //Act
        double result = AreaCalculator.CircleCircumference(22);

        //Assert
        Assert.Equal(138.2300767584, result);

    }

     [Fact]
    public void CircleAreaTest()
    {
        //Arrage
        var AreaCalculator = new AreaCalculator();

        //Act
        double result = AreaCalculator.CircleArea(100);

        //Assert
        Assert.Equal(31415.926535999999, result);

    }



}
