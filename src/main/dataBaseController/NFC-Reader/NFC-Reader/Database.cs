using System;
using System.Data;
using System.Xml.Linq;
using MongoDB.Bson;
using MongoDB.Driver;

namespace NFC_Reader
{
    internal class Database
    {
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
        {
            // Retrieve all documents from the collection
            var documents = collection.Find(FilterDefinition<BsonDocument>.Empty).ToList();

            // Create a DataTable to store the data
            DataTable dataTable = new DataTable();

            // Define columns in the DataTable (adjust column names and types as needed)
            dataTable.Columns.Add("Number", typeof(string));
            dataTable.Columns.Add("ChipData", typeof(string)); // No need for Number field

            // Populate the DataTable with data from MongoDB
            foreach (var document in documents)
            {
                dataTable.Rows.Add(document["_id"], document["ChipData"]);
            }
            return dataTable;
        }

        public void DeleteAllNFCChip()
        {
            database.DropCollection("nfc-collection");
            database = client.GetDatabase("nfc-reader");
            collection = database.GetCollection<BsonDocument>("nfc-collection");
        }
    }
}
