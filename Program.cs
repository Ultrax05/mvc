using MyApp.Vista; // Referencia a la clase Vista
namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConsoleView.Run();  // Esto es correcto para un método estático
        }
    }
}
