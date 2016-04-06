using System;

namespace LeFrenchMelee.Model
{
    public class Event : Entity
    {
        public virtual string Name { get; set; }

        public virtual string Place { get; set; }

        public virtual DateTime StartDate { get; set; }

        public virtual DateTime EndDate { get; set; }
    }
}
