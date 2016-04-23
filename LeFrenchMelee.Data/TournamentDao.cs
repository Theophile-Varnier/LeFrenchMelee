using LeFrenchMelee.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeFrenchMelee.Data
{
    public class TournamentDao : AbstractDao<Tournament>
    {
        public TournamentDao(MeleeContext context)
            : base(context)
        {
        }
    }
}
