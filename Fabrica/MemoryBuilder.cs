// Fabrica/MemoryBuilder.cs
using MyApp.Modelo;

namespace MyApp.Fabrica
{
    public class MemoryBuilder
    {
        private string? _content;
        private string? _emotion;

        public MemoryBuilder SetContent(string content)
        {
            _content = content ?? throw new ArgumentNullException(nameof(content));
            return this;
        }

        public MemoryBuilder SetEmotion(string emotion)
        {
            _emotion = emotion ?? throw new ArgumentNullException(nameof(emotion));
            return this;
        }

        public Memory Build()
        {
            // Asegúrate de que ambas propiedades estén configuradas antes de crear el objeto
            if (_content == null || _emotion == null)
                throw new InvalidOperationException("Ambas propiedades 'Content' y 'Emotion' deben ser establecidas");

            return new Memory(_content, _emotion);
        }
    }
}
