// Vista/ConsoleView.cs
using MyApp.Controlador;  // Importa el controlador
using MyApp.Modelo; // Para usar CrimeType, Memory, etc.

namespace MyApp.Vista
{
    public class ConsoleView
{
    public static void Run()
    {
        var crimeType = GetCrimeTypeFromUser();
        var memory = new Memory { Content = "Recuerdo del crimen", Emotion = "Sentimiento" };
        ShowMemory(memory);
    }

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
