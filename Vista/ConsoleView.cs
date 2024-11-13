// Vista/ConsoleView.cs
using MyApp.Modelo;

namespace MyApp.Vista
{
    public class ConsoleView
    {
        public void ShowMemory()
        {
            // Asegúrate de pasar 'content' y 'emotion' al crear Memory
            var memory = new Memory("Recuerdo del crimen", "Sentimiento de culpa");
            Console.WriteLine($"Contenido: {memory.Content}, Emoción: {memory.Emotion}");
        }
    }
}

