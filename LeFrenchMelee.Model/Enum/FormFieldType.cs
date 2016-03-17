using System.ComponentModel.DataAnnotations;

namespace LeFrenchMelee.Model.Enum
{
    public enum FormFieldType
    {
        [Display(Name = "Texte")]
        Text,
        [Display(Name = "Nombre")]
        Number,
        Checkbox
    }
}
