namespace BusinessLogic
{
    public class Auto : Vehiculo
    {
        private const int CANTIDAD_RUEDAS = 4;
        private static double _costoXKilo = 0.3;
        public TipoCarroceria TipoCarroceria { get; set; }

        public Auto() {}

        public Auto(string matricula, string modelo, int anio, int carga, TipoCarroceria tipoCarroceria)
            : base(matricula, modelo, anio, carga, CANTIDAD_RUEDAS)
        {
            TipoCarroceria = tipoCarroceria;
        }

        public override double CalcularCostoCarga(double peso)
        {
            if (Carga < peso)
            {
                throw new ArgumentException($"El peso excede la carga del auto con matrícula {Matricula}");
            }

            return peso * _costoXKilo;
        }
    }
}
