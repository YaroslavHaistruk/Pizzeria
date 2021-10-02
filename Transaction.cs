using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Data
{
        [Table("Transakcje")]
        public class Transaction
        {
            int transactionId = 0;
            int amount = 1;
            decimal price = 1M;

            [Key]
            public int TransactionId
            {
                get { return transactionId; }
                set { transactionId = value; }
            }
            public int Amount
            {
                get { return amount; }
                set { amount = value; }
            }
            public decimal Price
            {
                get { return price; }
                set { price = value; }
            }
            public virtual Client ClientData
            { get; set; }
            public virtual Pizza PizzaData
            { get; set; }

            [NotMapped]
            public string ClientName
            {
                get
                {
                    if (ClientData != null)
                    { return ClientData.ClientName; }
                    else { return ""; }
                }
            }

            [NotMapped]
            public string PizzaName
            {
                get
                {
                    if (PizzaData != null)
                    {
                        return PizzaData.PizzaName;
                    }
                    else
                    {
                        return "";
                    }
                }
            }
        }
    }

