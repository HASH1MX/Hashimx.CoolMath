using HashimX.CoolMath.library;

namespace HashimX.CoolMath.Library.Tests;

public class CalculatorTests
{
    [Fact]
    public void AdditionTest()
    {
        //Arrage
        var calculator = new Calculator();

        //Act
        double result = calculator.Addition(10,20);

        //Assert
        Assert.Equal(30, result);

    }

    [Fact]
    public void SubtractionTest()
    {
        //Arrage
        var calculator = new Calculator();
        
        //Act
        double result = calculator.Subtraction(30,10);
        
        //Assert
        Assert.Equal(20, result);
        

    }  

     [Fact]
    public void MultiplicationTest()
    {
        //Arrage
        var calculator = new Calculator();
        
        //Act
        double result = calculator.Multiplication(30,10);
        
        //Assert
        Assert.Equal(300, result);
        

    }  
     [Fact]
    public void DivisionTest()
    {
        //Arrage
        var calculator = new Calculator();
        
        //Act
        double result = calculator.Division(30,10);
        
        //Assert
        Assert.Equal(3, result);
        

    }  

      [Fact]
     public void RemainderTest()
     {
        //Arrage
       var calculator = new Calculator();
        
       //Act
       double result = calculator.Remainder(30,10);
        
        //Assert
         Assert.Equal(0, result);
        

     }  


    
         
}