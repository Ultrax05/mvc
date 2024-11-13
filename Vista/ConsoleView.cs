using MyApp.Modelo;
using System;
using System.Collections.Generic;

namespace MyApp.Vista
{
    public class ConsoleView
    {
        private List<Criminal> prisoners = new List<Criminal>();

        public void ShowMemory()
        {
            var memory = new Memory("Recuerdo del crimen", "Sentimiento de culpa");
            Console.WriteLine($"Contenido: {memory.Content}, Emoción: {memory.Emotion}");
        }

        public void AddPrisoner()
        {
            Console.Write("Ingrese el nombre del criminal: ");
            string name = Console.ReadLine();

            Console.Write("Ingrese el tipo de crimen cometido: ");
            string crimeTypeInput = Console.ReadLine();

            if (!Enum.TryParse<CrimeType>(crimeTypeInput, true, out var crimeType))
            {
                Console.WriteLine("Tipo de crimen inválido. Inténtelo de nuevo.");
                return;
            }

            var newCriminal = new Criminal(name) { CrimeType = crimeType };
            prisoners.Add(newCriminal);

            Console.WriteLine($"Criminal {newCriminal.Name} agregado con éxito.");
        }

        public void ListPrisoners()
        {
            if (prisoners.Count == 0)
            {
                Console.WriteLine("No hay criminales registrados.");
                return;
            }

            Console.WriteLine("Lista de criminales:");
            foreach (var criminal in prisoners)
            {
                Console.WriteLine($"Nombre: {criminal.Name}, Tipo de Crimen: {criminal.CrimeType}");
            }
        }
    }
}
