using System.Reflection.Metadata;

namespace HashimX.CoolMath.library;

public class ConstantProvider
{
    /// <summary>
    /// Gravity of Earth
    /// </summary>
    public double g = 9.8;
    public double Pi = 3.1415926536;

    public double SpeedOfLight()
    {
        const double spi = 299792458;
        return spi;
    }
}