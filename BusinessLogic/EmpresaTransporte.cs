namespace BusinessLogic
{
    public class EmpresaTransporte : ICalculadorCotizacion
    {
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public ICollection<Vehiculo> Vehiculos { get; set; }

        private EmpresaTransporte() {}

        public EmpresaTransporte(string nombre, string ubicacion) 
        {
            Nombre = nombre;
            Ubicacion = ubicacion;
            Vehiculos = new List<Vehiculo>();    
        }

        public double CalculadorCotizacion(double peso, double distancia)
        {
            double cotizacion = 0;
            foreach (var vehiculo in Vehiculos)
            {
                cotizacion += vehiculo.CalculadorCotizacion(peso, cotizacion);
            }

            return cotizacion;

            //return Vehiculos.Sum(v => v.CalculadorCotizacion(peso, distancia));
        }
    }
}
