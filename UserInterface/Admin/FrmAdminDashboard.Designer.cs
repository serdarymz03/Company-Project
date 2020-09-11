namespace UserInterface.Admin
{
    partial class FrmAdminDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblSicil = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DtgJobs = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblPersonCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblJobCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işDetaylarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgJobs)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.LblSicil);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişi Bilgileri   ";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(290, 31);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(24, 18);
            this.LblName.TabIndex = 3;
            this.LblName.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ad Soyad : ";
            // 
            // LblSicil
            // 
            this.LblSicil.AutoSize = true;
            this.LblSicil.Location = new System.Drawing.Point(127, 31);
            this.LblSicil.Name = "LblSicil";
            this.LblSicil.Size = new System.Drawing.Size(24, 18);
            this.LblSicil.TabIndex = 1;
            this.LblSicil.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sicil No : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DtgJobs);
            this.groupBox2.Location = new System.Drawing.Point(12, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(974, 299);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İş Listesi   ";
            // 
            // DtgJobs
            // 
            this.DtgJobs.AllowUserToAddRows = false;
            this.DtgJobs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DtgJobs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgJobs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgJobs.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.DtgJobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtgJobs.Location = new System.Drawing.Point(3, 20);
            this.DtgJobs.MultiSelect = false;
            this.DtgJobs.Name = "DtgJobs";
            this.DtgJobs.ReadOnly = true;
            this.DtgJobs.RowHeadersVisible = false;
            this.DtgJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgJobs.Size = new System.Drawing.Size(968, 276);
            this.DtgJobs.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 21F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(706, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "YILMAZ HOLDING";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LblTotal);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.LblPersonCount);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.LblJobCount);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(15, 456);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(968, 69);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İş Bilgileri   ";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(708, 30);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(24, 18);
            this.LblTotal.TabIndex = 7;
            this.LblTotal.Text = "00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(580, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Şirket Toplam İş : ";
            // 
            // LblPersonCount
            // 
            this.LblPersonCount.AutoSize = true;
            this.LblPersonCount.Location = new System.Drawing.Point(445, 30);
            this.LblPersonCount.Name = "LblPersonCount";
            this.LblPersonCount.Size = new System.Drawing.Size(24, 18);
            this.LblPersonCount.TabIndex = 5;
            this.LblPersonCount.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(317, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Personel Sayısı : ";
            // 
            // LblJobCount
            // 
            this.LblJobCount.AutoSize = true;
            this.LblJobCount.Location = new System.Drawing.Point(164, 30);
            this.LblJobCount.Name = "LblJobCount";
            this.LblJobCount.Size = new System.Drawing.Size(24, 18);
            this.LblJobCount.TabIndex = 3;
            this.LblJobCount.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Toplam İş : ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1032, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personellerToolStripMenuItem,
            this.departmanlarToolStripMenuItem,
            this.işlerToolStripMenuItem,
            this.işDetaylarıToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // personellerToolStripMenuItem
            // 
            this.personellerToolStripMenuItem.Name = "personellerToolStripMenuItem";
            this.personellerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.personellerToolStripMenuItem.Text = "Personeller";
            this.personellerToolStripMenuItem.Click += new System.EventHandler(this.personellerToolStripMenuItem_Click);
            // 
            // departmanlarToolStripMenuItem
            // 
            this.departmanlarToolStripMenuItem.Name = "departmanlarToolStripMenuItem";
            this.departmanlarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.departmanlarToolStripMenuItem.Text = "Departmanlar";
            this.departmanlarToolStripMenuItem.Click += new System.EventHandler(this.departmanlarToolStripMenuItem_Click);
            // 
            // işlerToolStripMenuItem
            // 
            this.işlerToolStripMenuItem.Name = "işlerToolStripMenuItem";
            this.işlerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.işlerToolStripMenuItem.Text = "İşler";
            this.işlerToolStripMenuItem.Click += new System.EventHandler(this.işlerToolStripMenuItem_Click);
            // 
            // işDetaylarıToolStripMenuItem
            // 
            this.işDetaylarıToolStripMenuItem.Name = "işDetaylarıToolStripMenuItem";
            this.işDetaylarıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.işDetaylarıToolStripMenuItem.Text = "İş Detayları";
            this.işDetaylarıToolStripMenuItem.Click += new System.EventHandler(this.işDetaylarıToolStripMenuItem_Click);
            // 
            // FrmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 577);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAdminDashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Yönetim Paneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAdminDashboard_FormClosing);
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgJobs)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblSicil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DtgJobs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblPersonCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblJobCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personellerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmanlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işDetaylarıToolStripMenuItem;
    }
}