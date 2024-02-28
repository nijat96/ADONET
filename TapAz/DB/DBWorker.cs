using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapAz.DB
{
    public class DBWorker
    {
        public static string connectionString = "Server =.\\SQLEXPRESS ;Database =TapAzDB ;Trusted_Connection = true;Encrypt = false;";

        public static string scriptProduct = "SELECT \r\nProduct.ID,\r\nCategory.Name,\r\nCity.Name,\r\nPrice,\r\nContent,\r\nFullname,\r\nEmail,\r\nContact.Name,\r\nMobilePhone\r\nFROM Product\r\nINNER JOIN Category ON Category.ID = Product.CategoryID\r\nINNER JOIN City ON City.ID = Product.CityID\r\nINNER JOIN Contact ON Contact.ID = Product.ContactID";
        public static string scriptCategory = "SELECT * FROM Category ORDER BY Name";
        public static string scriptCity = "SELECT * FROM City ORDER BY Name";
        public static string scriptContact = "SELECT * FROM Contact";
        public static int selected;


        public static DataTable GetAll(string script, SqlConnection connection)
        {
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand(script, connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            return dt;
        }

        public static void UpdateProduct(int id, int categoryID, int cityID, decimal price, string content, string fullname, string email, int contactID, string mobile)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string scriptUpdate = $"UPDATE Product\r\nSET CategoryID = {categoryID},\r\n\tCityID = {cityID},\r\n\tPrice = {price},\r\n\tContent = {content},\r\n\tFullname = N'{fullname}',\r\n\tEmail = '{email}',\r\n\tContactID = {contactID},\r\n\tMobilePhone = '{mobile}'\r\nWHERE ID = {id}";
                SqlCommand command = new SqlCommand(scriptUpdate, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("item successfuly updated");
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

        public static void DeleteProduct(int id)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string script = $"UPDATE Product\r\nSET Status = 0\r\nWHERE ID = {id}";
                SqlCommand cmd = new SqlCommand(script, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("item succesfully deleted");
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
    }
}
