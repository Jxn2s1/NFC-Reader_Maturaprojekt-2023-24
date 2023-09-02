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
        private IMongoCollection<NfcData> collection;

        public Database()
        {
            client = new MongoClient(connectionString);
            database = client.GetDatabase("nfc-reader");
            collection = database.GetCollection<NfcData>("nfc-collection");
        }
        public void InsertNFCChip(DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                var nfcData = new NfcData
                {
                    Number = Convert.ToInt32(row["Number"]),
                    ChipData = row["ChipData"].ToString()
                };

                collection.InsertOne(nfcData);
            }
        }

        public DataTable GetNFCChips()
        {
            // Retrieve all documents from the collection
            var documents = collection.Find(FilterDefinition<NfcData>.Empty).ToList();

            // Create a DataTable to store the data
            DataTable dataTable = new DataTable();

            // Define columns in the DataTable (adjust column names and types as needed)
            dataTable.Columns.Add("Id", typeof(ObjectId));
            dataTable.Columns.Add("Number", typeof(int));
            dataTable.Columns.Add("ChipData", typeof(string));

            // Populate the DataTable with data from MongoDB
            foreach (var document in documents)
            {
                dataTable.Rows.Add(document.Id, document.Number, document.ChipData);
            }
            return dataTable;
        }

        public void DeleteAllNFCChip() 
        {
            database.DropCollection("nfc-collection");
            database = client.GetDatabase("nfc-reader");
            collection = database.GetCollection<NfcData>("nfc-collection");
            Console.WriteLine("The Database is now empty!\n");
        }

    }
}

class NfcData
{
    public ObjectId Id { get; set; } // Include _id property
    public int Number { get; set; }
    public string ChipData { get; set; }
}