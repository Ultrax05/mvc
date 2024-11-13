using MyApp.Vista; // Referencia a la clase Vista

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Crear una instancia de ConsoleView
            var view = new ConsoleView();
            
            // Llamar al método ShowMemory en la instancia
            view.ShowMemory(); 
        }
    }
}
