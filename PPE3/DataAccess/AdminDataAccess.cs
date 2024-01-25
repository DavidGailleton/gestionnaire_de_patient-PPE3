using MySql.Data.MySqlClient;
using PPE3.Object;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3.DataAccess
{
    internal class AdminDataAccess
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        public DataTable SelectAdminsFromDB()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT login_adm AS login FROM admin";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    conn.Close();
                    return dt;
                }
            }
        }
        public string AddAdminInDB(string login, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO admin (login_adm, password_adm) VALUES (@login, @password)";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@password", BCrypt.Net.BCrypt.EnhancedHashPassword(password, 13));
                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    if (result < 0)
                    {
                        return "Error";
                    }
                    else
                    {
                        return "Success";
                    }
                }
            }
        }
        public bool ConnectAdminFromDB(string login, string pass)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query1 = "SELECT password_adm FROM admin WHERE login_adm = @login";

                using (MySqlCommand command1 = new MySqlCommand(query1, conn))
                {
                    command1.Parameters.AddWithValue("@login", login);
                    string result = Convert.ToString(command1.ExecuteScalar());
                    if (result != "" && result != null && BCrypt.Net.BCrypt.EnhancedVerify(pass, result) == true)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public string VerifyPassword(string login, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query1 = "SELECT password_adm FROM admin WHERE login_adm = @login";

                using (MySqlCommand command1 = new MySqlCommand(query1, conn))
                {
                    command1.Parameters.AddWithValue("@login", login);
                    string result = Convert.ToString(command1.ExecuteScalar());
                    if (result != null && BCrypt.Net.BCrypt.EnhancedVerify(password, result) == true)
                    {
                        return "Success";
                    }
                    else
                    {

                        return "Error";
                    }
                }
            }
        }
        public string UpdateAdminPasswordInDB(string login, string password)
        {
            using (MySqlConnection conn = new(connectionString))
            {
                conn.Open();
                string query = "UPDATE admin SET password_adm = @password, first_connection_adm = 0 WHERE login_adm = @login";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@password", BCrypt.Net.BCrypt.EnhancedHashPassword(password, 13));
                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    if (result < 0)
                    {
                        return "Error";
                    }
                    else
                    {
                        return "Success";
                    }
                }
            }
        }
        public string DeleteAdminInDB(string admin)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM admin WHERE login_adm = @login";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@login", admin);
                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    if (result < 0)
                    {
                        return "Error";
                    }
                    else
                    {
                        return "Success";
                    }
                }
            }
        }
        public string VerifyFirstConnection(string login)
        {
            using (MySqlConnection conn = new(connectionString))
            {
                conn.Open();
                string query = "SELECT first_connection_adm FROM admin WHERE login_adm = @login";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@login", login);
                    int result = Convert.ToInt32(command.ExecuteScalar());
                    conn.Close();
                    if (result == 0)
                    {
                        return "Error";
                    }
                    else
                    {
                        return "Success";
                    }
                }
            }
        }
    }
}
