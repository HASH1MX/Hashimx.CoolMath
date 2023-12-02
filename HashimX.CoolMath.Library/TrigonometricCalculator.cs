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
    public double Tangent(double Sin, double Cosin)
    {
        double tan = Sin / Cosin;
        return tan;
    }
    public double Cosine(double a)
    {
        return Math.Cos(a);
    }
}