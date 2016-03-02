using LeFrenchMelee.Data;

namespace LeFrenchMelee.Services
{
    public abstract class AbstractService
    {
        protected readonly UnitOfWork UnitOfWork;

        public AbstractService(UnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }
    }
}
