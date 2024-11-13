// Modelo/Memory.cs
namespace MyApp.Modelo
{
    public class Memory
{
    public required string Content { get; set; }
    public required string Emotion { get; set; }

    // Constructor para inicializar las propiedades
    public Memory(string content, string emotion)
    {
        Content = content;
        Emotion = emotion;
    }
}

}
