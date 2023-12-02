namespace HashimX.CoolMath.library;

/// <summary>
/// Trigonometric Calculator
/// </summary>
public class TrigonometricCalculator
{
    /// <summary>
    /// To Calculate Sine 
    /// </summary>
    /// <param name="t">Theta to calculate Sin</param>
    /// <returns>Sin of Theta</returns>
    public double Sine(double t)
    {
        return Math.Sin(t);
    }
    public double Tangent(double a, double b)
    {
        return Math.Sin(a) / Math.Cos(b);
    }
    public double Cosine(double a)
    {
        return Math.Cos(a);
    }
    public double CoSec(double a)
    {
        return 1 / Math.Sin(a);
    }
    public double Cot(double a, double b)
    {
        return Math.Cos(a) / Math.Sin(b);
    }
    public double SecCos(double a)
    {
        return 1 / Math.Cos(a);
    }
}