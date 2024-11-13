// Fabrica/MemoryBuilder.cs
using MyApp.Modelo;

namespace MyApp.Fabrica
{
    public class MemoryBuilder
    {
        private readonly Memory _memory = new Memory();

        public MemoryBuilder SetContent(string content)
        {
            _memory.Content = content;
            return this;
        }

        public MemoryBuilder SetEmotion(string emotion)
        {
            _memory.Emotion = emotion;
            return this;
        }

        public Memory Build()
        {
            return _memory;
        }
    }
}
