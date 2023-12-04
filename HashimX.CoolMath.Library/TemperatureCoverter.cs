using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace HashimX.CoolMath.library;

public class TemperatureConverter
{
    public double ConvertCelsiusToFahrenheit(double Celsius)

    {
        Calculator Cal = new Calculator();
        double div = Cal.Division(9, 5);

        double resultMultiply = Cal.Multiplication(Celsius, div);

        double resultAdd = Cal.Addition(resultMultiply, 32);

        return resultAdd;

    }
    public double ConvertCelsiusToKelvin(double Celsius)
    {

        Calculator Cal = new Calculator();
        double resultAdd = Cal.Addition(Celsius, 273.15);

        return resultAdd;
    }
    public double ConvertFahrenheitToCelsius(double Fahrenheit)
    {
        Calculator Cal = new Calculator();
        double resultMinus = Cal.Subtraction(Fahrenheit, 32);
        double resultDiv = Cal.Division(5, 9);
        double resultMulti = Cal.Multiplication(resultMinus, resultDiv);

        return resultMulti;

    }
    public double ConvertFahrenheitToKelvin(double Fahrenheit)
    {
        Calculator Cal = new Calculator();
        double resultMinus = Cal.Subtraction(Fahrenheit, 32);
        double resultDiv = Cal.Division(5, 9);
        double resultMulti = Cal.Multiplication(resultMinus, resultDiv);
        double resultAdd = Cal.Addition(resultMulti, 273.15);

        return resultAdd;


    }
    public double ConvertKelvinToCelsius(double Kelvin)
    {
        Calculator Cal = new Calculator();
        double resultMinus = Cal.Subtraction(Kelvin, 273.15);

        return resultMinus;
    }

    public double ConvertKelvinToFahrenheit(double Kelvin)
    {
        {

            Calculator Cal = new Calculator();
            double resultMinus = Cal.Subtraction(Kelvin, 273.15);
            double resultDiv = Cal.Division(9, 5);
            double resultMulti = Cal.Multiplication(resultMinus, resultDiv);
            double resultAdd = Cal.Addition(resultMulti, 32);

            return resultAdd;


        }
    }
}