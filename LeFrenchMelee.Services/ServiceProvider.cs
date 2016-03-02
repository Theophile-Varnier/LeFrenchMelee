using LeFrenchMelee.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeFrenchMelee.Services
{
    public class ServiceProvider
    {
        private readonly UnitOfWork unitOfWork = new UnitOfWork();

        private TournamentService tournamentService;

        public TournamentService TournamentService
        {
            get { return tournamentService ?? (tournamentService = new TournamentService(unitOfWork)); }
        }
    }
}
