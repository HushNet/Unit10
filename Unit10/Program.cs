using Unit10;

public class Program
{
    static void Main(string[] args)
    {
        ILogger logger = new Logger();

        Calculator calculator = new Calculator(logger);

        while (true)
        {
            try
            {
                Console.WriteLine("Введите значение 1: ");
                int value1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите значение 2: ");
                int value2 = Convert.ToInt32(Console.ReadLine());
                calculator.SumValues(value1, value2);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Неверное значение!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}


public interface ILogger
{
    void EventSum();
    void Result(int result);
}

public class Logger : ILogger
{
    public void EventSum()
    {
        Console.WriteLine("Вычисления завершены");
    }

    public void Result(int result)
    {
        Console.WriteLine($"Результат: {result}");
    }
}