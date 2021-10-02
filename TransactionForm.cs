using Pizzeria.Data;
using Pizzeria.DataAccess;
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
    
    public partial class TransactionForm : Form
    {
        private Transaction data = new Transaction();

        
        public TransactionForm(Transaction transactionData)
        {
            this.data = transactionData;
            InitializeComponent();
            this.transactionBindingSource.DataSource = data;
            this.clientBindingSource.DataSource = DataContext.GetClientList();
            this.pizzaBindingSource.DataSource = DataContext.GetPizzaList();
            if (data != null)
            {
                if (data.ClientData != null)
                {
                    this.comboBox1.SelectedValue = data.ClientData.ClientId;
                }
                if (data.PizzaData != null)
                {
                    this.comboBox2.SelectedValue = data.PizzaData.PizzaId;
                }
            }
        }
        
        public TransactionForm()
        {
            InitializeComponent();
            this.transactionBindingSource.DataSource = data;
            this.clientBindingSource.DataSource = DataContext.GetClientList();
            this.pizzaBindingSource.DataSource = DataContext.GetPizzaList();
            if (data != null)
            {
                if (data.ClientData != null)
                {
                    this.comboBox1.SelectedValue = data.ClientData.ClientId;
                }
                if (data.PizzaData != null)
                {
                    this.comboBox2.SelectedValue = data.PizzaData.PizzaId;
                }
            }
        }



        private void TransactionForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int clientId = (int)this.comboBox1.SelectedValue;
                data.ClientData = DataContext.GetClientList().Find(o => o.ClientId == clientId);
                if (data.ClientData == null)
                {
                    MessageBox.Show("Wybierz klienta");
                    return;
                }
                int pizzaId = (int)this.comboBox2.SelectedValue;
                data.PizzaData = DataContext.GetPizzaList().Find(o => o.PizzaId == pizzaId);
                if (data.PizzaData == null)
                {
                    MessageBox.Show("Wybierz Pizze");
                    return;
                }
                if (DataContext.AddOrEditTransaction(data) == true)
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
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

