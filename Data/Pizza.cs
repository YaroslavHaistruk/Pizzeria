using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pizzeria.Data
{
    [Table("Pizza")]
    public class Pizza
    {
        int pizzaId = 0;
        string pizzaName = "";
        string group = "";
        DateTime validDate = DateTime.Today.AddMonths(6);
        string lotNumber = "";
        string package = "";

        [Key]
        public int PizzaId
        {
            get { return pizzaId; }
            set { pizzaId = value; }
        }

            [XmlElement("nazwa-pizzy")]  
        public string PizzaName
        {
            get { return pizzaName; }
            set { pizzaName = value; }
        }

        [XmlAttribute("grupa")]
        public string Group
        {
            get { return group; }
            set { group = value; }
        }

        [XmlAttribute("data-waznosci")]
        public DateTime ValidDate
        {
            get { return validDate; }
            set { validDate = value; }
        }

        [XmlAttribute("numer-seryjny")]
        public string LotNumber
        {
            get { return lotNumber; }
            set { lotNumber = value; }
        }

        [XmlAttribute("skladnik")]
        public string Package
        {
            get { return package; }
            set { package = value; }
        }
    }
}

