using LeFrenchMelee.Model;

namespace LeFrenchMelee.Data
{
    public class NewsDao : AbstractDao<News>
    {
        public NewsDao(MeleeContext context)
            : base(context)
        {

        }
    }
}
