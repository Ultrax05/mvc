// Modelo/Criminal.cs
using System;
using System.Collections.Generic;

namespace MyApp.Modelo
{
    public class Criminal
    {
        // Nombre del criminal, requerido en el constructor
        public string Name { get; private set; }

        // Tipo de crimen, opcional en el constructor
        public CrimeType CrimeType { get; private set; }

        // Lista de recuerdos asociados con el criminal
        public List<Memory> Memories { get; private set; } = new List<Memory>();

        // Constructor que asegura que 'Name' no sea nulo
        public Criminal(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        // Sobrecarga del constructor para inicializar el nombre y el tipo de crimen
        public Criminal(string name, CrimeType crimeType) : this(name)
        {
            CrimeType = crimeType;
        }

        // Método para agregar recuerdos al criminal
        public void AddMemory(Memory memory)
        {
            if (memory == null) throw new ArgumentNullException(nameof(memory));
            Memories.Add(memory);
        }

        // Método para establecer el tipo de crimen después de la creación del objeto
        public void SetCrimeType(CrimeType crimeType)
        {
            CrimeType = crimeType;
        }
    }
}
