using System.Collections.Generic;

namespace HashimX.CoolMath.library.UserDefinedTypes;

public class Set
{
    public string Name;
    public List<Int32> Elements = new List<int>();

    public int Size()
    {
        return Elements.Count;
    }
    public void Insert(int _element)
    {
        Elements.Add(_element);
    }
    public void Remove(int _element)
    {
        Elements.Remove(_element);
    }
    public string ToString()
    {
        string resultReturn = this.Name + " = { ";
        int totalC = Elements.Count;
        for (int i = 0; i < totalC; i++)
        {
            resultReturn = resultReturn + Elements[i] + " , ";
        }
        resultReturn = resultReturn + " } ";
        return resultReturn;
    }
}