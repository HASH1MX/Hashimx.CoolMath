
using System.Security.Cryptography.X509Certificates;
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
    public Set Intersection(Set S1, Set S2)
    {
        Set result2 = new Set();
        result2.Name = "Intersection Result Set";
        int elemCount = S1.Elements.Count;
        for (int i = 0; i < elemCount; i++)
        {
            int a = S1.Elements[i];
            bool boolResult = S2.Elements.Contains(a);
            if (boolResult == true)
            {
                result2.Insert(a);
            }
        }
        int elemCount2 = S2.Elements.Count;
        for (int j = 0; j < elemCount2; j++)
        {
            int b = S2.Elements[j];
            bool boolResult2 = S1.Elements.Contains(b);
            if (boolResult2 == true)
            {
                bool boolResult3 = result2.Elements.Contains(b);
                if (boolResult3 == false)
                {
                    result2.Insert(b);
                }
            }
        }
        return result2;
    }
}