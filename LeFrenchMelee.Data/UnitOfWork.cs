using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeFrenchMelee.Data
{
    public class UnitOfWork
    {
        public UnitOfWork()
        {
            Context = new MeleeContext();
            MemberProvider = new MemberDao(Context);
            TournamentProvider = new TournamentDao(Context);
        }

        private MeleeContext Context;

        public MemberDao MemberProvider { get; private set; }

        public TournamentDao TournamentProvider { get; private set; }
    }
}
