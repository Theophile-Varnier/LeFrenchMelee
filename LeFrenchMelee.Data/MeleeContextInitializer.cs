using LeFrenchMelee.Model;
using System;
using System.Data.Entity;

namespace LeFrenchMelee.Data
{
    public class MeleeContextInitializer : DropCreateDatabaseIfModelChanges<MeleeContext>
    {
        public override void InitializeDatabase(MeleeContext context)
        {
            base.InitializeDatabase(context);
        }

        protected override void Seed(MeleeContext context)
        {
            context.Members.Add(new Member
            {
                Pseudo = "Milo",
                ClearPassword = "password"
            });
            context.Tournaments.Add(new Tournament
            {
                Name = "Gras #6",
                Place = "Grenoble",
                StartDate = new DateTime(2016, 04, 29),
                EndDate = new DateTime(2016, 05, 1, 23, 0, 0),
                CreatorId = 1
            });
            base.Seed(context);
        }
    }
}
