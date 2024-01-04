using System;
using System.Data;
<<<<<<< Updated upstream
=======
using System.Data.SqlClient;
>>>>>>> Stashed changes
using System.Xml.Linq;
using MongoDB.Bson;
using MongoDB.Driver;

namespace NFC_Reader
{
    internal class Database
    {
<<<<<<< Updated upstream
        private string connectionString = "mongodb+srv://maturaprojektnfcreader:nfcchipssindcool@nfc-reader.efvbzbx.mongodb.net/";
        private MongoClient client;
        private IMongoDatabase database;
        private IMongoCollection<BsonDocument> collection;

        public Database()
        {
            client = new MongoClient(connectionString);
            database = client.GetDatabase("nfc-reader");
            collection = database.GetCollection<BsonDocument>("nfc-collection");
        }

        public void InsertNFCChip(DataGridView dataGridView)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var id = row.Cells[0].Value.ToString();
                    var chipData = row.Cells[1].Value.ToString();

                    var nfcData = new BsonDocument
                    {
                        { "id", id },
                        { "ChipData", chipData }
                    };

                    collection.InsertOne(nfcData);
                }
            }
        }

        public DataTable GetNFCChips()
=======
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
                            command.CommandText = $"INSERT INTO {tableName} (Column1, Column2, Column3) VALUES (@value1, @value2, @value3)";
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@value1", row.Cells["Column1"].Value);
                            command.Parameters.AddWithValue("@value2", row.Cells["Column2"].Value);
                            //command.Parameters.AddWithValue("@value3", row.Cells["Column3"].Value);

                            command.ExecuteNonQuery();
                        }
                    }

                    // Commit der Transaktion
                    transaction.Commit();
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
>>>>>>> Stashed changes
        {
            // Retrieve all documents from the collection
            var documents = collection.Find(FilterDefinition<BsonDocument>.Empty).ToList();

            // Create a DataTable to store the data
            DataTable dataTable = new DataTable();

<<<<<<< Updated upstream
            // Define columns in the DataTable (adjust column names and types as needed)
            dataTable.Columns.Add("Number", typeof(string));
            dataTable.Columns.Add("ChipData", typeof(string)); // No need for Number field

            // Populate the DataTable with data from MongoDB
            foreach (var document in documents)
            {
                dataTable.Rows.Add(document["_id"], document["ChipData"]);
=======
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"SELECT * FROM {tableName}";
                SqlCommand command = new SqlCommand(query, connection);

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
>>>>>>> Stashed changes
            }
            return dataTable;
        }
<<<<<<< Updated upstream

        public void DeleteAllNFCChip()
        {
            database.DropCollection("nfc-collection");
            database = client.GetDatabase("nfc-reader");
            collection = database.GetCollection<BsonDocument>("nfc-collection");
        }
    }
}
=======
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

                    return rowsAffected > 0; // Gibt true zurück, wenn Zeilen gelöscht wurden
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


>>>>>>> Stashed changes
