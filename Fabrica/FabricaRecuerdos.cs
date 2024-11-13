// Fabrica/FabricaRecuerdos.cs
using MyApp.Modelo;

namespace MyApp.Fabrica
{
    public abstract class FabricaRecuerdos
    {
        public abstract Memory CrearRecuerdo(CrimeType crimeType);
    }

    public class FabricaRecuerdosConcreta : FabricaRecuerdos
    {
        public override Memory CrearRecuerdo(CrimeType crimeType)
        {
            return crimeType switch
            {
                CrimeType.Robo => new Memory("Robaste una tienda", "Remordimiento"),  // Constructor con parámetros
                CrimeType.Agresion => new Memory("Atacaste a una persona", "Arrepentimiento"),  // Constructor con parámetros
                _ => new Memory("Cometiste un crimen", "Reflexión")  // Constructor con parámetros
            };
        }
    }
}

