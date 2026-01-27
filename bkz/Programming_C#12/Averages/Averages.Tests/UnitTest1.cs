namespace Averages.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void SingleInputShouldProduceSameOutput()
    {
        string[] inputs = { "1" };
        var result = AverageCalculator.ArithmeticMean(inputs) - 1.0;
        Assert.That(result, Is.EqualTo(1.0).Within(1.0));
    }

    [Test]
    public void MultipleInputShouldProduceAverageAsResult()
    {
        string[] inputs = { "1", "2", "3", "4" };
        var result = AverageCalculator.ArithmeticMean(inputs);
        Assert.That(result, Is.EqualTo(2.0).Within(1E-14));
    }

    [Test]
    public void MultipleStringInputShouldProduceZeroResult()
    {
        string[] inputs = { "hello", "world", "c#", "programming" };
        var result = AverageCalculator.ArithmeticMean(inputs);
        Assert.That(result, Is.EqualTo(0.0).Within(0.0));
    }
}
