// Fabrica/MemoryBuilder.cs
using MyApp.Modelo;

namespace MyApp.Fabrica
{
    public class MemoryBuilder
    {
        private string _content;
        private string _emotion;

        // Setters para asignar los valores
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

        // Método Build que devuelve el Memory con los parámetros requeridos
        public Memory Build()
        {
            return new Memory(_content, _emotion);  // Se pasa content y emotion al constructor
        }
    }
}
