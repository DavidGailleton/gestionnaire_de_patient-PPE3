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
    internal class AntecedentDataAccess
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        public DataTable SelectAntecedantsFromDB()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT libelle_ant AS libelle FROM antecedent";
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
        // Importation des antécédents d'un patient
        public DataTable SelectPatientAntecedantsFromDb(Patient patient)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                // Requete SQL important les données antécédants selon la clé primaire du patient
                string query = "SELECT libelle_ant AS libelle FROM antecedent WHERE id_pat = @id_pat";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    PatientDataAccess dataAccess = new PatientDataAccess();
                    command.Parameters.AddWithValue("@id_pat", dataAccess.GetPatientIdFromDB(patient));
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    // Créer une table de données contenants toutes les lignes importées
                    adapter.Fill(dt);
                    conn.Close();
                    return dt;
                }
            }
        }
        public string GetAntecedantIdFromDB(Antecedent antecedant, string id_pat)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id_ant FROM antecedent WHERE libelle_ant = @libelle & id_pat = @id_pat";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@libelle", antecedant.libelle);
                    command.Parameters.AddWithValue("@id_pat", id_pat);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    string result = adapter.ToString();
                    conn.Close();
                    return result;
                }
            }
        } 
        // ajout d'un antécedent dans la base de donnée
        public string AddAntecedantInDB(string libelle, Patient patient)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                // Requete ajoutant un antécedent dans la table antecedent
                string query = "INSERT INTO antecedent (libelle_ant, id_pat) VALUES (@libelle, @id_pat)";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    PatientDataAccess dt = new();
                    // Récupération de l'ID du patient pour l'ajouter à la table antecedant
                    int id_pat = (int)dt.GetPatientIdFromDB(patient);
                    command.Parameters.AddWithValue("@libelle", libelle);
                    command.Parameters.AddWithValue("@id_pat", id_pat);
                    // Execution de la requete
                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    if (result < 0)
                    {
                        return "Error";
                    }
                    return "Success";
                }
            }
        }
    }
}
