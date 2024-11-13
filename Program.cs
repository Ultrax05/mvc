using MyApp.Modelo;
using System;
using System.Collections.Generic;

namespace MyApp
{
    public class Program
    {
        private static List<Criminal> criminales = new List<Criminal>();

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Agregar nuevo criminal");
                Console.WriteLine("2. Listar criminales");
                Console.WriteLine("3. Salir");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarNuevoCriminal();
                        break;
                    case "2":
                        ListarCriminales();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }
            }
        }

        private static void AgregarNuevoCriminal()
        {
            Console.Write("Ingrese el nombre del criminal: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Seleccione el tipo de crimen:");
            Console.WriteLine("1. Robo");
            Console.WriteLine("2. Agresión");
            Console.WriteLine("3. Otro");

            CrimeType tipoCrimen;
            string tipoOpcion = Console.ReadLine();
            tipoCrimen = tipoOpcion switch
            {
                "1" => CrimeType.Robo,
                "2" => CrimeType.Agresion,
                _ => CrimeType.Otro
            };

            Criminal nuevoCriminal = new Criminal(nombre) { CrimeType = tipoCrimen };
            criminales.Add(nuevoCriminal);
            Console.WriteLine($"Criminal {nombre} agregado exitosamente.\n");
        }

        private static void ListarCriminales()
        {
            Console.WriteLine("Lista de criminales:");
            foreach (var criminal in criminales)
            {
                Console.WriteLine($"Nombre: {criminal.Name}, Tipo de Crimen: {criminal.CrimeType}");
            }
        }
    }
}

