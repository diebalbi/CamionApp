namespace BusinessLogic
{
    public class Camion : Vehiculo
    {
        private int _longitudCaja;
        private static double _costoXKilo = 0.7;
        public int LongitudCaja { 
            get => _longitudCaja; 
            set {
                if (value < 4 || value > 8)
                    throw new ArgumentException("La longitud debe ser entre 4 a 8 metros");
                _longitudCaja = value;
            }
        }

        private Camion() { }

        public Camion(string matricula, string modelo, int anio, int carga, int cantidadRuedas, int longitudCaja) 
            : base(matricula, modelo, anio, carga, cantidadRuedas)
        {
            LongitudCaja = longitudCaja;
        }

        public override double CalcularCostoCarga(double peso)
        {
            if (Carga < peso)
            {
                throw new ArgumentException($"El peso excede la carga del camión con matrícula {Matricula}");
            }

            return peso * _costoXKilo;
        }
    }
}