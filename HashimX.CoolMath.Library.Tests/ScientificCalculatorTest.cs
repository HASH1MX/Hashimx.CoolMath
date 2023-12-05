using HashimX.CoolMath.library;

namespace HashimX.CoolMath.Library.Tests;

public class ScientificCalculatorTest
{
[Fact]
 public void SquareTest()
 {
    // Arange
        var ScientificCalculator = new ScientificCalculator();
    // Act
    double result = ScientificCalculator.Square(2);
    // Assert
    Assert.Equal(4, result);
 }

 [Fact]
 public void CubeTest()
 {
    // Arange
        var ScientificCalculator = new ScientificCalculator();
    // Act
    double result = ScientificCalculator.Cube(2);
    // Assert
    Assert.Equal(8, result);
 }

 [Fact]
 public void SquareRootTest()
 {
    // Arange
        var ScientificCalculator = new ScientificCalculator();
    // Act
    double result = ScientificCalculator.SquareRoot(9);
    // Assert
    Assert.Equal(3, result);
 }

 [Fact]
 public void LogTest()
 {
    // Arange
        var ScientificCalculator = new ScientificCalculator();
    // Act
    double result = ScientificCalculator.Log(10);
    // Assert
    Assert.Equal(2.3025850929940459, result);
 }
    
 [Fact]
 public void AntiLogTest()
 {
    // Arange
        var scientificCalculator = new ScientificCalculator();
    // Act
    double result = scientificCalculator.AntiLog(10);
    // Assert
    Assert.Equal(1, result);
 }
}

