// Vista/ConsoleView.cs
using ProyectoCognify.Modelo;

namespace ProyectoCognify.Vista
{
    public class ConsoleView
    {
        public static CrimeType GetCrimeTypeFromUser()
        {
            Console.WriteLine("Selecciona el tipo de crimen: 1. Robo 2. Agresión 3. Fraude 4. Otro");
            return Enum.Parse<CrimeType>(Console.ReadLine());
        }

        public static void ShowMemory(Memory memory)
        {
            Console.WriteLine($"Recuerdo: {memory.Content} | Emoción: {memory.Emotion}");
        }
    }
}
