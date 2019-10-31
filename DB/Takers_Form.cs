using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;


namespace DB
{
    public partial class Takers_Form : Form
    {
        #region Database

       // public static string conString = "Provider=Microsoft.ACE.OLEDB.4.0;Data Source=DB.mdb";
        public static string conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DB.mdb";

        OleDbConnection myConnect;
         
        OleDbDataReader reader;
        OleDbDataAdapter adapter;
        DataTable d_table;
        DataSet myDataSet;

        #endregion

        public Takers_Form()
        {
            InitializeComponent();

            LoadTable1();

            myConnect.Open();
            OleDbCommand command = new OleDbCommand("SELECT Наименование FROM [BaseTabel]", myConnect);
            reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["Наименование"].ToString());
            }

            numericUpDown1.Enabled = false;

            myConnect.Close();

            LoadTable2();
        }

        #region Buttoms and Boxes

        // При выборе элемента из выдвижного окна
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int number = getNumber();
            numericUpDown1.Enabled = true;
            numericUpDown1.Maximum = number;
        }

        private void TakeButton_Click(object sender, EventArgs e)
        {
            try
            {
                myConnect.Open();

                string selectName = comboBox1.SelectedItem.ToString();

                int id_t = dataGridView2.RowCount + 1;
                string query = "INSERT INTO [takers](id, name_t, name_d_t, number_t) VALUES("
                             + Convert.ToInt32(id_t) + ", '"
                             + textBox1.Text + "', '"
                             + selectName + "', "
                             + numericUpDown1.Value.ToString() + ")";

                OleDbCommand command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();

                int numOfDetails = 0;

                for (var i = 0; i < dataGridView1.RowCount; i++)
                    if (selectName == dataGridView1["Наименование", i].Value.ToString())
                        numOfDetails = Convert.ToInt32(dataGridView1["ШТ", i].Value);

                query = "UPDATE [BaseTabel] SET ШТ=" + Convert.ToString(numOfDetails - numericUpDown1.Value)
                      + " WHERE Наименование='" + selectName + "'";

                command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();

                myConnect.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите деталь!", "Ошибка!", MessageBoxButtons.OK);
            }
            
            UpdateDataBases();
            numericUpDown1.Maximum = getNumber();
        } // Кнопка "Забрать"
        private void Delete_Click(object sender, EventArgs e)
        {
            myConnect.Open();

            string selectName = dataGridView2["name_d_t", dataGridView2.SelectedCells[0].RowIndex].Value.ToString();
            int numberOfDetails = Convert.ToInt32(dataGridView2["number_t", dataGridView2.SelectedCells[0].RowIndex].Value);
            string id_t = dataGridView2[0, dataGridView2.SelectedCells[0].RowIndex].Value.ToString();
            string query = "DELETE FROM [takers] WHERE id=" + id_t;
            OleDbCommand command = new OleDbCommand(query, myConnect);
            command.ExecuteNonQuery();

            DialogResult dialogResult = MessageBox.Show("Добавить остаток в общее количество данной детали?", "Остаток", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int numOfDetails = 0;

                for (var i = 0; i < dataGridView1.RowCount; i++)
                    if (selectName == dataGridView1["Наименование", i].Value.ToString())
                        numOfDetails = Convert.ToInt32(dataGridView1["ШТ", i].Value);

                query = "UPDATE [BaseTabel] SET ШТ=" + Convert.ToString(numOfDetails + numberOfDetails)
                      + " WHERE Наименование='" + selectName + "'";

                
                command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();
            }

            myConnect.Close();
            ReSortId("name_t","takers");
            UpdateDataBases();
        }     // Кнопка "Убрать"

        #endregion
        public int getNumber()
        {
            string selectName = comboBox1.SelectedItem.ToString();
            int number = 1;

            for (var i = 0; i < dataGridView1.RowCount; i++)
                if (selectName == dataGridView1["Наименование", i].Value.ToString())
                    number = Convert.ToInt32(dataGridView1["ШТ", i].Value);

            return number;
        }
        public void LoadTable1()
        {
            try
            {
                myConnect = new OleDbConnection(conString);
                myConnect.Open();
                OleDbCommand command = new OleDbCommand("SELECT Наименование, ШТ FROM [BaseTabel]", myConnect);

                adapter = new OleDbDataAdapter();
                adapter.SelectCommand = command;

                myDataSet = new DataSet();
                adapter.Fill(myDataSet);

                dataGridView1.DataSource = myDataSet.Tables[0];
                adapter.Update(myDataSet);

                d_table = new DataTable();
                adapter.Fill(d_table);
                dataGridView1.DataSource = d_table;

                myConnect.Close();

                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns[1].Width = 30;        // id
                dataGridView1.Columns[0].AutoSizeMode = 
                    DataGridViewAutoSizeColumnMode.Fill;

            }
            catch (OleDbException exept)
            {
                MessageBox.Show(exept.Message);
            }
        }
        public void LoadTable2()
        {
            try
            {
                myConnect = new OleDbConnection(conString);
                myConnect.Open();
                OleDbCommand command = new OleDbCommand("SELECT * FROM [takers]", myConnect);

                adapter = new OleDbDataAdapter();
                adapter.SelectCommand = command;

                myDataSet = new DataSet();
                adapter.Fill(myDataSet);

                dataGridView2.DataSource = myDataSet.Tables[0];
                adapter.Update(myDataSet);

                d_table = new DataTable();
                adapter.Fill(d_table);
                dataGridView2.DataSource = d_table;

                myConnect.Close();

                dataGridView2.RowHeadersVisible = false;
                dataGridView2.Columns[0].Width = 30;        // id
                dataGridView2.Columns[1].AutoSizeMode =     // ФИО
                    DataGridViewAutoSizeColumnMode.Fill;    // ....
                dataGridView2.Columns[3].Width = 30;        // кол-во

                dataGridView2.Columns[0].HeaderText = "№";    
                dataGridView2.Columns[1].HeaderText = "ФИО";
                dataGridView2.Columns[2].HeaderText = "Деталь";
                dataGridView2.Columns[3].HeaderText = "ШТ";
            }
            catch (OleDbException exept)
            {
                MessageBox.Show(exept.Message);
            }
        }
        public void ReSortId(string nameOfColumn, string nameOfTable)
        {
            string query = "SELECT " + nameOfColumn + " FROM [" + nameOfTable + "]";
            myConnect.Open();

            OleDbCommand command = new OleDbCommand(query, myConnect);
            reader = command.ExecuteReader();

            for (int i = 1; reader.Read(); i++)
            {
                query = "UPDATE [" + nameOfTable + "] SET id=" + Convert.ToString(i) +
                        " WHERE " + nameOfColumn + "='" + reader.GetString(0) + "';";
                command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();
            }

            myConnect.Close();
        }
        public void UpdateDataBases()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();

            LoadTable1();

            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            dataGridView2.Refresh();

            LoadTable2();
        }
    }
}
