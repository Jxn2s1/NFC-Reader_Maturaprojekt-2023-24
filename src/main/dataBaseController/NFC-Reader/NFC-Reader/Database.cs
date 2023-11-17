using MySql.Data.MySqlClient;
using System.Data;


namespace NFC_Reader
{
    internal class Database
    {
        private readonly string ConnectionString;

        public Database(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void InsertNFCChip(int id, string chipData)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO NFCChips (Id, ChipData) VALUES (@Id, @ChipData)";
                using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@ChipData", chipData);
                    command.ExecuteNonQuery();
                }
            }
        }
        public DataTable GetNFCChips()
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM NFCChips";
                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }
        public void DeleteAllNFCChip()
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM NFCChips";
                using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}