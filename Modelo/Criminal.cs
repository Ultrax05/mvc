// Modelo/Criminal.cs
public class Criminal
{
    public string Name { get; set; }
    public CrimeType CrimeType { get; set; }
    public List<Memory> Memories { get; set; } = new List<Memory>();
}

// Modelo/Memory.cs
public class Memory
{
    public string Content { get; set; }
    public string Emotion { get; set; }
}

// Modelo/Simulation.cs
public class Simulation
{
    private static Simulation _instance; // Implementación Singleton
    public static Simulation Instance => _instance ??= new Simulation();
    
    private Simulation() {} // Constructor privado

    public void StartSimulation(Criminal criminal)
    {
        Console.WriteLine($"Simulación iniciada para el criminal: {criminal.Name}");
    }
}

// Modelo/CrimeType.cs
public enum CrimeType
{
    Theft,
    Assault,
    Fraud,
    Other
}
