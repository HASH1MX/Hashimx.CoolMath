using System.Reflection.Metadata.Ecma335;

namespace HashimX.CoolMath.library;


public class EquationCalculator
{
    /// <summary>
    /// Pythagorean Theorem Function
    /// </summary>
    /// <param name="a">Leg A</param>
    /// <param name="b">Leg B</param>
    /// <returns>Returns Hypotenuse (c)</returns>
    public double PythagoreanTheorem(double a, double b)
    {
        ScientificCalculator SCal = new ScientificCalculator();
        double resultSquare = SCal.Square(a);

        double resultSquare1 = SCal.Square(b);

        Calculator Cal = new Calculator();
        double resultAdd = Cal.Addition(resultSquare, resultSquare1);

        double resultSquareRoot = SCal.SquareRoot(resultAdd);

        return resultSquareRoot;

    }

    
    

}