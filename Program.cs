using MyApp.Vista;

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var view = new ConsoleView();

            while (true)
            {
                Console.WriteLine("1. Agregar nuevo preso");
                Console.WriteLine("2. Ver lista de presos");
                Console.WriteLine("3. Mostrar recuerdo");
                Console.WriteLine("4. Salir");
                Console.Write("Elige una opción: ");

                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        view.AddPrisoner();
                        break;
                    case "2":
                        view.ListPrisoners();
                        break;
                    case "3":
                        view.ShowMemory();
                        break;
                    case "4":
                        return; // Salir del programa
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}
