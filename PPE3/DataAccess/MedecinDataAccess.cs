using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Crypto.Generators;
using PPE3.Object;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Resolvers;

namespace PPE3.DataAccess
{
    internal class MedecinDataAccess
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        public DataTable SelectMedecinsFromDB()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT nom_med AS nom, prenom_med AS prenom, naissance_med AS date_de_naissance, login_med AS login FROM medecin";
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
        public int GetMedecinIdFromDB(Medecin medecin)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id_med FROM medecin WHERE login_med = @login";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("login", medecin.Login);
                    int result = (int)command.ExecuteScalar();
                    MessageBox.Show(result.ToString());
                    conn.Close();
                    return result;
                }
            }
        }
        public string AddMedecinInDB(Medecin medecin, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO medecin (nom_med, prenom_med, naissance_med, login_med, password_med) VALUES (@nom, @prenom, @naissance, @login, @password)";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@nom", medecin.Nom);
                    command.Parameters.AddWithValue("@prenom", medecin.Prenom);
                    command.Parameters.AddWithValue("@naissance", medecin.Naissance);
                    command.Parameters.AddWithValue("@login", medecin.Login);
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
        public string DeleteMedecinInDB(Medecin medecin)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM medecin WHERE login_med = @login";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@login", medecin.Login);
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
        public string UpdateMedecinPasswordInDB(string login, string password)
        {
            using (MySqlConnection conn = new(connectionString))
            {
                conn.Open();
                string query = "UPDATE medecin SET password_med = @password, first_connection_med = 0 WHERE login_med = @login";
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
        public string VerifyFirstConnection(string login)
        {
            using (MySqlConnection conn = new(connectionString))
            {
                conn.Open();
                string query = "SELECT first_connection_med FROM medecin WHERE login_med = @login";
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
        public string VerifyPassword(string login, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query1 = "SELECT password_med FROM medecin WHERE login_med = @login";

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
        public Medecin ConnectMedecinFromDB(string login, string pass)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query1 = "SELECT password_med FROM medecin WHERE login_med = @login";
                string query2 = "SELECT nom_med, prenom_med, naissance_med, login_med FROM medecin WHERE login_med = @login";

                using (MySqlCommand command1 = new MySqlCommand(query1, conn))
                {
                    command1.Parameters.AddWithValue("@login", login);
                    string result = Convert.ToString(command1.ExecuteScalar());
                    if (result != null && result != "" && BCrypt.Net.BCrypt.EnhancedVerify(pass, result) == true)
                    {
                        using (MySqlCommand command2 = new MySqlCommand(query2, conn))
                        {
                            command2.Parameters.AddWithValue("@login", login);
                            MySqlDataAdapter adapter2 = new MySqlDataAdapter(command2);
                            DataTable dt = new DataTable();
                            dt.Columns.Add("nom_med", typeof(string));
                            dt.Columns.Add("prenom_med", typeof(string));
                            dt.Columns.Add("naissance_med", typeof(DateTime));
                            dt.Columns.Add("login_med", typeof(string));
                            adapter2.Fill(dt);
                            conn.Close();
                            List<Medecin> medecins = new();
                            if (dt.Rows.Count > 0)
                            {
                                foreach (DataRow row in dt.Rows)
                                {
                                    string nom = row["nom_med"].ToString();
                                    string prenom = row["prenom_med"].ToString();
                                    DateTime dateTime = (DateTime)row["naissance_med"];
                                    string log = row["login_med"].ToString();

                                    Medecin med = new(nom, prenom, dateTime, log);

                                    medecins.Add(med);
                                }
                                return medecins[0];
                            }
                            else
                            {
                                Medecin med = new("", "", DateTime.UtcNow, "");
                                return med;
                            }
                        }
                    }
                    else
                    {
                        Medecin med = new("", "", DateTime.UtcNow, "");
                        return med;
                    }
                }
            }
        }
    }
}