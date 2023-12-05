using HashimX.CoolMath.library;


namespace HashimX.CoolMath.Library.Tests;

public class TrigonometricCalculatorTest
{
    [Fact]
 public void SineTest()
    {
        //Arrage
        var TrigonometricCalculator = new TrigonometricCalculator();
        
        //Act
        double result = TrigonometricCalculator.Sine(90);
        
        //Assert
        Assert.Equal(0.89399666360055785, result);
        

    }  
    [Fact]
    public void TangentTest()
    {
        //Arrage
        var TrigonometricCalculator = new TrigonometricCalculator();
        
        //Act
        double result = TrigonometricCalculator.Tangent(90,45);
        
        //Assert
        Assert.Equal(1.7018070490682367, result);
        

    }  
     [Fact]
    public void CosineTest()
    {
        //Arrage
        var TrigonometricCalculator = new TrigonometricCalculator();
        
        //Act
        double result = TrigonometricCalculator.Cosine(90);
        
        //Assert
        Assert.Equal(-0.44807361612917013, result);
        

    } 
    [Fact]
    public void CoSecTest()
    {
        //Arrage
        var TrigonometricCalculator = new TrigonometricCalculator();
        
        //Act
        double result = TrigonometricCalculator.CoSec(90);
        
        //Assert
        Assert.Equal(1.1185724071637084, result);
        

    } 
    [Fact]
    public void CotTest()
    {
        //Arrage
        var TrigonometricCalculator = new TrigonometricCalculator();
        
        //Act
        double result = TrigonometricCalculator.Cot(90,45);
        
        //Assert
        Assert.Equal(-0.52658568593248767, result);
        

    } 
    [Fact]
    public void SecCosTest()
    {
        //Arrage
        var TrigonometricCalculator = new TrigonometricCalculator();
        
        //Act
        double result = TrigonometricCalculator.SecCos(90);
        
        //Assert
        Assert.Equal(-2.2317761278577963, result);
        

    } 
    


}
