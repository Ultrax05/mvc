// Controlador/SimulationController.cs
using MyApp.Modelo;

namespace MyApp.Controlador
{
    public class SimulationController
    {
        public void StartSimulation()
        {
            var criminal = new Criminal("Juan Pérez", CrimeType.Robo);

            Simulation.Instance.StartSimulation(criminal);
        }
    }
}
