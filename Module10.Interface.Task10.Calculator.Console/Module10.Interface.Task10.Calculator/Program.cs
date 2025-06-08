namespace Module10.Interface.Task10.Calculator
{
    public class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {            
            Logger = new Logger();
            ICalculator summatorFirst = new Summator(Logger);
            double numberOne;
            double numberTwo;
            double sumResult;      
            try
            {
                Logger.Event("Введите первое число для сложения:");
                while (!double.TryParse(Console.ReadLine(), out numberOne))
                {
                    Logger.Error("Первое число введено неправильно, попробуйте снова:");                    
                }
                Logger.Event("Введите второе число для сложения.");
                while (!double.TryParse(Console.ReadLine(), out numberTwo))
                {
                    Logger.Error("Второе число введено неправильно, попробуйте снова:");
                }
                sumResult = summatorFirst.Solve(numberOne, numberTwo);
            }
            catch (Exception ex)
            {
                Logger.Error($"Ошибка: {ex.Message}");
            }


            Console.ReadKey();
        }
    }

    public interface ICalculator
    {
        public double Solve(double numberOne, double numberTwo);
    }

    public class Summator : ICalculator
    {
        ILogger Logger { get; }
        public Summator(ILogger logger)
        {
            Logger = logger;
        }
        double ICalculator.Solve(double numberOne, double numberTwo)
        {            
            double sumResult = numberOne + numberTwo;
            Logger.Event($"Результат сложения {numberOne} + {numberTwo} = {sumResult}");
            return (numberOne + numberTwo);
        }
    }

    public interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }

    public class Logger : ILogger
    {
        void ILogger.Error(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        void ILogger.Event(string message)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
