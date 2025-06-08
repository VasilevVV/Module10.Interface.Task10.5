namespace Module10.Interface.Task10
{
    public class Program
    {
        static void Main(string[] args)
        {
            ILogger Logger = new Logger();
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
}
