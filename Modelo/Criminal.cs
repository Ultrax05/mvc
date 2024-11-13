// Modelo/Criminal.cs
using System;

namespace MyApp.Modelo
{
    public class Criminal
    {
        public string Name { get; set; }
        public CrimeType CrimeType { get; set; }
        public List<Memory> Memories { get; set; } = new List<Memory>();
    }
}
