namespace Module10.Interface.Task10
{
    /// <summary>
    /// Сложение
    /// </summary>
    public class Summator : ICalculator
    {
        /// <summary>
        /// Логгер сложения
        /// </summary>
        ILogger Logger { get; }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="logger">Логгер для сложения</param>
        public Summator(ILogger logger)
        {
            Logger = logger;
        }
        /// <summary>
        /// Функция сложения
        /// </summary>
        /// <param name="numberOne">Первое число</param>
        /// <param name="numberTwo">Второе число</param>
        /// <returns>Результат сложения</returns>
        double ICalculator.Solve(double numberOne, double numberTwo)
        {
            double sumResult = numberOne + numberTwo;
            Logger.Event($"Результат сложения {numberOne} + {numberTwo} = {sumResult}");
            return (numberOne + numberTwo);
        }
    }
}
