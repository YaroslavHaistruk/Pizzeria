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
    public partial class PracownikForm : Form
    {
        private Pracownik data = new Pracownik();
        public PracownikForm(Pracownik pracownikData)
        {
            this.data = pracownikData;
            InitializeComponent();
            this.pracownikBindingSource.DataSource = data;

        }

        public PracownikForm()
        {
            InitializeComponent();
            this.pracownikBindingSource.DataSource = data;
        }

        private void PracownikForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataContext.AddOrEditPracownik(data) == true)
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
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Eksport danych pracownika";
                saveFileDialog.Filter = "Pliki formatu Xml (*.xml)|*.xml|Wszystkie pliki (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    PracownikXmlSerializer.Serialize(data, saveFileDialog.FileName);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Podczas eksportu wystąpił błąd: " + x.Message);
            }

        }
    }
}
