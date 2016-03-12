using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeFrenchMelee.Model
{
    [Table("Tournament")]
    public class Tournament : Event
    {
        [Key]
        public virtual int Id { get; set; }

        public virtual List<AdditionalSubField> Fields { get; set; }
    }
}
