namespace DB
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.ReservButton = new System.Windows.Forms.Button();
            this.TableButton = new System.Windows.Forms.Button();
            this.ShearchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.DownloadButton);
            this.panel1.Controls.Add(this.ReservButton);
            this.panel1.Controls.Add(this.TableButton);
            this.panel1.Controls.Add(this.ShearchButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 385);
            this.panel1.TabIndex = 0;
            // 
            // DownloadButton
            // 
            this.DownloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.DownloadButton.FlatAppearance.BorderSize = 0;
            this.DownloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownloadButton.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold);
            this.DownloadButton.Location = new System.Drawing.Point(13, 272);
            this.DownloadButton.Margin = new System.Windows.Forms.Padding(15);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(382, 55);
            this.DownloadButton.TabIndex = 5;
            this.DownloadButton.Text = "загрузить из резервной копии";
            this.DownloadButton.UseVisualStyleBackColor = false;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // ReservButton
            // 
            this.ReservButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ReservButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ReservButton.FlatAppearance.BorderSize = 0;
            this.ReservButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReservButton.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold);
            this.ReservButton.Location = new System.Drawing.Point(13, 187);
            this.ReservButton.Margin = new System.Windows.Forms.Padding(15);
            this.ReservButton.Name = "ReservButton";
            this.ReservButton.Size = new System.Drawing.Size(382, 55);
            this.ReservButton.TabIndex = 4;
            this.ReservButton.Text = "сохранить резервную копию";
            this.ReservButton.UseVisualStyleBackColor = false;
            this.ReservButton.Click += new System.EventHandler(this.ReservButton_Click);
            // 
            // TableButton
            // 
            this.TableButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TableButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.TableButton.FlatAppearance.BorderSize = 0;
            this.TableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TableButton.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold);
            this.TableButton.Location = new System.Drawing.Point(226, 102);
            this.TableButton.Margin = new System.Windows.Forms.Padding(15);
            this.TableButton.Name = "TableButton";
            this.TableButton.Size = new System.Drawing.Size(169, 55);
            this.TableButton.TabIndex = 3;
            this.TableButton.Text = "ТАБЛИЦА";
            this.TableButton.UseVisualStyleBackColor = false;
            this.TableButton.Click += new System.EventHandler(this.TableButton_Click);
            // 
            // ShearchButton
            // 
            this.ShearchButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ShearchButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ShearchButton.FlatAppearance.BorderSize = 0;
            this.ShearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShearchButton.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold);
            this.ShearchButton.Location = new System.Drawing.Point(13, 102);
            this.ShearchButton.Margin = new System.Windows.Forms.Padding(15);
            this.ShearchButton.Name = "ShearchButton";
            this.ShearchButton.Size = new System.Drawing.Size(169, 55);
            this.ShearchButton.TabIndex = 2;
            this.ShearchButton.Text = "ПОИСК";
            this.ShearchButton.UseVisualStyleBackColor = false;
            this.ShearchButton.Click += new System.EventHandler(this.ShearchButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "БАЗА ДАННЫХ МИКРОСХЕМ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabel1.Location = new System.Drawing.Point(276, 388);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(157, 19);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Created by Ruslan G.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            this.linkLabel1.MouseLeave += new System.EventHandler(this.link_MouseLeave);
            this.linkLabel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.link_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(450, 450);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "БДМ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button TableButton;
        private System.Windows.Forms.Button ShearchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReservButton;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

