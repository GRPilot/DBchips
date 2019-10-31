using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace DB
{
    public partial class SaveOnTable : Form
    {
        string ShortData = "", FullData = "", PictureFloader = "";
        static int NumAdd = 1; // для множественного добавления строк (исп. в SaveButton_Click)


        #region Database

        //public const string conString = "Provider=Microsoft.ACE.OLEDB.4.0;Data Source=DB.mdb";
        public const string conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DB.mdb";
        OleDbConnection  myConnect;
        
        #endregion

        public SaveOnTable() {
            InitializeComponent();
            LoadTabel(); 
            
        } // Точка входа

        public SaveOnTable(DataGridView dataGridView)
        {
            InitializeComponent();
            dataGridView1 = dataGridView;
            myConnect = new OleDbConnection(conString);
            myConnect.Open();
        }

        

        #region Кнопки

        // Кнопка "Отмена"
        private void button3_Click(object sender, EventArgs e) => this.Close();
        private void SaveOnTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnect.Close();
            NumAdd = 1;
        } // Закрытие окна
        // Кнопка "Краткий datasheet" 
        private void ShortDatasheet_Click(object sender, EventArgs e) => ShortData = OpenFile(false);
        // Кнопка "Полный datasheet"
        private void FullDatasheet_Click_1(object sender, EventArgs e) => FullData = OpenFile(false);
        
        private void dPicture_Click(object sender, EventArgs e)
        {
            PictureFloader = OpenFile(true);
            pictureBox1.ImageLocation = PictureFloader;
        }   // Кнопка "Загрузить картинку"
        private void SaveButton_Click(object sender, EventArgs e)
        {
            //TODO: разобраться с id

            int id = dataGridView1.RowCount + NumAdd; //.RowCount didn't work too
            NumAdd++;

            string shortDatasheet = ShortData;
            string FullDatasheet = FullData;

            try
            {
                string query = "INSERT INTO [BaseTabel](id, Наименование, ШТ, Превью, Корпус, [Крадкое описание], [Полное описание], Pictures) " +
                               "VALUES(" + Convert.ToString(id) + ", '"
                                         + textBox1.Text + "' ,"
                                         + Convert.ToString(Num.Value) + " , '"
                                         + Decript.Text + "', '"
                                         + BoxName.Text + "', '"
                                         + shortDatasheet + "', '"
                                         + FullDatasheet + "', '"
                                         + PictureFloader + "')";

                // Для отладки
                // MessageBox.Show(query);

                OleDbCommand command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();

                DialogResult dialogResult = MessageBox.Show("Сохранено. \nСохранить еще?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // чистим формы
                    textBox1.Clear(); Num.Value = 1; Decript.Clear(); BoxName.Clear();
                    shortDatasheet = "";
                    FullDatasheet = "";
                    PictureFloader = "";
                    pictureBox1.ImageLocation = @"D:\Programming\C#\DB\DB\bin\Debug\Pictures\00 - STD_image.png";
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Сохранение не удалось\n\n" + ex.Message, "Ошибка!", MessageBoxButtons.OK);
            }
            
        } // Кнопка "Сохранить"

        #endregion

        public string OpenFile(bool choise)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (choise)
                file.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";

            _ = file.ShowDialog();
            return file.FileName;
        } // Открывает окно выбора файла

        public void LoadTabel()
        {
            try
            {
                myConnect = new OleDbConnection(conString);
                myConnect.Open();
                OleDbCommand command = new OleDbCommand("SELECT * FROM [BaseTabel]", myConnect);
                myConnect.Close();

                OleDbDataAdapter myAdapter = new OleDbDataAdapter();
                myAdapter.SelectCommand = command;
                DataSet myDataSet = new DataSet();
                myAdapter.Fill(myDataSet);

                dataGridView1.DataSource = myDataSet.Tables[0];
                myAdapter.Update(myDataSet);

                DataTable tabel = new DataTable();
                myAdapter.Fill(myDataSet);
                dataGridView1.DataSource = tabel;

                myConnect.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
