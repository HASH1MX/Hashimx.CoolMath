using System.Reflection.Metadata;

namespace HashimX.CoolMath.library;

public class AreaCalculator
{
    public double CircleCircumference(double r)
    {
        ConstantProvider CP = new ConstantProvider();
        double resultPi = CP.Pi();

        double resultC = 2 * resultPi * r;
        return resultC;

    }
    public double CircleArea(double r)
    {
        ConstantProvider CP = new ConstantProvider();
        double resultPi = CP.Pi();

        ScientificCalculator SC = new ScientificCalculator();
        double resultSqr = SC.Square(r);

        double resultA = resultPi * resultSqr;
        return resultA;
    }
}