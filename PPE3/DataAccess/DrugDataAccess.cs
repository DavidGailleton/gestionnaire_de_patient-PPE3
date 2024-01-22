using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using PPE3.Object;

namespace PPE3.DataAccess
{
    internal class DrugDataAccess
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        private readonly List<Drug> drugs = new();

        public void AddDrug(Drug drug)
        {
            drugs.Add(drug);
        }

        public List<Drug> GetDrugList() { return drugs; }

        public void AddDrugToDB(Drug drug)
        {
            using (MySqlConnection conn = new(connectionString))
            {
                conn.Open();
                DrugDataAccess dataAccess = new();
                DataTable dbData = dataAccess.ImportDrugFromDB();

                bool checkIfAlreadyInDB(DataTable dt, Drug drug)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["name"].ToString() == drug.Name && row["description"].ToString() == drug.Description)
                        {
                            return true;
                        }
                    }
                    return false;

                }

                if (checkIfAlreadyInDB(dbData, drug) == true)
                {
                    string query = "UPDATE drug SET quantity = quantity + 1 WHERE name = @name";
                    using (MySqlCommand command = new(query, conn))
                    {
                        command.Parameters.AddWithValue("@name", drug.Name);
                        int result = command.ExecuteNonQuery();
                    }

                }
                else
                {
                    string query = "INSERT INTO drug (name, description, quantity) VALUES (@name, @description, 1)";
                    using (MySqlCommand command = new(query, conn))
                    {
                        command.Parameters.AddWithValue("@name", drug.Name);
                        command.Parameters.AddWithValue("@description", drug.Description);
                        int result = command.ExecuteNonQuery();
                    }
                }


                conn.Close();
            }
        }

        public void AddDrugFromDBWithQuantity(Drug drug, int quantity)
        {
            using (MySqlConnection conn = new(connectionString))
            {
                conn.Open();
                DrugDataAccess dataAccess = new DrugDataAccess();
                DataTable dbData = dataAccess.ImportDrugFromDB();

                bool checkIfAlreadyInDB(DataTable dt, Drug drug)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["name"].ToString() == drug.Name && row["description"].ToString() == drug.Description)
                        {
                            return true;
                        }
                    }
                    return false;

                }

                if (checkIfAlreadyInDB(dbData, drug) == true)
                {
                    string query = "UPDATE drug SET quantity = quantity + @quantity WHERE name = @name";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@name", drug.Name);
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.ExecuteNonQuery();
                    }

                }
                else
                {
                    string query = "INSERT INTO drug (name, description, quantity) VALUES (@name, @description, @quantity)";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@name", drug.Name);
                        command.Parameters.AddWithValue("@description", drug.Description);
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public DataTable ImportDrugFromDB()
        {
            using (MySqlConnection conn = new(connectionString))
            {
                conn.Open();
                string query = "SELECT name, description, quantity FROM drug";
                using (MySqlCommand command = new(query, conn))
                {
                    MySqlCommand sqlcmd = new(query, conn);
                    DataTable dt = new();
                    var reader = sqlcmd.ExecuteReader();
                    dt.Load(reader);

                    conn.Close();
                    return dt;


                }
            }
        }

        public DataTable ImportAuthorizedDrugFromDB()
        {
            using (MySqlConnection conn = new(connectionString))
            {
                conn.Open();
                string query = "SELECT name, description FROM authorized_drugs";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    DataSet ds = new DataSet();
                    MySqlCommand sqlcmd = new MySqlCommand(query, conn);
                    DataTable dt = new DataTable();
                    var reader = sqlcmd.ExecuteReader();
                    dt.Load(reader);

                    conn.Close();
                    return dt;


                }
            }
        }

        public string DeleteDrugFromDB(Drug drug)
        {
            using (MySqlConnection conn = new(connectionString))
            {
                // delete row on db from name
                conn.Open();
                string query = "DELETE FROM drug WHERE name = @name AND description = @description";
                using (MySqlCommand command = new(query, conn))
                {
                    command.Parameters.AddWithValue("@name", drug.Name);
                    command.Parameters.AddWithValue("@description", drug.Description);
                    command.ExecuteNonQuery();
                    return "Référence totalement supprimé du stock";
                }
            }
        }

        public string DeleteDrugFromDBWithQuantity(Drug drug, int quantity)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                DrugDataAccess dataAccess = new DrugDataAccess();
                DataTable dbData = dataAccess.ImportDrugFromDB();

                int checkQuantityInDB(DataTable dt, Drug drug)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["name"].ToString() == drug.Name && row["description"].ToString() == drug.Description)
                        {
                            int result = Convert.ToInt32(row["quantity"]);
                            return result;
                        }
                    }
                    return -1;

                }

                if (checkQuantityInDB(dbData, drug) > quantity)
                {
                    string query = "UPDATE drug SET quantity = quantity - @quantity WHERE name = @name AND description = @description";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@name", drug.Name);
                        command.Parameters.AddWithValue("@description", drug.Description);
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.ExecuteNonQuery();
                    }
                    return "Quantité choisie supprimé du stock";
                }
                else if (checkQuantityInDB(dbData, drug) == quantity)
                {
                    return DeleteDrugFromDB(drug);
                }
                else
                {
                    return "la quantité choisie n'est pas valide";
                }

            }
        }

        public void EditDrugFromDB(string originalName, string newName, string newDescription, int quantity)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE drug SET name = @newName, description = @newDescription, quantity = @quantity WHERE name = @originalName";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@originalName", originalName);
                    command.Parameters.AddWithValue("@newName", newName);
                    command.Parameters.AddWithValue("@newDescription", newDescription);
                    command.Parameters.AddWithValue("@quantity", quantity);

                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
