namespace Averages;

public static class AverageCalculator
{
    public static double ArithmeticMean(string[] values)
    {
        double sum = default;
        foreach (var value in values)
        {
            if (double.TryParse(value, out double nvalue))
            {
                sum += nvalue;
            }
            else
                continue; // loop after invalid value
        }
        return sum;
    }

    public static double ArithmeticAverage(string[] values)
    {
        return values.Select(arg => double.Parse(arg)).Average();
    }
}
