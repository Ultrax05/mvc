// Modelo/Simulation.cs
using MyApp.Modelo;

namespace MyApp.Modelo
{
    public class Simulation
    {
        // Inicialización correcta de la instancia
        private static Simulation? _instance;
        public static Simulation Instance => _instance ??= new Simulation();  // El operador ??= garantiza que solo se cree una vez

        private Simulation() {}

        // Método para iniciar la simulación
        public void StartSimulation(Criminal criminal)
        {
            if (criminal == null) throw new ArgumentNullException(nameof(criminal)); // Validación de null
            Console.WriteLine($"Simulación iniciada para el criminal: {criminal.Name}");
        }
    }
}
