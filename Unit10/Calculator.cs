namespace Unit10;

public class Calculator
{
    private ILogger logger { get; }

    public Calculator(ILogger logger)
    {
        this.logger = logger;
    }

    public int SumValues(int a, int b)
    {
        logger.EventSum();
        logger.Result(a + b);
        return a + b;
    }
}