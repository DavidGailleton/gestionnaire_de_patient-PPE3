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
using System.Security;
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
                string query = "SELECT nom_med AS nom, prenom_med AS prenom, naissance_med AS date_de_naissance, login_med AS login FROM medecin WHERE archive_med = 0";
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
        // Ajout d'un medecin
        public string AddMedecinInDB(Medecin medecin, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                // Requete SQL permettant d'importer la valeur contenu dans archive_med selon l'identifiant entré dans le formulaire d'inscription
                string query = "SELECT archive_med FROM medecin WHERE login_med = @login";
                using (MySqlCommand command1 = new MySqlCommand(query, conn))
                {
                    command1.Parameters.AddWithValue("@login", medecin.Login);

                    short result1;
                    // Dans le cas ou la requete ne retourne aucune valeur (c'est a dire que l'utilisateur n'existe pas) inscrire -1 dans la variable result1
                    if (command1.ExecuteScalar() == DBNull.Value)
                    {
                        result1 = -1;
                    }
                    // Si l'utilisateur existe, inscrire la valeur retourner par la requete dans la variable result1
                    else
                    {
                        result1 = Convert.ToInt16(command1.ExecuteScalar());
                    }

                    switch (result1)
                    {
                        // Si l'utilisateur existe mais est archivé, La requete désarchivera l'utilisateur, modifiera son mot de passe et obligera l'utilisateur a se connecter lors de sa prochaine connexion
                        case 1:
                            string query3 =
                                "UPDATE medecin SET archive_med = 0, password_med = @password, first_connection_med = 1 WHERE login_med = @login";
                            using (MySqlCommand command3 = new MySqlCommand(query3, conn))
                            {
                                command3.Parameters.AddWithValue("@login", medecin.Login);
                                command3.Parameters.AddWithValue("@password", BCrypt.Net.BCrypt.EnhancedHashPassword(password, 13));
                                int result3 = command3.ExecuteNonQuery();
                                conn.Close();
                                if (result3 < 0)
                                {
                                    return "Error";
                                }
                                return "Success";
                            }
                        // Si l'utilisateur existe mais qu'il n'est pas archivé, l'administrateur sera prévenu que l'utilisateur existe déja et ne modifiera rien à la table medecin
                        case 0:
                            MessageBox.Show("Utilisateur déja existant");
                            return "Error";
                        // si L'utilisateur n'existe pas dans la table medecin, La requete ajoutera l'utilisateur à la table medecin
                        case -1:
                            string query2 = "INSERT INTO medecin (nom_med, prenom_med, naissance_med, login_med, password_med) VALUES (@nom, @prenom, @naissance, @login, @password)";
                            using (MySqlCommand command2 = new MySqlCommand(query2, conn))
                            {
                                command2.Parameters.AddWithValue("@nom", medecin.Nom);
                                command2.Parameters.AddWithValue("@prenom", medecin.Prenom);
                                command2.Parameters.AddWithValue("@naissance", medecin.Naissance);
                                command2.Parameters.AddWithValue("@login", medecin.Login);
                                command2.Parameters.AddWithValue("@password", BCrypt.Net.BCrypt.EnhancedHashPassword(password, 13));
                                int result2 = command2.ExecuteNonQuery();
                                conn.Close();
                                if (result2 < 0)
                                {
                                    return "Error";
                                }
                                return "Success";
                            }
                        default:
                            return "Error";
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
        public string ArchiveMedecinInDB(Medecin medecin)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                // Requete modifiant la valeur archive_med de la table medecin pour archiver l'utilisateur
                string query = "UPDATE medecin SET archive_med = 1 WHERE login_med = @login";
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
        // met à jour le mot de passe
        public string UpdateMedecinPasswordInDB(string login, string password)
        {
            using (MySqlConnection conn = new(connectionString))
            {
                conn.Open();
                // Requete mettant à jour le mot de passe du medecin et change l'etat de la colonne first_connection_med afin de confirmer que l'utilisateur à bien modifier son mot de passe 
                string query = "UPDATE medecin SET password_med = @password, first_connection_med = 0 WHERE login_med = @login";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@password", BCrypt.Net.BCrypt.EnhancedHashPassword(password, 13));
                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    // Verifie si le mot de passe a bien été mis à jour
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
        // vérifie si c'est la première connexion de l'utilisateur
        public string VerifyFirstConnection(string login)
        {
            using (MySqlConnection conn = new(connectionString))
            {
                conn.Open();
                // selectionne la valeur booleen contenu dans la column first_connection_med de la table medecin selon l'idientifiant fournie
                string query = "SELECT first_connection_med FROM medecin WHERE login_med = @login AND archive_med = 0";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@login", login);
                    int result = Convert.ToInt32(command.ExecuteScalar());
                    conn.Close();
                    // Si le résultat est 0, la fonction confirme que ce n'est pas la première connexion de l'utilisateur
                    if (result == 0)
                    {
                        return "Error";
                    }
                    // Sinon, la fonction coonfirme que c'est sa première connexion
                    else
                    {
                        return "Success";
                    }
                }
            }
        }
        // Verifie si le mot de passe est correcte
        public string VerifyPassword(string login, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                // Selectionne le mot de passe Hashé contenue dans la Table medecin
                string query1 = "SELECT password_med FROM medecin WHERE login_med = @login";

                using (MySqlCommand command1 = new MySqlCommand(query1, conn))
                {
                    command1.Parameters.AddWithValue("@login", login);
                    // Execute la requete
                    string result = Convert.ToString(command1.ExecuteScalar());
                    // Vérifie si le mot de passe n'est pas null, puis s'il est correcte
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
        // Vérifie la validité des identifiant fournie sur la page de connexion
        public Medecin ConnectMedecinFromDB(string login, string pass)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                // Requete visant à vérifier si l'utilisateur existe et récupère son mot de passe Hashé
                string query1 = "SELECT password_med FROM medecin WHERE login_med = @login";
                // Requete visant à importer les information nécessaire à la création d'un objet Medecin
                string query2 = "SELECT nom_med, prenom_med, naissance_med, login_med FROM medecin WHERE login_med = @login";

                using (MySqlCommand command1 = new MySqlCommand(query1, conn))
                {
                    command1.Parameters.AddWithValue("@login", login);
                    string result = Convert.ToString(command1.ExecuteScalar());
                    // Vérifie si le retour n'est pas null ou vide puis vérifie la validité du mot de passe en utilisant Bcrypt afin
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
                            // Créer un tableau d'objet Medecin qui contiendra forcement qu'un seul élément car la données login_med est forcement Unique
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
                                // Retourne le premiere élément du tableau d'objet medecins
                                return medecins[0];
                            }
                            // Retourne un objet medecin contenant des valeurs vide pour signalé que l'utilisateur n'existe pas ou que le mot de passe n'est pas valide
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