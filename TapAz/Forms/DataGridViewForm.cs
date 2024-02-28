using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TapAz.DB;

namespace TapAz.Forms
{
    public partial class DataGridViewForm : Form
    {
        SqlConnection connection = new SqlConnection(DBWorker.connectionString);
        public DataGridViewForm()
        {
            InitializeComponent();
        }

        private void DataGridViewForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DBWorker.GetAll(DBWorker.scriptProduct+"\r\nWHERE Status = 1", connection);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new AddProductForm();
            form.Show();
            this.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateProductForm form = new UpdateProductForm();
            int selectedID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DBWorker.selected = selectedID;
            foreach (DataRow dr in DBWorker.GetAll(DBWorker.scriptProduct + $" \r\nWHERE Product.ID = {selectedID}", connection).Rows)
            {
                form.comboBoxCategory.Text = dr[1].ToString();
                form.comboBoxCity.Text = dr[2].ToString();
                form.numericUpDownPrice.Value = Convert.ToDecimal(dr[3]);
                form.richTextBoxContent.Text = dr[4].ToString();
                form.textBoxFullname.Text = dr[5].ToString();
                form.textBoxEmail.Text = dr[6].ToString();
                form.comboBoxContact.Text = dr[7].ToString();
                form.maskedTextBoxMobile.Text = dr[8].ToString();
            }
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DBWorker.GetAll(DBWorker.scriptProduct + "\r\nWHERE Status = 1", connection);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            DBWorker.DeleteProduct(selectedID);
            button2_Click(sender, e);
            
        }
    }
}
