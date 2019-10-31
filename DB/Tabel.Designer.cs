namespace DB
{
    partial class Tabel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.fullData_Button = new System.Windows.Forms.Button();
            this.shortData_button = new System.Windows.Forms.Button();
            this.Taker_Button = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.UpdateTabBut = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 412);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(676, 412);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Save_Button.FlatAppearance.BorderSize = 0;
            this.Save_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_Button.Location = new System.Drawing.Point(723, 6);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(81, 27);
            this.Save_Button.TabIndex = 2;
            this.Save_Button.Text = "Сохранить";
            this.Save_Button.UseVisualStyleBackColor = false;
            this.Save_Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // Add_button
            // 
            this.Add_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_button.BackColor = System.Drawing.SystemColors.Control;
            this.Add_button.FlatAppearance.BorderSize = 0;
            this.Add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_button.Location = new System.Drawing.Point(694, 12);
            this.Add_button.Margin = new System.Windows.Forms.Padding(3, 15, 15, 15);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(110, 27);
            this.Add_button.TabIndex = 3;
            this.Add_button.Text = "Добавить";
            this.Add_button.UseVisualStyleBackColor = false;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // fullData_Button
            // 
            this.fullData_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fullData_Button.BackColor = System.Drawing.SystemColors.Control;
            this.fullData_Button.FlatAppearance.BorderSize = 0;
            this.fullData_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullData_Button.Location = new System.Drawing.Point(694, 69);
            this.fullData_Button.Margin = new System.Windows.Forms.Padding(3, 15, 15, 15);
            this.fullData_Button.Name = "fullData_Button";
            this.fullData_Button.Size = new System.Drawing.Size(110, 27);
            this.fullData_Button.TabIndex = 4;
            this.fullData_Button.Text = "Полный datasheet";
            this.fullData_Button.UseVisualStyleBackColor = false;
            this.fullData_Button.Click += new System.EventHandler(this.fullData_Button_Click);
            // 
            // shortData_button
            // 
            this.shortData_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shortData_button.BackColor = System.Drawing.SystemColors.Control;
            this.shortData_button.FlatAppearance.BorderSize = 0;
            this.shortData_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shortData_button.Location = new System.Drawing.Point(694, 126);
            this.shortData_button.Margin = new System.Windows.Forms.Padding(3, 15, 15, 15);
            this.shortData_button.Name = "shortData_button";
            this.shortData_button.Size = new System.Drawing.Size(110, 27);
            this.shortData_button.TabIndex = 5;
            this.shortData_button.Text = "Краткий datasheet";
            this.shortData_button.UseVisualStyleBackColor = false;
            this.shortData_button.Click += new System.EventHandler(this.shortData_button_Click);
            // 
            // Taker_Button
            // 
            this.Taker_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Taker_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Taker_Button.FlatAppearance.BorderSize = 0;
            this.Taker_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Taker_Button.Location = new System.Drawing.Point(694, 183);
            this.Taker_Button.Margin = new System.Windows.Forms.Padding(3, 15, 15, 15);
            this.Taker_Button.Name = "Taker_Button";
            this.Taker_Button.Size = new System.Drawing.Size(110, 26);
            this.Taker_Button.TabIndex = 6;
            this.Taker_Button.Text = "Забрать детали";
            this.Taker_Button.UseVisualStyleBackColor = false;
            this.Taker_Button.Click += new System.EventHandler(this.Taker_Button_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.BackColor = System.Drawing.SystemColors.Control;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Location = new System.Drawing.Point(694, 239);
            this.EditButton.Margin = new System.Windows.Forms.Padding(3, 15, 15, 15);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(110, 26);
            this.EditButton.TabIndex = 7;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.BackColor = System.Drawing.SystemColors.Control;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(694, 295);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 15, 15, 15);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(110, 26);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // UpdateTabBut
            // 
            this.UpdateTabBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateTabBut.BackColor = System.Drawing.SystemColors.Control;
            this.UpdateTabBut.FlatAppearance.BorderSize = 0;
            this.UpdateTabBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateTabBut.Location = new System.Drawing.Point(694, 386);
            this.UpdateTabBut.Margin = new System.Windows.Forms.Padding(3, 15, 15, 15);
            this.UpdateTabBut.Name = "UpdateTabBut";
            this.UpdateTabBut.Size = new System.Drawing.Size(110, 26);
            this.UpdateTabBut.TabIndex = 9;
            this.UpdateTabBut.Text = "Обновить";
            this.UpdateTabBut.UseVisualStyleBackColor = false;
            this.UpdateTabBut.Click += new System.EventHandler(this.UpdateTabBut_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Save_Button);
            this.panel2.Location = new System.Drawing.Point(0, 430);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 43);
            this.panel2.TabIndex = 10;
            // 
            // Tabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(812, 469);
            this.Controls.Add(this.UpdateTabBut);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.Taker_Button);
            this.Controls.Add(this.shortData_button);
            this.Controls.Add(this.fullData_Button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Tabel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "БДМ - Таблица";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tabel_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button fullData_Button;
        private System.Windows.Forms.Button shortData_button;
        private System.Windows.Forms.Button Taker_Button;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button UpdateTabBut;
        private System.Windows.Forms.Panel panel2;
    }
}