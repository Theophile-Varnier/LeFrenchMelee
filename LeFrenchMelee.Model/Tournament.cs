using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeFrenchMelee.Model
{
    [Table("Tournaments")]
    public class Tournament : Event
    {
        [Key]
        public virtual int Id { get; set; }
    }
}
