using Pizzeria.Data;
using Pizzeria.DataAccess;
using Pizzeria.Serializers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria
{
    public partial class PizzaForm : Form
    {
        private Pizza data = new Pizza();
        public PizzaForm(Pizza pizzaData)
        {
            this.data = pizzaData;
            InitializeComponent();
            this.pizzaBindingSource.DataSource = data;
        }

        public PizzaForm()
        {
            InitializeComponent();
            this.pizzaBindingSource.DataSource = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataContext.AddOrEditPizza(data) == true)
                {
                    this.Close();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Podczas zapisu wystąpił błąd: " + x.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PizzaForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nazwa pizzy: " + data.PizzaName);
            sb.AppendLine("Grupa: " + data.Group);
            sb.AppendLine("Data ważności: " + data.ValidDate.ToShortDateString());
            sb.AppendLine("Numer seryjny: " + data.LotNumber.ToString());
            sb.AppendLine("Opakowanie: " + data.Package);
            MessageBox.Show(sb.ToString());
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Eksport danych pizze";
                saveFileDialog.Filter = "Pliki formatu Xml (*.xml)|*.xml|Wszystkie pliki (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    PizzaXmlSerializer.Serialize(data, saveFileDialog.FileName);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Podczas eksportu wystąpił błąd: " + x.Message);
            }
        }
    }
}
