using DBus;

namespace Main
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Bus.System.Close();
        }
    }
}
