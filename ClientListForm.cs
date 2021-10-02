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
    public partial class ClientListForm : Form
    {
        public ClientListForm()
        {
            InitializeComponent();
            this.clientBindingSource.DataSource = DataContext.GetClientList();
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClientListForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            clientForm.MdiParent = this.ParentForm;
            clientForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                Client client = row.DataBoundItem as Client;
                if (client != null)
                {
                    ClientForm clientForm = new ClientForm(client);
                    clientForm.MdiParent = this.ParentForm;
                    clientForm.Show();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = DataContext.GetClientList();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 30, 10);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog pvDialog = new PrintPreviewDialog();
            pvDialog.Document = printDocument1;
            pvDialog.PrintPreviewControl.Zoom = 1; pvDialog.ShowDialog();
        }
    }
}
