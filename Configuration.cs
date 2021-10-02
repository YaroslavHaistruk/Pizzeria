namespace Pizzeria.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Pizzeria.DataAccess.StoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Pizzeria.DataAccess.StoreContext";
        }

        protected override void Seed(Pizzeria.DataAccess.StoreContext context)
        {
            //  This method will be called after migrating to the latest version.

        }
    }
}
