using Pizzeria.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.DataAccess
{
    
    
    class DataContext

    {
        
        static StoreContext context = new StoreContext();
        public static StoreContext Context
        {
            get { return context; }
        }

        public static List<Client> GetClientList()
        {
            return context.Clients.ToList();
        }
      
        public static List<Pizza> GetPizzaList()
        {
            return context.Pizzas.ToList();
        }
        public static List<Transaction> GetTransactionList()
        {
            return context.Transactions.ToList();
        }
        public static List<Pracownik> GetPracownikList()
        {
            return context.Pracowniks.ToList();
        }




        public static bool AddOrEditClient(Client value)
        {
            if (value.ClientId == 0)
            {
                value.ClientId = context.Clients.Count() > 0 ? context.Clients.Max(x => x.ClientId) + 1 : 1;
                context.Clients.Add(value);
            }
            else
            {
                Client client = context.Clients.FirstOrDefault(x => x.ClientId == value.ClientId);
                if (client != null)
                {
                    client.ClientName = value.ClientName;
                    client.Address = value.Address;
                    client.Description = value.Description;
                    client.Vip = value.Vip;
                }
            }
            context.SaveChanges();
            return true;
        }
        public static bool AddOrEditPizza(Pizza value)
        {
            if (value.PizzaId == 0)
            {
                value.PizzaId = context.Pizzas.Count() > 0 ? context.Pizzas.Max(x => x.PizzaId) + 1 : 1;
                context.Pizzas.Add(value);
            }
            else
            {
                Pizza pizza = context.Pizzas.FirstOrDefault(x => x.PizzaId == value.PizzaId);
                if (pizza != null)
                {
                    pizza.PizzaName = value.PizzaName;
                    pizza.Group = value.Group;
                    pizza.ValidDate = value.ValidDate;
                    pizza.LotNumber = value.LotNumber;
                    pizza.Package = value.Package;
                }
            }
            context.SaveChanges();
            return true;
        }
        
        public static bool AddOrEditTransaction(Transaction value)
        {
            if (value.TransactionId == 0)
            {
                value.TransactionId = context.Transactions.Count() > 0 ? context.Transactions.Max(x => x.TransactionId) + 1 : 1;
                context.Transactions.Add(value);
            }
            else
            {
                Transaction trans = context.Transactions.FirstOrDefault(x => x.TransactionId == value.TransactionId);
                if (trans != null)
                {
                    trans.Amount = value.Amount;
                    trans.Price = value.Price;
                    trans.ClientData = value.ClientData;
                    trans.PizzaData = value.PizzaData;
                }
            }
            context.SaveChanges();
            return true;
        }
        public static bool AddOrEditPracownik(Pracownik value)
        {
            if (value.PracownikId == 0)
            {
                value.PracownikId = context.Pracowniks.Count() > 0 ? context.Pracowniks.Max(x => x.PracownikId) + 1 : 1;
                context.Pracowniks.Add(value);
            }
            else
            {
                Pracownik pracownik = context.Pracowniks.FirstOrDefault(x => x.PracownikId == value.PracownikId);
                if (pracownik != null)
                {
                    pracownik.PracownikName = value.PracownikName;
                    pracownik.Group = value.Group;
                    pracownik.ValidDate = value.ValidDate;
                    pracownik.Haslo = value.Haslo;
                    pracownik.Telefon = value.Telefon;
                    pracownik.Address = value.Address;
                    pracownik.Amount = value.Amount;
                    pracownik.Description = value.Description;
                }
            }
            context.SaveChanges();
            return true;
        }

    }
}
