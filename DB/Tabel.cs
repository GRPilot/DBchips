using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.OleDb;
using System.Data;


namespace DB
{
    public partial class Tabel : Form
    {
        public bool CloseCheck = true; // Для проверки закрытия формы

        #region Database

        //public static string conString = "Provider=Microsoft.ACE.OLEDB.4.0;Data Source=DB.mdb";
        public static string conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DB.mdb";

        OleDbConnection  myConnect;
        OleDbDataAdapter myAdapter;
        DataSet          myDataSet;          

        #endregion

        public Tabel()
        {
            InitializeComponent();
            LoadTabel();
        }

        #region Кнопки

        // Кнопка "Обновить"
        private void UpdateTabBut_Click(object sender, EventArgs e) { UpdateDataBase(); ReSortId("Наименование","BaseTabel"); }

        private void button1_Click(object sender, EventArgs e)
        {
            CloseCheck = false;
            Form1 Home = new Form1();
            Home.Show();
            this.Close();
        }         // Кнопка "Назад"
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.myAdapter.Update(myDataSet);
                MessageBox.Show("Изменения в базе данных выполнены!",
                  "Уведомление о результатах", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Изменения в базе данных выполнить не удалось!",
                  "Уведомление о результатах", MessageBoxButtons.OK);
            }
        }         // Кнопка "Сохранить"
        private void Add_button_Click(object sender, EventArgs e)
        {
            int numberOfLastLine = Convert.ToInt32(dataGridView1.RowCount);

            SaveOnTable SOT = new SaveOnTable(dataGridView1);
            SOT.ShowDialog();

            UpdateDataBase();
        }      // Кнопка "Добавить"
        private void fullData_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string file = dataGridView1[columnIndex: 6/*столб с полным*/, rowIndex: dataGridView1.CurrentRow.Index].Value.ToString();
                Process.Start(@file);
            }
            catch(Exception ex)
            {
                if (ex.Message == "Невозможно запустить процесс, так как не указано имя файла.")
                    MessageBox.Show("Отсутствует путь к файлу", "Ошибка!", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Невозможно запустить файл", "Ошибка!", MessageBoxButtons.OK);
            }
        } // Кнопка "Полный datasheet"
        private void shortData_button_Click(object sender, EventArgs e)
        {
            try
            { 
                string file = dataGridView1[columnIndex: 5/*столб с полным*/, rowIndex: dataGridView1.CurrentRow.Index].Value.ToString();
                Process.Start(@file);
            }
            catch (Exception ex)
            {
                if (ex.Message == "Невозможно запустить процесс, так как не указано имя файла.")
                    MessageBox.Show("Отсутствует путь к файлу", "Ошибка!", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Невозможно запустить файл", "Ошибка!", MessageBoxButtons.OK);
            }
        }// Кнопка "Краткий datasheet"
        private void Taker_Button_Click(object sender, EventArgs e)
        {
            Takers_Form taker = new Takers_Form();
            taker.ShowDialog();
            UpdateDataBase();
        }    // Кнопка "Забрать детали"
        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                // получаем номер выделенной строки для её дальнейшего изменения изменения
                int selectRow = dataGridView1.CurrentCell.RowIndex;

                EditElement editElement = new EditElement(selectRow);
                editElement.Show();
            }
            catch
            {
                MessageBox.Show("Пожалуйста, выберете элемент из списка, который хотите изменить.", "Ошибка!", MessageBoxButtons.OK);
            }
            UpdateDataBase();
        }      // Кнопка "Изменить"
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Вы действительно хотите удалить этот элемент?", "Удаление", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    myConnect.Open();
                    string query = "DELETE FROM [BaseTabel] WHERE ID = ";
                    query += Convert.ToString(dataGridView1[0, dataGridView1.SelectedCells[0].RowIndex].Value);
                    OleDbCommand command = new OleDbCommand(query, myConnect);
                    command.ExecuteNonQuery();
                    myConnect.Close();
                    query = "";
                }
                else
                {
                    // TODO не удалаляет
                    int FirstIndex = 0;
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        FirstIndex = row.Index;
                    }
                    int LastIndex = dataGridView1.SelectedRows[0].Index;

                    myConnect.Open();
                    for (;FirstIndex <= LastIndex; FirstIndex++)
                    {
                        string query = "DELETE FROM [BaseTabel] WHERE ID = ";
                        query += dataGridView1[0, FirstIndex].Value.ToString();
                        OleDbCommand command = new OleDbCommand(query, myConnect);
                        command.ExecuteNonQuery();
                    }
                    myConnect.Close();
                }
            }
            ReSortId("Наименование", "BaseTabel");
            UpdateDataBase();

        }    // Кнопка "Удалить"

        #endregion

        // Корректное закрытие по кнопке "Назад"
        private void Tabel_FormClosing(object sender, FormClosingEventArgs e) { if (CloseCheck) Application.Exit(); }

        public void ReSortId(string nameOfColumn, string nameOfTable)
        {
            string query = "SELECT " + nameOfColumn + " FROM [" + nameOfTable + "]";
            myConnect.Open();

            OleDbCommand command = new OleDbCommand(query, myConnect);
            OleDbDataReader reader = command.ExecuteReader();

            for (int i = 1; reader.Read(); i++)
            {
                query = "UPDATE [" + nameOfTable + "] SET id=" + Convert.ToString(i) +
                        " WHERE " + nameOfColumn + "='" + reader.GetString(0) + "';";
                command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();
            }

            myConnect.Close();
        }
        public void LoadTabel()
        {
            try
            {
                myConnect = new OleDbConnection(conString);
                myConnect.Open();
                OleDbCommand command = new OleDbCommand("SELECT * FROM [BaseTabel]", myConnect);
                myConnect.Close();

                myAdapter = new OleDbDataAdapter();
                myAdapter.SelectCommand = command;
                myDataSet = new DataSet();
                myAdapter.Fill(myDataSet);

                dataGridView1.DataSource = myDataSet.Tables[0];
                myAdapter.Update(myDataSet);

                DataTable table = new DataTable();
                myAdapter.Fill(table);
                dataGridView1.DataSource = table;

                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns[0].Width = 30;        // id
                dataGridView1.Columns[1].Width = 100;       // Наименование
                dataGridView1.Columns[2].Width = 30;        // ШТ
                dataGridView1.Columns[3].AutoSizeMode =     // Превью
                    DataGridViewAutoSizeColumnMode.Fill;    // ------
                dataGridView1.Columns[4].Width = 70;       // Корпус
                dataGridView1.Columns[5].Visible = false;   // Полный datasheet
                dataGridView1.Columns[6].Visible = false;   // Краткий datasheet
                dataGridView1.Columns[7].Visible = false;   // Pictures

                dataGridView1.Columns[4].DisplayIndex = 3;
            }
            catch (OleDbException exept)
            {
                MessageBox.Show(exept.Message);
            }
        }
        public void UpdateDataBase()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();

            LoadTabel();
        }
    }
}