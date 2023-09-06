using System.ComponentModel.DataAnnotations;

namespace BusinessLogic
{
    public enum TipoCarroceria
    {
        [Display(Description = "Sedán")]
        Sedan,
        SUV,
        Hastchback,
        Coupe,
        Otro
    }
}
