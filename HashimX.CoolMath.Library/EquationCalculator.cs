using System.Reflection.Metadata;
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
    /// <summary>
    /// Mass Energy Equivalence Function
    /// </summary>
    /// <param name="M">Mass</param>
    /// <returns>Energy</returns>
    public double MassEnergyEquivalence(double M)
    {
        //Objects , So can have access to Calculator,Scientific Calculator and ConstantProvider.
        Calculator Cal = new Calculator();
        ScientificCalculator SCal = new ScientificCalculator();
        ConstantProvider CP = new ConstantProvider();

        double speedLight = CP.SpeedOfLight();

        double sqrSpeedLight = SCal.Square(speedLight);

        double energy = Cal.Multiplication(M, sqrSpeedLight);

        return energy;


    }
    /// <summary>
    /// Law of Universal Gravitation Function
    /// </summary>
    /// <param name="m1">Mass 1</param>
    /// <param name="m2">Mass 2</param>
    /// <param name="r">distance between centers of the masses</param>
    /// <returns>Force</returns>
    public double LawOfUniversalGravitation(double m1, double m2, double r)
    {
        //Objects , So can have access to Calculator,Scientific Calculator and ConstantProvider.
        Calculator Cal = new Calculator();
        ScientificCalculator SCal = new ScientificCalculator();
        ConstantProvider CP = new ConstantProvider();


        double Gvalue = CP.G;
        double resultmulti = Cal.Multiplication(m1, m2);

        double resultmulti2 = Cal.Multiplication(resultmulti, Gvalue);
        double rSquare = SCal.Square(r);

        double resultDiv = Cal.Division(resultmulti2, rSquare);

        return resultDiv;



    }




}