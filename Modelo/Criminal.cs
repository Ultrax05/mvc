// Modelo/Criminal.cs
using System;

namespace MyApp.Modelo
{
    public class Criminal
    {
        public string Name { get; private set; }
        public CrimeType CrimeType { get; private set; }  // Deja el set privado
        public List<Memory> Memories { get; private set; } = new List<Memory>();

        // Modificar el constructor para incluir CrimeType
        public Criminal(string name, CrimeType crimeType)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            CrimeType = crimeType;
        }

        public void AddMemory(Memory memory)
        {
            Memories.Add(memory);
        }
    }
}
