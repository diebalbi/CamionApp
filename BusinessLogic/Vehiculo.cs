namespace BusinessLogic
{
    public abstract class Vehiculo : ICalculadorCotizacion
    {
        private static double _consumoCombustible = 0.2;

        public string Matricula { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public int Carga { get; set; }
        public int CantidadRuedas { get; set; }

        public Vehiculo() {}

        public Vehiculo(string matricula, string modelo, int anio, int carga, int cantidadRuedas)
        {
            Matricula = matricula;
            Modelo = modelo;
            Anio = anio;
            Carga = carga;
            CantidadRuedas = cantidadRuedas;
        }

        public abstract double CalcularCostoCarga(double peso);

        private static double CalcularConsumoCombustible(double distancia)
        {
            return distancia * _consumoCombustible;
        }

        public virtual double CalculadorCotizacion(double peso, double distancia)
        {
            return CalcularConsumoCombustible(distancia) * CalcularCostoCarga(peso);
        }
    }
}
