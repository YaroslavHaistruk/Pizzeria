using Pizzeria.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.DataAccess
{
    class StoreContext : DbContext
    {
        public StoreContext()
          : base("PizzeriaDbContext")
        {
        }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Pracownik> Pracowniks { get; set; }
    }
}
