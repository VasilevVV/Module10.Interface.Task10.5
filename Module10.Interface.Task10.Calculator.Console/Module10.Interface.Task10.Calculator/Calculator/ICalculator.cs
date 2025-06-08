namespace Module10.Interface.Task10
{
    /// <summary>
    /// Интерфейс для калькулятора
    /// </summary>
    public interface ICalculator
    {
        /// <summary>
        /// Выполнить математическое действие над двумя числаси
        /// </summary>
        /// <param name="numberOne">Первое число</param>
        /// <param name="numberTwo">Второе число</param>
        /// <returns>Результат действия</returns>
        public double Solve(double numberOne, double numberTwo);
    }
}
