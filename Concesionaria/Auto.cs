namespace Concesionaria
{
    public class Auto
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Patente { get; set; }
        public int CapacidadTanque { get; set; }
        public int RendimientoLitro { get; set; }
        public int CantCombActual { get; set; }

        public void ActualizarNivelCombustible(int valor)
        {
            CantCombActual += valor;
        }

        public int KilomentrosConCapacidadActual
        {
            get
            {
                return RendimientoLitro* CantCombActual;
            }            
        }

        public int KilomentroTanqueLleno
        {   get
            {
                return (CapacidadTanque*RendimientoLitro);
            }            
        }
    }
}
