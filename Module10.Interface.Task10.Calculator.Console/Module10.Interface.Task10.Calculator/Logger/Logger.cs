namespace Module10.Interface.Task10
{
    /// <summary>
    /// Логирование в консоль
    /// </summary>
    public class Logger : ILogger
    {
        /// <summary>
        /// Логирование ошибок в консоль
        /// </summary>
        /// <param name="message">Текст ошибки</param>
        void ILogger.Error(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        /// <summary>
        /// Логирование событий в консоль
        /// </summary>
        /// <param name="message">Текст сообщения</param>
        void ILogger.Event(string message)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
