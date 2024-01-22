using MySql.Data.MySqlClient;
using PPE3.DataAccess;
using PPE3.Object;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3
{
    internal class AllergieDataAccess
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        public DataTable SelectAllergiesFromDB()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT libelle_all AS libelle FROM allergie";
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
        public DataTable SelectPatientAllergiesFromDb(Patient patient)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT libelle_all AS libelle FROM etre INNER JOIN allergie ON allergie.id_all = etre.id_all WHERE id_pat = @id_pat";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    PatientDataAccess dataAccess = new PatientDataAccess();
                    command.Parameters.AddWithValue("@id_pat", dataAccess.GetPatientIdFromDB(patient));
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    conn.Close();
                    return dt;
                }
            }
        }
        public int GetAllergieIdFromDB(Allergie allergie)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id_all FROM allergie WHERE libelle_all = @libelle";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@libelle", allergie.libelle);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    int result = (int)command.ExecuteScalar();
                    conn.Close();
                    return result;
                }
            }
        }
        public string AddAllergieInDB(string libelle)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO allergie (libelle_all) VALUE (@libelle)";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@libelle", libelle);
                    int result = (int)command.ExecuteNonQuery();
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
        public string AddAllergieToPatientInDB(Allergie allergie, Patient patient)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO etre (id_all, id_pat) VALUES (@id_all, @id_pat)";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id_all", GetAllergieIdFromDB(allergie));
                    PatientDataAccess dt = new();
                    command.Parameters.AddWithValue("@id_pat", dt.GetPatientIdFromDB(patient));
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
    }
}
