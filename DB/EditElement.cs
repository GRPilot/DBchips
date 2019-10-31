using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace DB
{
    public partial class EditElement : Form
    {
        #region DATABASE

       // public const string conString = "Provider=Microsoft.ACE.OLEDB.4.0;Data Source=DB.mdb";
        public const string conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DB.mdb";

        OleDbConnection myConnect;

        #endregion

        int id;
        string shortDS = "",
               fullDS  = "",
               picture = "";

        public EditElement(int selectRow)
        {
            InitializeComponent();

            string query = "SELECT * FROM [BaseTabel]";

            myConnect = new OleDbConnection(conString);
            myConnect.Open();
            OleDbCommand command = new OleDbCommand(query, myConnect);
            myConnect.Close();

            OleDbDataAdapter myAdapter = new OleDbDataAdapter();
            myAdapter.SelectCommand = command;
            DataSet myDataSet = new DataSet();
            myAdapter.Fill(myDataSet);

            dataGridView1.DataSource = myDataSet.Tables[0];
            myAdapter.Update(myDataSet);

            DataTable table = new DataTable();
            myAdapter.Fill(table);
            dataGridView1.DataSource = table;

            id = Convert.ToInt32(dataGridView1[0, selectRow].Value);

            //TODO: вставить все данные из таблицы по ячейкам
            PicturePanel.ImageLocation = @dataGridView1[columnIndex: 7, rowIndex: selectRow].Value.ToString();
            nameTextbox.Text = dataGridView1[1, selectRow].Value.ToString();
            Decript.Text = dataGridView1[3, selectRow].Value.ToString();
            BoxName.Text = dataGridView1[4, selectRow].Value.ToString();
            numericUpDown1.Value = Convert.ToDecimal(dataGridView1[2, selectRow].Value);
            shortDS = dataGridView1[5, selectRow].Value.ToString();
            fullDS = dataGridView1[6, selectRow].Value.ToString();
            picture = dataGridView1[7, selectRow].Value.ToString();
        }

        #region Buttons

        // Кнопка "Отмена"
        private void CancelButton_Click(object sender, EventArgs e) => this.Close();
        // Кнопка "Краткий датасет"
        private void ShortDatasheet_Click(object sender, EventArgs e) => shortDS = OpenFile(false);
        // Кнопка "Полный датасет"
        private void FullDatasheet_Click(object sender, EventArgs e) => fullDS = OpenFile(false);

        private void PicturePanel_Click(object sender, EventArgs e)
        {
            picture = OpenFile(true);
            PicturePanel.ImageLocation = picture;
        } // Нажатие на картинку
        private void SaveButton_Click(object sender, EventArgs e)
        {
            string query = "UPDATE [BaseTabel] SET ";

            try
            {
                //id, Наименование, ШТ, Превью, Корпус, [Крадкое описание], [Полное описание], Pictures
                query += "Наименование='"       + nameTextbox.Text                + "', ";
                query += "ШТ="                  + numericUpDown1.Value.ToString() + ", ";
                query += "Превью='"             + Decript.Text                    + "', ";
                query += "Корпус='"             + BoxName.Text                    + "', ";
                query += "[Крадкое описание]='" + shortDS                         + "', ";
                query += "[Полное описание]='"  + fullDS                          + "', ";
                query += "Pictures='"           + picture                         + "' ";

                query += "WHERE id=" + Convert.ToString(id);
                // Для отладки
                //MessageBox.Show(query);

                myConnect.Open();
                OleDbCommand command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();
                myConnect.Close();

                MessageBox.Show("Изменено");
                this.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Изменения не удалось", "Ошибка!", MessageBoxButtons.OK);
            }
        }   // Кнопка "Сохранить изменения"
        #endregion



        

        public string OpenFile(bool choise)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (choise)
                file.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            file.ShowDialog();
            return file.FileName;
        }

        private void EditElement_FormClosing(object sender, FormClosingEventArgs e) => myConnect.Close();
    }
}
