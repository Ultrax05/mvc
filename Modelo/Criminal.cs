// Modelo/Criminal.cs
namespace ProyectoCognify.Modelo
{
    public class Criminal
    {
        public string Name { get; set; }
        public CrimeType CrimeType { get; set; }
        public List<Memory> Memories { get; set; } = new List<Memory>();
    }
}
