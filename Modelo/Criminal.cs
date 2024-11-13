// Modelo/Criminal.cs
using System;

namespace MyApp.Modelo
{
    public class Criminal
    {
        // Hacemos que 'Name' sea required en el constructor
        public string Name { get; private set; }
        public CrimeType CrimeType { get; set; }
        public List<Memory> Memories { get; private set; } = new List<Memory>();

        // Constructor para asegurar que 'Name' nunca sea null
        public Criminal(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name)); // Validación de null
        }

        // Método para agregar recuerdos de manera controlada
        public void AddMemory(Memory memory)
        {
            Memories.Add(memory);
        }
    }
}
