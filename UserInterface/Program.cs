// See https://aka.ms/new-console-template for more information
using BusinessLogic;

try
{
    Auto auto = new("ABC123", "Toyota", 2023, 200, TipoCarroceria.Sedan);
    int cargaAuto = 100;
    int recoriddoAuto = 20;
    double autoCostoCarga = auto.CalcularCostoCarga(cargaAuto);
    double autoCotizacion = auto.CalculadorCotizacion(cargaAuto, recoriddoAuto);

    Console.WriteLine($"El auto de modelo {auto.Modelo} {auto.TipoCarroceria} año {auto.Anio} con la matrícula {auto.Matricula}, " +
        $"puede cargar hasta {auto.Carga}kg, el precio del costo de carga para {cargaAuto}kg es de ${autoCostoCarga} y la cotización" +
        $"para un recorrido de {recoriddoAuto}km es de ${autoCotizacion}");

    Camion camion = new("DEF456", "Volvo", 2022, 8000, 6, 6);

    EmpresaTransporte empresaTransporte = new("Transporte Veloz", "Montevideo");

}
catch (Exception e)
{
    Console.WriteLine(e.ToString());
}
