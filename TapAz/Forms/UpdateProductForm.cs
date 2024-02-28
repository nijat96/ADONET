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
    public partial class UpdateProductForm : Form
    {
        SqlConnection connection = new SqlConnection(DBWorker.connectionString);
        public UpdateProductForm()
        {
            InitializeComponent();
        }

        private void UpdateProductForm_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                foreach (DataRow dr in DBWorker.GetAll(DBWorker.scriptCategory, connection).Rows)
                {
                    comboBoxCategory.Items.Add(dr[1].ToString());
                }
                foreach (DataRow dr in DBWorker.GetAll(DBWorker.scriptCity, connection).Rows)
                {
                    comboBoxCity.Items.Add(dr[1].ToString());
                }
                foreach (DataRow dr in DBWorker.GetAll(DBWorker.scriptContact, connection).Rows)
                {
                    comboBoxContact.Items.Add(dr[1].ToString());
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int categoryId = 0;
            int cityId = 0;
            int contactId = 0;

            try
            {
                connection.Open();

                string scriptCategory = $"SELECT * FROM Category \nWHERE Name = N'{comboBoxCategory.Text}'";
                string scriptCity = $"SELECT * FROM City \nWHERE Name = N'{comboBoxCity.Text}'";
                string scriptContact = $"SELECT * FROM Contact \nWHERE Name = N'{comboBoxContact.Text}'";

                foreach (DataRow dr in DBWorker.GetAll(scriptCategory, connection).Rows)
                {
                    categoryId = Convert.ToInt32(dr[0]);
                }
                foreach (DataRow dr in DBWorker.GetAll(scriptCity, connection).Rows)
                {
                    cityId = Convert.ToInt32(dr[0]);
                }
                foreach (DataRow dr in DBWorker.GetAll(scriptContact, connection).Rows)
                {
                    contactId = Convert.ToInt32(dr[0]);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            finally
            {
                connection.Close();
            }
            DBWorker.UpdateProduct(id: DBWorker.selected, categoryID: categoryId, cityID: cityId, price: numericUpDownPrice.Value, content: richTextBoxContent.Text, fullname: textBoxFullname.Text, email: textBoxEmail.Text, contactID: contactId, mobile: maskedTextBoxMobile.Text);
            DataGridViewForm a = new DataGridViewForm();
            a.Show();
            this.Close();
        }

        private void richTextBoxContent_KeyPress(object sender, KeyPressEventArgs e)
        {
            int x = richTextBoxContent.TextLength+1;
            labelRemainingSymbol.Text = (richTextBoxContent.MaxLength-x).ToString() + " Symbol left";
        }
    }
}
