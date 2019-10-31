namespace DB
{
    partial class SaveOnTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dPicture = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.FullDatasheet = new System.Windows.Forms.Button();
            this.ShortDatasheet = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Num = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.BoxName = new System.Windows.Forms.TextBox();
            this.Decript = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Выберите = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dPicture);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.FullDatasheet);
            this.panel1.Controls.Add(this.ShortDatasheet);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.Num);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.BoxName);
            this.panel1.Controls.Add(this.Decript);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 232);
            this.panel1.TabIndex = 0;
            // 
            // dPicture
            // 
            this.dPicture.Location = new System.Drawing.Point(4, 150);
            this.dPicture.Name = "dPicture";
            this.dPicture.Size = new System.Drawing.Size(140, 40);
            this.dPicture.TabIndex = 22;
            this.dPicture.Text = "Загрузить картинку";
            this.dPicture.UseVisualStyleBackColor = true;
            this.dPicture.Click += new System.EventHandler(this.dPicture_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DB.Properties.Resources.detal;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 25);
            this.textBox1.MaxLength = 255;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 20;
            // 
            // FullDatasheet
            // 
            this.FullDatasheet.Location = new System.Drawing.Point(237, 150);
            this.FullDatasheet.Name = "FullDatasheet";
            this.FullDatasheet.Size = new System.Drawing.Size(78, 40);
            this.FullDatasheet.TabIndex = 19;
            this.FullDatasheet.Text = "Полный datasheet";
            this.FullDatasheet.UseVisualStyleBackColor = true;
            this.FullDatasheet.Click += new System.EventHandler(this.FullDatasheet_Click_1);
            // 
            // ShortDatasheet
            // 
            this.ShortDatasheet.Location = new System.Drawing.Point(153, 150);
            this.ShortDatasheet.Name = "ShortDatasheet";
            this.ShortDatasheet.Size = new System.Drawing.Size(78, 40);
            this.ShortDatasheet.TabIndex = 18;
            this.ShortDatasheet.Text = "Короткий datasheet";
            this.ShortDatasheet.UseVisualStyleBackColor = true;
            this.ShortDatasheet.Click += new System.EventHandler(this.ShortDatasheet_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(240, 205);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Num
            // 
            this.Num.Location = new System.Drawing.Point(237, 118);
            this.Num.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.Num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(78, 20);
            this.Num.TabIndex = 10;
            this.Num.ThousandsSeparator = true;
            this.Num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(3, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Отмена";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BoxName
            // 
            this.BoxName.Location = new System.Drawing.Point(153, 117);
            this.BoxName.MaxLength = 15;
            this.BoxName.Name = "BoxName";
            this.BoxName.Size = new System.Drawing.Size(78, 20);
            this.BoxName.TabIndex = 8;
            // 
            // Decript
            // 
            this.Decript.Location = new System.Drawing.Point(153, 72);
            this.Decript.MaxLength = 255;
            this.Decript.Name = "Decript";
            this.Decript.Size = new System.Drawing.Size(162, 20);
            this.Decript.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(150, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Корпус";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(150, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Краткое описание";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(234, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Шт";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(150, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Выберите,
            this.idDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(84, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(10, 10);
            this.dataGridView1.TabIndex = 16;
            // 
            // Выберите
            // 
            this.Выберите.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Выберите.DataPropertyName = "Наименование";
            this.Выберите.HeaderText = "Наименование";
            this.Выберите.Name = "Выберите";
            this.Выберите.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SaveOnTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 257);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SaveOnTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaveOnTable_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BoxName;
        private System.Windows.Forms.TextBox Decript;
        private System.Windows.Forms.NumericUpDown Num;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button SaveButton;
        
        private System.Windows.Forms.DataGridView dataGridView1;
        
        private System.Windows.Forms.BindingSource tableBindingSource;
       
        private System.Windows.Forms.Button FullDatasheet;
        private System.Windows.Forms.Button ShortDatasheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Выберите;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn шТDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn превьюDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn крадкоеОписаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn полноеОписаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn корпусDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button dPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}