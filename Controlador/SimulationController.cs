// Controlador/SimulationController.cs
using ProyectoCognify.Modelo;
using ProyectoCognify.Fabrica;
using ProyectoCognify.Vista;

namespace ProyectoCognify.Controlador
{
    public class SimulationController
    {
        private readonly FabricaRecuerdos _fabricaRecuerdos;
        private readonly Simulation _simulation;

        public SimulationController()
        {
            _fabricaRecuerdos = new FabricaRecuerdosConcreta();
            _simulation = Simulation.Instance;
        }

        public void IniciarSimulacion()
        {
            Console.WriteLine("Introduce el nombre del criminal:");
            var nombre = Console.ReadLine();

            var tipoCrimen = ConsoleView.GetCrimeTypeFromUser();
            var criminal = new Criminal { Name = nombre, CrimeType = tipoCrimen };

            var recuerdo = _fabricaRecuerdos.CrearRecuerdo(tipoCrimen);
            criminal.Memories.Add(recuerdo);

            ConsoleView.ShowMemory(recuerdo);

            _simulation.StartSimulation(criminal);
        }
    }
}
