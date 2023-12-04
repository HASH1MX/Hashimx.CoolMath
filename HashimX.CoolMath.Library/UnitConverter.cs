namespace HashimX.CoolMath.library;

public class UnitConverter
{
    public double KilometreToMeter(double kilometre)
    {
        Calculator Cal = new Calculator();
        double resultMulti = Cal.Multiplication(kilometre, 1000);

        return resultMulti;

    }

    public double MeterToCentimeter(double metre)
    {

        Calculator Cal = new Calculator();
        double resultMulti = Cal.Multiplication(metre, 100);

        return resultMulti;

    }

    public double CentimeterToKilometre(double centimeter)
    {
        Calculator Cal = new Calculator();
        double resultDiv = Cal.Division(centimeter, 100);

        return resultDiv;
    }

    public double SquareKilometerToSquareMile(double squarekilometer)
    {
        Calculator Cal = new Calculator();
        double resultDiv = Cal.Division(squarekilometer, 2.59);
        return resultDiv;
    }

    public double KilogramToTonne(double kilogram)
    {
        Calculator Cal = new Calculator();
        double resultDiv = Cal.Division(kilogram, 1000);

        return resultDiv;
    }






}