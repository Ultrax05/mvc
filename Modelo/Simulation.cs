// Modelo/Simulation.cs
using MyApp.Modelo; 
{
    public class Simulation
    {
        private static Simulation _instance;
        public static Simulation Instance => _instance ??= new Simulation();

        private Simulation() {}

        public void StartSimulation(Criminal criminal)
        {
            Console.WriteLine($"Simulación iniciada para el criminal: {criminal.Name}");
        }
    }
}
