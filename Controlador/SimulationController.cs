// Controlador/SimulationController.cs
using MyApp.Modelo;

namespace MyApp.Controlador
{
    public class SimulationController
    {
        public void StartSimulation()
        {
            // Ahora pasamos el nombre y el tipo de crimen
            var criminal = new Criminal("Juan Pérez", CrimeType.Robo);

            // Usamos 'criminal' para iniciar la simulación
            Simulation.Instance.StartSimulation(criminal);
        }
    }
}
