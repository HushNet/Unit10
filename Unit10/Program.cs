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
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Неверное значение!");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            catch (Exception e)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.BackgroundColor = ConsoleColor.Black;
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
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Вычисления завершены");
        Console.BackgroundColor = ConsoleColor.Black;
    }

    public void Result(int result)
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine($"Результат: {result}");
        Console.BackgroundColor = ConsoleColor.Black;
        
    }
}