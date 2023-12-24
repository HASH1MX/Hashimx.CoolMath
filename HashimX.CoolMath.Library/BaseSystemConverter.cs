namespace HashimX.CoolMath.library;

public class BaseSystemConverter
{
    public string DecimalToBinary(int Decimal)
    {

        string binary = Convert.ToString(Decimal, 2);

        return binary;
    }

    public int BinaryyToDecimal(string Binary)
    {

        int Decimal = Convert.ToInt32(Binary, 2);

        return Decimal;
    }
    public double BinaryyToDecimal2Method(string Binary)
    {
        //11001000 100101100 1100001001
        int power = Binary.Length - 1;
        double totalResult = 0;
        int myBase = 2;
        for (int i = 0; i < Binary.Length; i++)
        {
            double currentItem = Char.GetNumericValue(Binary[i]);
            double powerResult = Math.Pow(myBase, power);
            power = power - 1;

            totalResult = totalResult + currentItem * powerResult;
            //Console.WriteLine(currentItem + " " + powerResult + " " + totalResult);
            //Console.ReadKey();
        }

        return totalResult;
    }
    public string DecimalToHexadecimal(int decimalNumber)
    {

        string hexadecimalNumber = decimalNumber.ToString("X");

        return hexadecimalNumber;


    }
    





}



