namespace Singleton_Pattern
{
    public class ErrorLogger
    {
        public static ErrorLogger? _instance;
        private ErrorLogger()
        {
            
        }
        public static ErrorLogger CreateLogger()
        {
            if (_instance == null)
            {
                _instance = new ErrorLogger();
            }
            return _instance;
        }
        public void LogError(string message)
        {
            Console.WriteLine($"error : {message}");
        }
    }
}
