using System.Data;
using System.Windows.Forms;


namespace NFC_Reader
{
    public partial class Upload : Form
    {
        private Database database;
        private DataGridView sourceDataGridView;

        int id_grid;
        int id;
        string data;
        string chipData;

        Form1 form1 = new Form1();
        public Upload(DataGridView sourceDataGridView)
        {
            InitializeComponent();
            database = new Database();
            this.sourceDataGridView = sourceDataGridView;
            InitializeDataGridView();
            LoadDataFromDatabase();
            LoadDataFromGrid();


        }
        private void InitializeDataGridView()
        {
            Grid_Nfc_Upload.Columns.Add("Column1", "Id");
            Grid_Nfc_Upload.Columns.Add("Column2", "Daten");
            Grid_Nfc_Upload.Columns.Add("Column3", "Neu");
        }
        private void LoadDataFromDatabase() //Lädt Daten aus der Datenbank und zeigt sie in der DataGridView an
        {
            DataTable dataTable = database.GetNFCChips();
            foreach (DataRow row in dataTable.Rows)
            {
                Grid_Nfc_Upload.Rows.Add(row["Number"], row["ChipData"]);
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
                    Grid_Nfc_Upload.Rows.Add(id, chipData, "Neu");

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
            database.DeleteAllNFCChip();
            database.InsertNFCChip(Grid_Nfc_Upload);

            MessageBox.Show("Data inserted into the database successfully.");
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

