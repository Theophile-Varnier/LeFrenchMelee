using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeFrenchMelee.Model
{
    public class Event
    {
        public virtual string Name { get; set; }

        public virtual string Place { get; set; }

        [ForeignKey("Creator")]
        public int? CreatorId { get; set; }

        public virtual Member Creator { get; set; }

        public virtual DateTime StartDate { get; set; }

        public virtual DateTime EndDate { get; set; }
    }
}
