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
    internal class PatientDataAccess
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        // Retourne tous les patients contenue dans la Table Patient
        public DataTable SelectPatientsFromDB()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                // Requete SQL important les différents éléments nécessaire à la création d'un objet de classe patient
                string query = "SELECT nom_pat AS nom, prenom_pat AS prenom, naissance_pat AS date_de_naissance, sexe_pat AS sexe, no_secu_pat AS numero_de_securite_social FROM patient";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    // Remplie une table de données contenant toutes les données importé de la table patient
                    adapter.Fill(dt);
                    conn.Close();
                    return dt;
                }
            }
        }
        public int GetPatientIdFromDB(Patient patient)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id_pat FROM patient WHERE no_secu_pat = @no_secu";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@no_secu", patient.NoSecu);
                    int result = (int)command.ExecuteScalar();
                    conn.Close();
                    return result;
                }
            }
        }
        // Ajoute un nouveau Patient dans la table patient
        public string AddPatientInDB(Patient patient)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                // Requete SQL permettant d'ajouter un nouveau patient au seins de la table patient
                string query = "INSERT INTO patient (nom_pat, prenom_pat, naissance_pat, sexe_pat, no_secu_pat) VALUES (@nom, @prenom, @naissance, @sexe, @no_secu)";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@nom", patient.Nom);
                    command.Parameters.AddWithValue("@prenom", patient.Prenom);
                    command.Parameters.AddWithValue("@naissance", patient.Naissance);
                    command.Parameters.AddWithValue("@sexe", patient.Sexe);
                    command.Parameters.AddWithValue("@no_secu", patient.NoSecu);
                    
                    // Execution de la requete SQL
                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    // Retourne un erreur si la requete n'affecte aucune ligne, sinon retourne "Success"
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
