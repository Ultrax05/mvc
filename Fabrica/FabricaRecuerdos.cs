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
                CrimeType.Theft => new Memory { Content = "Robaste una tienda", Emotion = "Remordimiento" },
                CrimeType.Assault => new Memory { Content = "Atacaste a una persona", Emotion = "Arrepentimiento" },
                _ => new Memory { Content = "Cometiste un crimen", Emotion = "Reflexión" }
            };
        }
    }
}
