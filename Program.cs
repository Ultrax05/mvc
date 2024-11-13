using MyApp.Vista; // Referencia a la clase Vista
namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConsoleView.ShowMemory();  // Esto es correcto para un método estático
        }
    }
}
