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
    public partial class ClientForm : Form
    {
        private Client data = new Client();
        public ClientForm(Client clientData)
        {
            this.data = clientData;
            InitializeComponent();
            this.clientBindingSource.DataSource = data;
        }

        public ClientForm()
        {
            InitializeComponent();
            this.clientBindingSource.DataSource = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataContext.AddOrEditClient(data) == true)
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

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clientBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nazwa produktu: " + data.ClientName);
            sb.AppendLine("Adress: " + data.Address);
            sb.AppendLine("Opakowanie: " + data.Vip);
            sb.AppendLine("Opis produktu: " + data.Description);
            MessageBox.Show(sb.ToString());
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Eksport danych klienta";
                saveFileDialog.Filter = "Pliki formatu Xml (*.xml)|*.xml|Wszystkie pliki (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ClientXmlSerializer.Serialize(data, saveFileDialog.FileName);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Podczas eksportu wystąpił błąd: " + x.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
