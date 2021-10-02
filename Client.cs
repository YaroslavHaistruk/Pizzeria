using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Pizzeria.Data
{
    [Table("Klienci")]
    public class Client
    {
        int clientId = 0;
        string clientName = "";
        string address = "";
        string vip = "";
        string description;

        [Key]
        public int ClientId
        {
            get { return clientId; }
            set { clientId = value; }
        }

        [XmlElement("Nazwa Klienta")]
        public string ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }
        [XmlElement("Adress")]
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        [XmlElement("VIP")]
        public string Vip
        {
            get { return vip; }
            set { vip = value; }
        }
        [XmlElement("rabat")]
        public string Description
        {
            get { return description; }
            set { description = value; }

        }
    }
}
