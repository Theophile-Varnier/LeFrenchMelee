using LeFrenchMelee.Data;
using LeFrenchMelee.Model;

namespace LeFrenchMelee.Services
{
    public class TournamentService : AbstractService
    {
        public TournamentService(UnitOfWork unitOfWork)
            :base(unitOfWork)
        {

        }

        public Tournament Insert(Tournament tournament)
        {
            return UnitOfWork.TournamentProvider.Add(tournament);
        }
    }
}
