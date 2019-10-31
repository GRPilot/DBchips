using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DB
{
    public partial class TakersInSearch : Form
    {
        public TakersInSearch()
        {
            InitializeComponent();
            LoadTabel("Empty");
        }

        public TakersInSearch(string NameOfDetal)
        {
            InitializeComponent();
            if(NameOfDetal.Length != 0)
                LoadTabel(NameOfDetal);
        }

        #region buttoms

        private void TakeButtom_Click(object sender, EventArgs e)
        {
            Takers_Form takeForm = new Takers_Form();
            takeForm.Show();
        } // Кнопка "Забрать"

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        } // Кнопка "назад"

        #endregion

        public void LoadTabel(string NameOfDet)
        {
            //const string conString = "Provider=Microsoft.ACE.OLEDB.4.0;Data Source=DB.mdb";
            const string conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DB.mdb";
            
            try
            {
                OleDbConnection myConnect = new OleDbConnection(conString);

                myConnect.Open();
                string query;
                if (NameOfDet == "Empty")
                    query = "SELECT * FROM [takers]";
                else
                    query = "SELECT * FROM [takers] WHERE name_d_t='" + NameOfDet + "';";

                OleDbCommand command = new OleDbCommand(query, myConnect);
                myConnect.Close();

                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = command;
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);

                dataGridView1.DataSource = dataset.Tables[0];
                adapter.Update(dataset);

                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;

                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns[0].Width = 30;       //id
                dataGridView1.Columns[1].AutoSizeMode =    //name_t
                    DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[2].Width = 100;      //name_d_t
                dataGridView1.Columns[3].Width = 30;       //number_t
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
