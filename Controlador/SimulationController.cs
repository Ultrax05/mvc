// Controlador/SimulationController.cs
using MyApp.Modelo;

namespace MyApp.Controlador
{
    public class SimulationController
    {
        public void StartSimulation()
        {
            // Asegúrate de pasar un nombre al crear un Criminal
            var criminal = new Criminal("Juan Pérez")  // Pasamos el nombre aquí
            {
                CrimeType = CrimeType.Robo
            };
            
            // Ahora podemos usar 'criminal' para iniciar la simulación
            Simulation.Instance.StartSimulation(criminal);
        }
    }
}

