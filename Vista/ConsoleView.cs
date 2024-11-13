// Vista/ConsoleView.cs
using MyApp.Modelo;
using System;
using System.Collections.Generic;

namespace MyApp.Vista
{
    public class ConsoleView
    {
        private List<Criminal> criminals = new List<Criminal>();

        public void ShowMemory()
        {
            var memory = new Memory("Recuerdo del crimen", "Sentimiento de culpa");
            Console.WriteLine($"Contenido: {memory.Content}, Emoción: {memory.Emotion}");
        }

        public void AddCriminal()
        {
            Console.Write("Ingrese el nombre del criminal: ");
            string name = Console.ReadLine();

            Console.Write("Ingrese el tipo de crimen (Robo, Agresion, etc.): ");
            string crimeTypeInput = Console.ReadLine();
            CrimeType crimeType;

            // Verificar que el valor ingresado se pueda convertir a CrimeType
            if (!Enum.TryParse(crimeTypeInput, true, out crimeType))
            {
                Console.WriteLine("Tipo de crimen no válido.");
                return;
            }

            // Crear la instancia de Criminal con el CrimeType especificado
            var newCriminal = new Criminal(name, crimeType);
            criminals.Add(newCriminal);

            Console.WriteLine($"Criminal {newCriminal.Name} agregado con éxito.");
        }

        public void ListCriminals()
        {
            if (criminals.Count == 0)
            {
                Console.WriteLine("No hay criminales registrados.");
                return;
            }

            Console.WriteLine("Lista de criminales:");
            foreach (var criminal in criminals)
            {
                Console.WriteLine($"Nombre: {criminal.Name}, Crimen: {criminal.CrimeType}");
            }
        }
    }
}
