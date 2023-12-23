namespace HashimX.CoolMath.library;

public class AgeCalculator
{
    public double AgeCalculate(double BirthYear)
    {
        double year = DateTime.Now.Year;
        Calculator Cal = new Calculator();

        double Age = Cal.Subtraction(year, BirthYear);

        return Age;
    }
    public double AgeCalculateWithDOB(DateTime DOB)
    {
        TimeSpan timeSpan = DateTime.Now.Subtract(DOB);
        double timeSpanDays = timeSpan.Days;
        double timeSpanYear = timeSpanDays / 365;
        return timeSpanYear;
    }
}