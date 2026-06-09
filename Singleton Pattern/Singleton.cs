namespace Singleton_Pattern
{
    public class Singleton
    {
        public static Singleton? _instance;
        private Singleton()
        {
            
        }
        public static Singleton CreateInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }
}
