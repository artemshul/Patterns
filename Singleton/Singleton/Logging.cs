namespace Singleton
{
    public class Logging
    {
        private static Logging instance = null;
        private string user;

        protected Logging(string l)
        {
            user = l;
            using (StreamWriter write = new StreamWriter("log.txt", true))
            {
                write.WriteLine("");
            }
        }

        public static Logging Initialize(string name)
        {
            if (instance == null)
            {
                instance = new Logging(name);
            }
            return instance;
        }

        public void Log(string message)
        {
            using (StreamWriter writer = new StreamWriter("log.txt", true))
            {
                writer.WriteLine($"{DateTime.Now}: {user} {message}");
            }
        }
    }
}
