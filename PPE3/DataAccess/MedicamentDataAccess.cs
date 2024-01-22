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
    internal class MedicamentDataAccess
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        public DataTable SelectMedicamentsFromDB()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT libelle_medic AS libelle, contre_indication_medic AS contre_indication, qte_medic AS Quantite FROM medicament";
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
        public DataTable SelectMedicamentsInStockFromDB()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT libelle_medic AS libelle, contre_indication_medic AS contre_indication, qte_medic AS quantité FROM medicament WHERE qte_medic > 0";
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
        public int GetMedicamentIdFromDB(Medicament medicament)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id_medic FROM medicament WHERE libelle_medic = @libelle";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("libelle", medicament.Libelle);
                    int result = (int)command.ExecuteScalar();
                    conn.Close();
                    return result;
                }
            }
        }
        public string AddMedicamentInDB(string libelle, string contre_indication, int qte)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO medicament (libelle_medic, contre_indication_medic, qte_medic) VALUES (@libelle, @contre_indication, @qte)";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@libelle", libelle);
                    command.Parameters.AddWithValue("@contre_indication", contre_indication);
                    command.Parameters.AddWithValue("@qte", qte);
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
        public string AddMedicamentStockInDB(Medicament medicament, int quantity)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE medicament SET qte_medic = qte_medic + @quantity WHERE libelle_medic = @libelle";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@libelle", medicament.Libelle);
                    command.Parameters.AddWithValue("@quantity", quantity);
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
        public string RemoveMedicamentStockInDB(Medicament medicament, int quantity)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE medicament SET qte_medic = qte_medic - @quantity WHERE libelle_medic = @libelle";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@libelle", medicament.Libelle);
                    command.Parameters.AddWithValue("@quantity", quantity);
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
