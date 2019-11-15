using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DB
{
    public partial class Form1 : Form
    {
        public Form1() { InitializeComponent(); }

        #region Кнопки

        private void TableButton_Click(object sender, EventArgs e)
        {
            Tabel Page1 = new Tabel();
            Page1.Show();
            this.Hide();
        }// Кнопка "Таблица"
        private void ShearchButton_Click(object sender, EventArgs e)
        {
            Search Page2 = new Search();
            Page2.Show();
            this.Hide();
        } // Кнопка "Поиск"
        private void ReservButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите зарезервировать текущую таблицу?",
                                                  "Сохранение резервной копии", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    File.Copy("DB.mdb", "DB_R.mdb", true);
                    MessageBox.Show("Таблица успешно зарезервированна!", "Сохранение резервной копии", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        } // Кнопка "Сохранить в"
        private void DownloadButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Восстановление таблицы из резервной копии приведёт к удалению текущей таблицы.\n" + 
                                                  "Вы действительно хотите восстановить таблицу?", 
                                                  "Восстановление таблицы", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    File.Delete("DB.mdb");
                    File.Copy("DB_R.mdb", "DB.mdb", true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        } // Кнопка "Загрузить из"
        #endregion

        // Для закрытия
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();

    
        private void link_MouseMove(object sender, MouseEventArgs e) => linkLabel1.LinkColor = Color.White;
        private void link_MouseLeave(object sender, EventArgs e) => linkLabel1.LinkColor = Color.DimGray;

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/rusan.rusik");
        }
    }
}
