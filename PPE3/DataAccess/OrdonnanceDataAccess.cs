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
    internal class OrdonnanceDataAccess
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        public List<Ordonnance> SelectOrdonnancesFromDB()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT nom_pat, prenom_pat, naissance_pat, sexe_pat, no_secu_pat, nom_med, prenom_med, naissance_med, login_med, libelle_medic, contre_indication_medic, qte_medic, posologie_ord, duree_ord, instruction_ord, date_creation_ord FROM (((ordonnance INNER JOIN medicament ON medicament.id_medic = ordonnance.id_medic) INNER JOIN medecin ON medecin.id_med = ordonnance.id_med) INNER JOIN patient ON patient.id_pat = ordonnance.id_pat) ";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using MySqlDataReader reader = command.ExecuteReader();
                    List<Ordonnance> ordonnances = new();
                    while (reader.Read())
                    {
                        Patient patient = new(reader.GetString("nom_pat"), reader.GetString("prenom_pat"), reader.GetDateTime("naissance_pat"), reader.GetString("sexe_pat"), reader.GetInt64("no_secu_pat"));
                        Medecin medecin = new(reader.GetString("nom_med"), reader.GetString("prenom_med"), reader.GetDateTime("naissance_med"), reader.GetString("login_med"));
                        Medicament medicament = new(reader.GetString("libelle_medic"), reader.GetString("contre_indication_medic"), reader.GetInt32("qte_medic"));
                        Ordonnance ordonnance = new(reader.GetString("posologie_ord"), reader.GetInt32("duree_ord"), reader.GetString("instruction_ord"), reader.GetDateTime("date_creation_ord"), patient, medicament, medecin);
                        ordonnances.Add(ordonnance);
                    }
                    return ordonnances;
                }
            }
        }

        public string GetOrdonnanceIdFromDB(OrdonnanceView ordonnance)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id_ord FROM ordonnance";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    string result = adapter.ToString();
                    conn.Close();
                    return result;
                }
            }
        }
        // Ajoute une nouvelle ordonnance dans la table ordonnance de la BDD
        public string AddOrdonnanceInDB(Ordonnance ordonnance)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                // Requete SQL ajoutant un ligne dans la table ordonnance de la bdd
                string query = "INSERT INTO ordonnance (posologie_ord, date_creation_ord, duree_ord, instruction_ord, id_med, id_pat, id_medic) VALUES (@posologie, @date_creation, @duree, @instruction, @id_med, @id_pat, @id_medic)";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    PatientDataAccess patientDataAccess = new PatientDataAccess();
                    MedecinDataAccess medecinDataAccess = new MedecinDataAccess();
                    MedicamentDataAccess medicamentDataAccess = new MedicamentDataAccess();
                    command.Parameters.AddWithValue("@posologie", ordonnance.Posologie);
                    command.Parameters.AddWithValue("date_creation", ordonnance.Date_creation);
                    command.Parameters.AddWithValue("@duree", ordonnance.Duree);
                    command.Parameters.AddWithValue("@instruction", ordonnance.Instruction);
                    command.Parameters.AddWithValue("@id_med", medecinDataAccess.GetMedecinIdFromDB(ordonnance.Medecin));
                    command.Parameters.AddWithValue("@id_pat", patientDataAccess.GetPatientIdFromDB(ordonnance.Patient));
                    command.Parameters.AddWithValue("@id_medic", medicamentDataAccess.GetMedicamentIdFromDB(ordonnance.Medicament));
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
