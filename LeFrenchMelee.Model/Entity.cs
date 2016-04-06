using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeFrenchMelee.Model
{
    public abstract class Entity
    {
        [ForeignKey("Creator")]
        public int? CreatorId { get; set; }

        public virtual Member Creator { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
