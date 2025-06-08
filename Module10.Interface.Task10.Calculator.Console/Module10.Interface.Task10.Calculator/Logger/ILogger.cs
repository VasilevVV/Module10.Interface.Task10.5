namespace Module10.Interface.Task10
{
    /// <summary>
    /// Интерфейс для логгера
    /// </summary>
    public interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }
}
