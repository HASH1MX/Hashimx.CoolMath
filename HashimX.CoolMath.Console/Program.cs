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

        }
    }

}