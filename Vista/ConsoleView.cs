using MyApp.Modelo;
using System;
using System.Collections.Generic;

namespace MyApp.Vista
{
    public class ConsoleView
    {
        private List<Prisoner> prisoners = new List<Prisoner>();

        public void ShowMemory()
        {
            var memory = new Memory("Recuerdo del crimen", "Sentimiento de culpa");
            Console.WriteLine($"Contenido: {memory.Content}, Emoción: {memory.Emotion}");
        }

        public void AddPrisoner()
        {
            Console.Write("Ingrese el nombre del preso: ");
            string name = Console.ReadLine();

            Console.Write("Ingrese el crimen cometido: ");
            string crime = Console.ReadLine();

            Console.Write("Ingrese la sentencia: ");
            string sentence = Console.ReadLine();

            var newPrisoner = new Prisoner(name, crime, sentence);
            prisoners.Add(newPrisoner);

            Console.WriteLine($"Preso {newPrisoner.Name} agregado con éxito.");
        }

        public void ListPrisoners()
        {
            if (prisoners.Count == 0)
            {
                Console.WriteLine("No hay presos registrados.");
                return;
            }

            Console.WriteLine("Lista de presos:");
            foreach (var prisoner in prisoners)
            {
                Console.WriteLine($"Nombre: {prisoner.Name}, Crimen: {prisoner.Crime}, Sentencia: {prisoner.Sentence}");
            }
        }
    }
}
