
using Microsoft.VisualBasic;
using System.Diagnostics;




namespace NFC_Reader
{
    public partial class Form1 : Form
    {
        private const string ConnectionString = "Server=localhost;Database=nfc-reader_Maturaprojekt;Uid=root;Pwd=\"\";"; // Hier deine Verbindungszeichenfolge einfügen
        private Database database;
        private JsonInput jsonInput;



        int id_grid;
        int id;
        string data;
        string chipData;


        public Form1()
        {
            InitializeComponent();
            database = new Database(ConnectionString);
            jsonInput = new JsonInput();
            InitializeDataGridView();
            LoadJsonData();

        }
        private void InitializeDataGridView()
        {
            grid_Nfc.Columns.Add("Column1", "Id");
            grid_Nfc.Columns.Add("Column2", "Daten");
        }
        private void LoadJsonData()
        {
            string projectRoot = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(projectRoot, "Output.json");

            if (File.Exists(filePath))
            {
                try
                {
                    JsonInput.JsonData jsonData = jsonInput.ReadJsonData(filePath);

                    grid_Nfc.Rows.Clear();

                    if (jsonData != null && jsonData.DataSets != null)
                    {
                        foreach (var dataSet in jsonData.DataSets)
                        {
                            grid_Nfc.Rows.Add(dataSet.Value.numberOfData, dataSet.Value.outputString);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error reading or deserializing JSON data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading JSON file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("JSON file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            id_grid = Convert.ToInt32(Interaction.InputBox("Gib die Id ein!"));
            data = Interaction.InputBox("Gib die Daten eín!");
            grid_Nfc.Rows.Add(id_grid, data);
        }

        private void cmd_delete_all_Click(object sender, EventArgs e)
        {
            grid_Nfc.Rows.Clear();

        }

        private void cmd_delete_Click(object sender, EventArgs e)
        {
            while (grid_Nfc.SelectedRows.Count > 0)
            {
                grid_Nfc.Rows.Remove(grid_Nfc.SelectedRows[0]);
            }
        }

        private void cmd_Website_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "https://maturaprojekt-nfc-reader.github.io/", //Open Website
                    UseShellExecute = true
                };
                Process.Start(startInfo);
            }
        }

        public void openWebsite(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error with opening the Website: " + e.ToString());
            }
        }



        private void creatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creator:\nJonas Sakotnik\nGregor Christiner\nFlorian Neubauer");
        }

        private void cmd_Upload_Database_Click(object sender, EventArgs e)
        {
            Upload x = new Upload(grid_Nfc);
            x.Show();
            Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            /*string connectionString = null;
            MySqlConnection conn;
            connectionString = "Server=localhost;Database=nfc-reader_Maturaprojekt;Uid=root;Pwd=\"\";";
            conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                MessageBox.Show("Connection Open!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open Connection");
            }*/
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}