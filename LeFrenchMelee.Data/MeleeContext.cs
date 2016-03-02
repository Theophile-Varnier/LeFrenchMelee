using LeFrenchMelee.Model;
using MySql.Data.Entity;
using System.Data.Entity;

namespace LeFrenchMelee.Data
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class MeleeContext : DbContext
    {
        public MeleeContext()
            : base("MeleeContext")
        {
            Database.SetInitializer(new MeleeContextInitializer());
            Database.Initialize(true);
        }

        public DbSet<Member> Members { get; set; }

        public DbSet<Tournament> Tournaments { get; set; }
    }
}
