
using HashimX.CoolMath.library.UserDefinedTypes;

namespace HashimX.CoolMath.library;
public class SetCalculator
{
    public Set Union(Set S1, Set S2)
    {
        Set result = new Set();
        result.Name = "UnionResult Set ";
        result = S1;
        int elemCount = S2.Elements.Count;
        for (int i = 0; i < elemCount; i++)
        {
            int x = S2.Elements[i];
            bool boolResult = result.Elements.Contains(x);
            if (boolResult == false)
            {
                result.Insert(x);
            }
        }
        return result;
    }
}