// Fabrica/MemoryBuilder.cs
using MyApp.Modelo;

namespace MyApp.Fabrica
{
    public class MemoryBuilder
    {
        private string _content;
        private string _emotion;

        public MemoryBuilder SetContent(string content)
        {
            _content = content;
            return this;
        }

        public MemoryBuilder SetEmotion(string emotion)
        {
            _emotion = emotion;
            return this;
        }

        // Cambiar para pasar content y emotion al constructor
        public Memory Build()
        {
            return new Memory(_content, _emotion);  // Constructor con los parámetros correctos
        }
    }
}

