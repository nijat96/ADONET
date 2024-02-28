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
    public partial class AddProductForm : Form
    {
        SqlConnection connection = new SqlConnection(DBWorker.connectionString);
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                //Category
                //string scriptCategory = "SELECT * FROM Category ORDER BY Name";
                foreach (DataRow dr in DBWorker.GetAll(DBWorker.scriptCategory, connection).Rows)
                {
                    comboBoxCategory.Items.Add(dr[1].ToString());
                }

                //City
                //string scriptCity = "SELECT Name FROM City ORDER BY Name";
                foreach (DataRow dr in DBWorker.GetAll(DBWorker.scriptCity, connection).Rows)
                {
                    comboBoxCity.Items.Add(dr[1].ToString());
                }

                // Contact
                //string scriptContact = "SELECT Name FROM Contact";
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                int categoryId = 0;
                int cityId = 0;
                int contactId = 0;

                string scriptCategory = $"SELECT * FROM Category \nWHERE Name = N'{comboBoxCategory.SelectedItem}'";
                string scriptCity = $"SELECT * FROM City \nWHERE Name = N'{comboBoxCity.SelectedItem}'";
                string scriptContact = $"SELECT * FROM Contact \nWHERE Name = N'{comboBoxContact.SelectedItem}'";

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

                string script = "INSERT INTO Product(CategoryID,CityID,Price,Content,Fullname,Email,ContactID,MobilePhone)" +
                                             $"VALUES({categoryId},{cityId},{numericUpDownPrice.Value},N'{richTextBoxContent.Text}',N'{textBoxFullname.Text}',N'{textBoxEmail.Text}',{contactId},N'{maskedTextBoxMobile.Text}')";
                SqlCommand cmd = new SqlCommand(script, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfuly added");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            finally
            {
                connection.Close();
            }
            DataGridViewForm form = new DataGridViewForm();
            form.Show();
            this.Close();
        }

        private void richTextBoxContent_KeyPress(object sender, KeyPressEventArgs e)
        {
            int x = richTextBoxContent.TextLength+1;
            labelRemainingSymbol.Text = (richTextBoxContent.MaxLength - x).ToString() + " Symbol left";
        }
    }
}
