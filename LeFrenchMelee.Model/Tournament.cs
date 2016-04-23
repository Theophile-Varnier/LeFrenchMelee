using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeFrenchMelee.Model
{
    [Table("Tournament")]
    public class Tournament : Event
    {
        public virtual List<AdditionalSubField> Fields { get; set; }
    }
}
