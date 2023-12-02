namespace HashimX.CoolMath.library;

/// <summary>
/// A Scientific Calculator
/// </summary>
public class ScientificCalculator
{
    /// <summary>
    /// Square Function 
    /// </summary>
    /// <param name="a">Variable for Square Calculation</param>
    /// <returns></returns>
    public double Square(double a)
    {
        Calculator cal = new Calculator();
        double resultcal = cal.Multiplication(a, a);
        return resultcal;
    }
    public double Cube(double a)
    {
        double resultSqr = this.Square(a);
        Calculator cal = new Calculator();
        double resultCal = cal.Multiplication(resultSqr, a);
        return resultCal;
    }
    /// <summary>
    /// SquareRoot Function
    /// </summary>
    /// <param name="a">Variable for SquareRoot Calculation</param>
    /// <returns>Returns SquareRoot of a</returns>
    public double SquareRoot(double a)
    {
        return Math.Sqrt(a);
    }

    public double Log(double a)
    {
        double resultLog = Math.Log(a);
        return resultLog;
    }
    public double AntiLog(double a)
    {
        double resultAntiLog = Math.Log10(a);
        return resultAntiLog;
    }
}