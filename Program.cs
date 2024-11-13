using MyApp.Vista; // Referencia a la clase Vista
namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Crear la instancia de la vista y ejecutar el programa
            ConsoleView view = new ConsoleView();
            view.Run();
        }
    }
}
