using System.Formats.Asn1;
using HashimX.CoolMath.library;
using HashimX.CoolMath.library.UserDefinedTypes;

namespace MyCalculator
{
    public static class ConsoleTestCalculator
    {
        public static void Main()
        {
            Calculator Cal = new Calculator();
            double resultCal = Cal.Addition(10, 10);
            Console.WriteLine("Addition: " + resultCal);

            double resultCal1 = Cal.Subtraction(100, 60);
            Console.WriteLine("Subtraction: " + resultCal1);

            double resultCal2 = Cal.Multiplication(10, 20);
            Console.WriteLine("Multiplication: " + resultCal2);

            double resultCal3 = Cal.Division(1230, 2);
            Console.WriteLine("Division: " + resultCal3);

            double resultCal4 = Cal.Remainder(31, 10);
            Console.WriteLine("Remainder:" + resultCal4);

            ScientificCalculator SCal = new ScientificCalculator();
            double resultSCal = SCal.Cube(3);
            Console.WriteLine("Cube: " + resultSCal);

            double resultSCal1 = SCal.Square(10);
            Console.WriteLine("Square:" + resultSCal1);

            double resultSCal2 = SCal.SquareRoot(120);
            Console.WriteLine("SquareRoot: " + resultSCal2);

            double resultSCal3 = SCal.Log(10);
            Console.WriteLine("Logarithm: " + resultSCal3);

            double resultSCal4 = SCal.AntiLog(0);
            Console.WriteLine("Anti-Logarithm: " + resultSCal4);

            double resultSCal5 = SCal.QuadraticPositive(3, -5, 2);
            Console.WriteLine("Quadratic Positive: " + resultSCal5);

            double resultSCal6 = SCal.QuadraticNegative(3, -5, 2);
            Console.WriteLine("Quadratice Negative: " + resultSCal6);


            TrigonometricCalculator TCal = new TrigonometricCalculator();
            double resultTCal = TCal.Sine(114);
            Console.WriteLine("Sine: " + resultTCal);

            double resultTCal1 = TCal.Tangent(120, 130);
            Console.WriteLine("Tangent: " + resultTCal1);

            double resultTCal2 = TCal.Cosine(120);
            Console.WriteLine("Cosine: " + resultTCal2);

            double resultTCal3 = TCal.CoSec(100);
            Console.WriteLine("Cosec: " + resultTCal3);

            double resultTCal4 = TCal.SecCos(100);
            Console.WriteLine("SecCos: " + resultTCal4);

            double resultTCal5 = TCal.Cot(100, 122);
            Console.WriteLine("Cot: " + resultTCal5);

            ConstantProvider CP = new ConstantProvider();

            double resultCP = CP.Pi;
            Console.WriteLine("Pi: " + resultCP);

            AreaCalculator AC = new AreaCalculator();

            double resultCC = AC.CircleCircumference(22);
            Console.WriteLine("Circle Circumference: " + resultCC);

            double resultAC = AC.CircleArea(20);
            Console.WriteLine("Area: " + resultAC);


            TemperatureConverter TC = new TemperatureConverter();

            double resultCF = TC.ConvertCelsiusToFahrenheit(120);
            Console.WriteLine("Celsius to Fahrenheit: " + resultCF);

            double resultCK = TC.ConvertCelsiusToKelvin(100);
            Console.WriteLine("Celsius to Kelvin: " + resultCK);

            double resultFC = TC.ConvertFahrenheitToCelsius(70);
            Console.WriteLine("Fahrenheit to Celsius: " + resultFC);

            double resultFK = TC.ConvertFahrenheitToKelvin(20);
            Console.WriteLine("Fahrenheit to Kelvin: " + resultFK);

            double resultKC = TC.ConvertKelvinToCelsius(50);
            Console.WriteLine("Kelvin to Celsius: " + resultKC);

            double resultKF = TC.ConvertKelvinToFahrenheit(80);
            Console.WriteLine("Kelvin to Fahrenheit: " + resultKF);

            EquationCalculator ECal = new EquationCalculator();

            double resultHypo = ECal.PythagoreanTheorem(65, 130);
            Console.WriteLine("Pythagorean Theorem: " + resultHypo);

            double resultMEE = ECal.MassEnergyEquivalence(1);
            Console.WriteLine("Mass Energy Equivalence: " + resultMEE);

            double resultLOUG = ECal.LawOfUniversalGravitation(100, 150, 200);
            Console.WriteLine("Force by using Law of Universal Gravitation: " + resultLOUG);

            UnitConverter UCal = new UnitConverter();

            double resultKtM = UCal.KilometreToMeter(100);
            Console.WriteLine("Kilometre to Meter: " + resultKtM);

            double resultMtC = UCal.MeterToCentimeter(120);
            Console.WriteLine("Meter to Centimetre: " + resultMtC);

            double resultCTK = UCal.CentimeterToKilometre(50);
            Console.WriteLine("Centimetre to Kilometre: " + resultCTK);

            double resultSKTSM = UCal.SquareKilometerToSquareMile(40);
            Console.WriteLine("Square Kilometre to Square Mile: " + resultSKTSM);

            double resultKTT = UCal.KilogramToTonne(60);
            Console.WriteLine("Kilometre to Tonne: " + resultKTT);

            Set objS1 = new Set();
            objS1.Insert(2);
            objS1.Insert(3);
            objS1.Insert(4);


            Set objS2 = new Set();
            objS2.Insert(3);
            objS2.Insert(4);
            objS2.Insert(5);

            Set resultSet = new Set();


            SetCalculator setCal = new SetCalculator();
            resultSet = setCal.Union(objS1, objS2);


            Console.WriteLine(resultSet.ToString());
            // resultSet.Remove(6);
            //Console.WriteLine(resultSet.ToString());
            SetCalculator setCal2 = new SetCalculator();
            resultSet = setCal2.Intersection(objS1, objS2);


            Console.WriteLine(resultSet.ToString());



        }
    }

}