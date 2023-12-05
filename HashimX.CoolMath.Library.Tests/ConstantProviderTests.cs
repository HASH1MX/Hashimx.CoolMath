using HashimX.CoolMath.library;
namespace HashimX.CoolMath.Library.Tests;

public class ConstantProviderTests
{
 [Fact]
 public void gTest()
 {
    // Arange
        var constantProvider = new ConstantProvider();
    // Act
    double result = constantProvider.g;
    // Assert
    Assert.Equal(9.8, result);
 }

[Fact]
 public void SpeedOfLightTest()
 {
    // Arange
        var constantProvider = new ConstantProvider();
    // Act
    double result = constantProvider.SpeedOfLight();
    // Assert
    Assert.Equal(299792458, result);
}

 [Fact]
 public void PiTest()
 {
    // Arange
        var constantProvider = new ConstantProvider();
    // Act
    double result = constantProvider.Pi;
    // Assert
    Assert.Equal(3.1415926536, result);
 }

}

