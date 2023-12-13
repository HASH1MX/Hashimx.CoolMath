
using HashimX.CoolMath.library.UserDefinedTypes;

namespace HashimX.CoolMath.library;
public class SetCalculator
{
    public Set Union(Set S1, Set S2)
    {
        Set result = new Set();
        result.Name = "UnionResult Set ";
        result.Elements = S1.Elements.Union(S2.Elements).ToList();
        return result;
    }
}