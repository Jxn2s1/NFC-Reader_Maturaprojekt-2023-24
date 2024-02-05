using System;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
using MongoDB.Bson;
using MongoDB.Driver;

namespace NFC_Reader
{
    internal class Database
    {
        private string connectionString;

        public Database(string connectionStr)
        {
            connectionString = connectionStr;
        }
        //Saves Data in Database
        public bool InsertNFC(DataGridView dataGridView, string tableName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;

                // Starte eine Transaktion
                transaction = connection.BeginTransaction("DataGridViewToSQLTransaction");

                try
                {
                    command.Connection = connection;
                    command.Transaction = transaction;

                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            // Hier werden die Daten aus der DataGridView in die Datenbank gespeichert
                            command.CommandText = $"INSERT INTO {tableName} (Id, ChipData, TimeStamp) VALUES (@value1, @value2, @value3)";
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@value1", row.Cells["Column1"].Value);
                            command.Parameters.AddWithValue("@value2", row.Cells["Column2"].Value);
                            command.Parameters.AddWithValue("@value3", row.Cells["Column3"].Value);
                            command.ExecuteNonQuery();

                        }
                    }

                    // Commit der Transaktion
                    transaction.Commit();
                    MessageBox.Show("Data inserted into the database successfully.");
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim Speichern der Daten: " + ex.Message);

                    try
                    {
                        // Bei einem Fehler Rollback der Transaktion
                        transaction.Rollback();

                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show("Rollback fehlgeschlagen: " + ex2.Message);
                    }

                    return false;
                }
            }
        }
        //Load Data from Database
        public DataTable LoadNFC(string tableName)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"SELECT * FROM {tableName}";
                SqlCommand command = new SqlCommand(query, connection);

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }
        public bool DeleteAllFromDatabase(string tableName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = $"DELETE FROM {tableName}";
                    SqlCommand command = new SqlCommand(query, connection);

                    int rowsAffected = command.ExecuteNonQuery();


                    return rowsAffected > 0;
                    // Gibt true zurück, wenn Zeilen gelöscht wurden
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Löschen der Daten: " + ex.Message);
                return false;
            }
        }
    }
}