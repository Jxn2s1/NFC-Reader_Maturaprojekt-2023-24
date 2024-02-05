using MongoDB.Driver.Core.Configuration;
using System.Data;
using System.Windows.Forms;


namespace NFC_Reader
{
    public partial class Upload : Form
    {
        private const string connectionString = "Server=JONAS-OMEN-BY-H;Database=NFCReader;Trusted_Connection=True;";
        private Database database;
        private DataGridView sourceDataGridView;



        int id_grid;
        int id;
        string data;
        string chipData;
        DateTime timeStamp;

        Form1 form1 = new Form1();
        public Upload(DataGridView sourceDataGridView)
        {
            InitializeComponent();
            database = new Database(connectionString);
            this.sourceDataGridView = sourceDataGridView;
            InitializeDataGridView();
            LoadDataFromDatabase();
            LoadDataFromGrid();


        }
        private void InitializeDataGridView()
        {
            Grid_Nfc_Upload.Columns.Add("Column1", "Id");
            Grid_Nfc_Upload.Columns.Add("Column2", "Daten");
            Grid_Nfc_Upload.Columns.Add("Column3", "TimeStamp");
        }
        private void LoadDataFromDatabase() //Lädt Daten aus der Datenbank und zeigt sie in der DataGridView an
        {
            DataTable dataTable = database.LoadNFC("NFCChips");
            foreach (DataRow row in dataTable.Rows)
            {
                Grid_Nfc_Upload.Rows.Add(row["Id"], row["ChipData"], row["TimeStamp"]);
            }
        }
        private void LoadDataFromGrid()
        {

            foreach (DataGridViewRow row in sourceDataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    id = Convert.ToInt32(row.Cells[0].Value);
                    chipData = row.Cells[1].Value.ToString();
                    timeStamp = DateTime.Now;
                    Grid_Nfc_Upload.Rows.Add(id, chipData, timeStamp);

                }
            }
            foreach (DataGridViewRow row in Grid_Nfc_Upload.Rows) //Legt die Id neu an beim Starten des Upload Formulars
            {
                if (!row.IsNewRow)
                {
                    row.Cells[0].Value = null; // Setzt den Wert der ersten Zelle auf null                       
                }


            }
            for (int i = 0; i < Grid_Nfc_Upload.Rows.Count - 1; i++)
            {
                Grid_Nfc_Upload.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }
        private void HideForm1()
        {
            form1.Hide();
        }

        private void cmd_upload_DB_Click(object sender, EventArgs e)
        {
            database.DeleteAllFromDatabase("NFCChips");
            database.InsertNFC(Grid_Nfc_Upload, "NFCChips");


        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form1.Show();
            Close();
        }


        private void cmd_Delete_Click(object sender, EventArgs e)
        {

            while (Grid_Nfc_Upload.SelectedRows.Count > 0)
            {
                Grid_Nfc_Upload.Rows.Remove(Grid_Nfc_Upload.SelectedRows[0]);
            }
            foreach (DataGridViewRow row in Grid_Nfc_Upload.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.Cells[0].Value = null; // Setzt den Wert der ersten Zelle auf null                       
                }


            }
            for (int i = 0; i < Grid_Nfc_Upload.Rows.Count - 1; i++)//Setzt die Id bei Löschen einer Zeile neu
            {
                Grid_Nfc_Upload.Rows[i].Cells[0].Value = (i + 1).ToString();
            }


        }

        private void cmd_Delete_All_Click(object sender, EventArgs e)
        {
            Grid_Nfc_Upload.Rows.Clear();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            form1.Show();
            Close();
        }
    }
}

