using System.Formats.Asn1;
using HashimX.CoolMath.library;

namespace MyCalculator
{
    public static class ConsoleTestCalculator
    {
        public static void Main()
        {
            Calculator Cal = new Calculator();
            double resultCal = Cal.Addition(10, 10);
            Console.WriteLine(resultCal);

            Calculator Cal1 = new Calculator();
            double resultCal1 = Cal.Subtraction(10, 10);

            TrigonometricCalculator TCal = new TrigonometricCalculator();
            double resultTCal = TCal.Sine(114);
            Console.WriteLine(resultTCal);

            ScientificCalculator SCal = new ScientificCalculator();
            double resultSCal = SCal.Cube(3);
            Console.WriteLine(resultSCal);

            ConstantProvider CP = new ConstantProvider();
            double resultCP = CP.Pi;
            Console.WriteLine(resultCP);

            AreaCalculator AC = new AreaCalculator();
            double resultCC = AC.CircleCircumference(12);
            Console.WriteLine(resultCC);

            double resultAC = AC.CircleArea(20);
            Console.WriteLine(resultAC);


        }
    }

}