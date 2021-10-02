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

    [Table("Pracownik")]
    public class Pracownik
    {
        int pracownikId = 0;
        string pracownikName = "";
        string group = "";
        DateTime validDate = DateTime.Today.AddMonths(6);
        string haslo = "";
        string telefon = "";
        string address = "";
        int amount = 1;
        string description;

        [Key]
        public int PracownikId
        {
            get { return pracownikId; }
            set { pracownikId = value; }
        }

        [XmlElement("imie-pracownika")]
        public string PracownikName
        {
            get { return pracownikName; }
            set { pracownikName = value; }
        }
        [XmlAttribute("posada")]
        public string Group
        {
            get { return group; }
            set { group = value; }
        }
        [XmlAttribute("data")]
        public DateTime ValidDate
        {
            get { return validDate; }
            set { validDate = value; }
        }
        [XmlAttribute("haslo")]
        public string Haslo
        {
            get { return haslo; }
            set { haslo = value; }
        }
        [XmlElement("telefon")]
        public string Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }
        [XmlElement("Adress")]
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        [XmlElement("pencja")]
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        [XmlElement("opis")]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }

}
