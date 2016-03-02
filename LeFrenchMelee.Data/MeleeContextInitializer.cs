using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeFrenchMelee.Data
{
    public class MeleeContextInitializer : DropCreateDatabaseIfModelChanges<MeleeContext>
    {
        public override void InitializeDatabase(MeleeContext context)
        {
            base.InitializeDatabase(context);
        }
    }
}
