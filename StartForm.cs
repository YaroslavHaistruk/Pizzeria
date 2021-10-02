using Pizzeria.Data;
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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void zamknijAplikacjęToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dodajKlientaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            clientForm.MdiParent = this;
            clientForm.Show();
        }

        private void dodajPizzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PizzaForm pizzaForm = new PizzaForm();
            pizzaForm.MdiParent = this;
            pizzaForm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dodajKlientaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            clientForm.MdiParent = this;
            clientForm.Show();
        }

        private void dodajPizzeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PizzaForm pizzaForm = new PizzaForm();
            pizzaForm.MdiParent = this;
            pizzaForm.Show();
        }

        private void uszeregujWPoziomieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void uszeregujWPionieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void uszeregujKaskadowoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void importujDaneOPizzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Import danych o pizze";
                openFileDialog.Filter = "Pliki formatu Xml (*.xml)|*.xml|Wszystkie pliki (*.*)|*.*";
                openFileDialog.Multiselect = false;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Pizza data = PizzaXmlSerializer.Deserialize(openFileDialog.FileName);
                    PizzaForm productForm = new PizzaForm(data);
                    productForm.MdiParent = this;
                    productForm.Show();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Podczas importu wystąpił błąd: " + x.Message);
            }
        }

        private void importujDaneToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void importujDaneOPizzeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Import danych pizze";
                openFileDialog.Filter = "Pliki formatu Xml (*.xml)|*.xml|Wszystkie pliki (*.*)|*.*";
                openFileDialog.Multiselect = false;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Pizza data = PizzaXmlSerializer.Deserialize(openFileDialog.FileName);
                    PizzaForm pizzaForm = new PizzaForm(data);
                    pizzaForm.MdiParent = this;
                    pizzaForm.Show();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Podczas importu wystąpił błąd: " + x.Message);
            }
        }

        private void importujDaneKlientówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Import danych klientow";
                openFileDialog.Filter = "Pliki formatu Xml (*.xml)|*.xml|Wszystkie pliki (*.*)|*.*";
                openFileDialog.Multiselect = false;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Client data = ClientXmlSerializer.Deserialize(openFileDialog.FileName);
                    ClientForm clientForm = new ClientForm(data);
                    clientForm.MdiParent = this;
                    clientForm.Show();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Podczas importu wystąpił błąd: " + x.Message);
            }
        }
        private void listaKlientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientListForm clientListForm = new ClientListForm();
            clientListForm.MdiParent = this;
            clientListForm.Show();
        }

        private void listaPizzyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PizzaListForm pizzaListForm = new PizzaListForm();
            pizzaListForm.MdiParent = this;
            pizzaListForm.Show();
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm();
            transactionForm.MdiParent = this;
            transactionForm.Show();
        }

        private void listaTransakcjiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionListForm transactionListForm = new TransactionListForm();
            transactionListForm.MdiParent = this;
            transactionListForm.Show();
        }

        private void dodajPracownikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PracownikForm pracownikForm = new PracownikForm();
            pracownikForm.MdiParent = this;
            pracownikForm.Show();
        }

        private void listaPracownikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PracownikListForm pracownikListForm = new PracownikListForm();
            pracownikListForm.MdiParent = this;
            pracownikListForm.Show();
        }

        private void importujDanePracownikówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Import danych pracownikow";
                openFileDialog.Filter = "Pliki formatu Xml (*.xml)|*.xml|Wszystkie pliki (*.*)|*.*";
                openFileDialog.Multiselect = false;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Pracownik data = PracownikXmlSerializer.Deserialize(openFileDialog.FileName);
                    PracownikForm pracownikForm = new PracownikForm(data);
                    pracownikForm.MdiParent = this;
                    pracownikForm.Show();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Podczas importu wystąpił błąd: " + x.Message);
            }
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.MdiParent = this.ParentForm;
            loginForm.ShowDialog();
        }

        private void toolStripLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.MdiParent = this;
            loginForm.Show();
        }
    }
}
