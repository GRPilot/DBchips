using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace DB
{
    public partial class Search : Form
    {
        public bool CloseCheck = true;

        #region Database

        //public const string conString = "Provider=Microsoft.ACE.OLEDB.4.0;Data Source=DB.mdb";
        public const string conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DB.mdb";

        OleDbConnection  myConnect;

       // DataGridView dataGridView1 = new DataGridView();

        #endregion

        public Search()
        {
            InitializeComponent();
            LoadTabel();

            SearchPanel.AutoScroll = true;
            SearchPanel.BorderStyle = BorderStyle.Fixed3D;
            SearchPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            
            ShowAllPanel();
        }

        private void Search_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseCheck) Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloseCheck = false;
            Form1 Home = new Form1();
            Home.Show();
            this.Close();
        }

        private void ButtonInPanel_Clicked(object sender, EventArgs e)
        {
            
            try
            {
                string nameButton = Convert.ToString((sender as Button).Name); ;
                Process.Start(@nameButton);
            }
            catch (Exception ex)
            {
                if (ex.Message == "Невозможно запустить процесс, так как не указано имя файла.")
                    MessageBox.Show("Отсутствует путь к файлу", "Ошибка!", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Невозможно запустить файл", "Ошибка!", MessageBoxButtons.OK);
            }
        }
        private void TakersButton_Clicked(object sender, EventArgs e)
        {
            string NameOfDetal = Convert.ToString((sender as Button).Name);
            TakersInSearch TIS = new TakersInSearch(NameOfDetal);
            TIS.Show();
        }

        // При изменении текста
        private void SearchBox1_TextChanged_1(object sender, EventArgs e)
        {
            myConnect.Open();
            SearchPanel.Controls.Clear();
            
            try
            {
                string query = "SELECT [id] FROM [BaseTabel];";

                OleDbCommand command = new OleDbCommand(query, myConnect);
                OleDbDataReader DataReader = command.ExecuteReader();

                if (searchBox1.Text.Length != 0)
                {
                    
                    string line = "";
                    while (DataReader.Read())
                    {
                        line += dataGridView1[1, DataReader.GetInt32(0) - 1].Value.ToString() + " ";
                    }

                    string pattern = "(" + searchBox1.Text + "(\\w*))|" +
                                     "(" + searchBox1.Text.ToUpper() + "(\\w*))";
                    
                    Regex regex = new Regex(@pattern);
                    MatchCollection matches = regex.Matches(line);

                    

                    foreach (Match match in matches)
                    {
                        for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                            if (match.Value == dataGridView1[1, i].Value.ToString())
                                ShowPanel(i);
                    }
                }
                else
                {
                    while (DataReader.Read())
                    { 
                        ShowPanel(DataReader.GetInt32(0) - 1);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            myConnect.Close();
        }

        public void ShowAllPanel()
        {
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                ShowPanel(i);
        }
        public void ShowPanel (Int32 id)
        {
            string nameOfDetal     = dataGridView1[1, id].Value.ToString(),
                   numberOfDetals  = dataGridView1[2, id].Value.ToString(),
                   textOfDecript   = dataGridView1[3, id].Value.ToString(),
                   shortDatasheet  = dataGridView1[5, id].Value.ToString(),
                   fullDatasheet   = dataGridView1[6, id].Value.ToString(),
                   LocationOfImage = dataGridView1[7, id].Value.ToString();

            const int height = 120;
            // Разобраться с выводом

            TableLayoutPanel panel = new TableLayoutPanel
            {
                ColumnCount = 4,
                RowCount = 1,
                Size = new Size(SearchPanel.Width - 30, height + 10),
                CellBorderStyle = TableLayoutPanelCellBorderStyle.None,
                Padding = new Padding(3)
            };

            // Картинка
            PictureBox picture = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.StretchImage,
                ImageLocation = LocationOfImage,
                Size = new Size(height - 10, height - 10)
            };

            // Кнопки
            Button FullButton1 = new Button
            {
                Name = fullDatasheet,
                Width = 100,
                Height = 35,
                Margin = new Padding(2),
                Text = "Полный datasheet",
                BackColor = System.Drawing.SystemColors.Control
            };
            FullButton1.FlatAppearance.BorderSize = 0;
            FullButton1.UseVisualStyleBackColor = false;

            Button ShortButton2 = new Button
            {
                Name = shortDatasheet,
                Width = 100,
                Height = 35,
                Text = "Краткий datasheet",
                Margin = new Padding(2),
                BackColor = System.Drawing.SystemColors.Control
            };
            ShortButton2.FlatAppearance.BorderSize = 0;
            ShortButton2.UseVisualStyleBackColor = false;

            Button takersButton = new Button
            {
                Name = nameOfDetal,
                Width = 100,
                Height = 25,
                Text = "Взявшие",
                Margin = new Padding(2),
                BackColor = System.Drawing.SystemColors.Control
            };
            takersButton.FlatAppearance.BorderSize = 0;
            takersButton.UseVisualStyleBackColor = false;

            // Наименование
            Label name = new Label
            {
                BackColor = System.Drawing.SystemColors.Control,
                Text = nameOfDetal,
                Font = new Font("Arial", 16, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(100, 40),
                Margin = new Padding(0, 5, 0, 5)
            };

            // Колличество
            Label number = new Label
            {
                BackColor = System.Drawing.SystemColors.Control,
                Text = numberOfDetals,
                Font = new Font("Arial", 16, FontStyle.Regular),
                Size = new Size(name.Width, name.Height),
                TextAlign = ContentAlignment.MiddleCenter,
                Margin = new Padding(0, 5, 0, 5)
            };

            // Описание
            Label descript = new Label
            {
                BackColor = System.Drawing.SystemColors.Control,
                Size = new Size(panel.Width - 40 -
                                picture.Width -
                                name.Width - 
                                FullButton1.Width, height - 10),
                Text = textOfDecript,
                Font = new Font("Candara Light", 18, FontStyle.Regular)
            };

            // События нажатий
            FullButton1.Click += new EventHandler(ButtonInPanel_Clicked);
            ShortButton2.Click += new EventHandler(ButtonInPanel_Clicked);
            takersButton.Click += new EventHandler(TakersButton_Clicked);

            // Группировка кнопок
            TableLayoutPanel buttons = new TableLayoutPanel
            {
                Width = FullButton1.Width + 7,
                Height = panel.Height - 20,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.None
            };

            buttons.Controls.Add(FullButton1);
            buttons.Controls.Add(ShortButton2);
            buttons.Controls.Add(takersButton);

            TableLayoutPanel info = new TableLayoutPanel
            {
                Width = name.Width + 7,
                Height = panel.Height - 20,
                Padding = new Padding(2),
                CellBorderStyle = TableLayoutPanelCellBorderStyle.None
            };

            info.Controls.Add(name);
            info.Controls.Add(number);

            // Строим форму
            panel.Controls.Add(picture, 0, 0);
            panel.Controls.Add(info, 1, 0);
            panel.Controls.Add(descript, 2, 0);
            panel.Controls.Add(buttons);

            // Подгружаем форму в поисковой блок
            SearchPanel.Controls.Add(panel); 
        }
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
                myAdapter.Fill(tabel);
                dataGridView1.DataSource = tabel;

                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns[0].Width = 30;        // id
                dataGridView1.Columns[1].Width = 100;       // Наименование
                dataGridView1.Columns[2].Width = 30;        // ШТ
                dataGridView1.Columns[3].AutoSizeMode =     // Превью
                    DataGridViewAutoSizeColumnMode.Fill;    // ------
                dataGridView1.Columns[4].Width = 100;       // Корпус
                dataGridView1.Columns[5].Visible = false;   // Полный datasheet
                dataGridView1.Columns[6].Visible = false;   // Краткий datasheet
                dataGridView1.Columns[7].Visible = false;   // Pictures

            }
            catch (OleDbException exept)
            {
                MessageBox.Show(exept.Message);
            }
        }

        private void SearchBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96))
            {
                e.Handled = true;
            }
        }
    }
}
