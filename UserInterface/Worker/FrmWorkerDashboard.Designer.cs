namespace UserInterface.Worker
{
    partial class FrmWorkerDashboard
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
            this.PctBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblAuth = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblDepartment = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblSicil = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblTarih = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DtgJobs = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RchJobContent = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtJobName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnReport = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnFinishJob = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CmbJobs = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PctBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgJobs)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // PctBox
            // 
            this.PctBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PctBox.Location = new System.Drawing.Point(30, 23);
            this.PctBox.Name = "PctBox";
            this.PctBox.Size = new System.Drawing.Size(159, 136);
            this.PctBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBox.TabIndex = 0;
            this.PctBox.TabStop = false;
            this.PctBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PctBox_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblAuth);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.LblDepartment);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.LblName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LblSicil);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(220, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 156);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişi Bilgileri   ";
            // 
            // LblAuth
            // 
            this.LblAuth.AutoSize = true;
            this.LblAuth.Location = new System.Drawing.Point(121, 117);
            this.LblAuth.Name = "LblAuth";
            this.LblAuth.Size = new System.Drawing.Size(24, 18);
            this.LblAuth.TabIndex = 7;
            this.LblAuth.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Yetki : ";
            // 
            // LblDepartment
            // 
            this.LblDepartment.AutoSize = true;
            this.LblDepartment.Location = new System.Drawing.Point(121, 88);
            this.LblDepartment.Name = "LblDepartment";
            this.LblDepartment.Size = new System.Drawing.Size(24, 18);
            this.LblDepartment.TabIndex = 5;
            this.LblDepartment.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ad Soyad : ";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(121, 59);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(24, 18);
            this.LblName.TabIndex = 3;
            this.LblName.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Departman : ";
            // 
            // LblSicil
            // 
            this.LblSicil.AutoSize = true;
            this.LblSicil.Location = new System.Drawing.Point(121, 30);
            this.LblSicil.Name = "LblSicil";
            this.LblSicil.Size = new System.Drawing.Size(24, 18);
            this.LblSicil.TabIndex = 1;
            this.LblSicil.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sicil No : ";
            // 
            // LblTarih
            // 
            this.LblTarih.AutoSize = true;
            this.LblTarih.Location = new System.Drawing.Point(516, 23);
            this.LblTarih.Name = "LblTarih";
            this.LblTarih.Size = new System.Drawing.Size(41, 18);
            this.LblTarih.TabIndex = 2;
            this.LblTarih.Text = "Tarih";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DtgJobs);
            this.groupBox2.Location = new System.Drawing.Point(12, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 256);
            this.groupBox2.TabIndex = 3;
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
            this.DtgJobs.Size = new System.Drawing.Size(754, 233);
            this.DtgJobs.TabIndex = 0;
            this.DtgJobs.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtgJobs_CellMouseClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RchJobContent);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.TxtJobName);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(30, 455);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(448, 181);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İş Bilgileri   ";
            // 
            // RchJobContent
            // 
            this.RchJobContent.Location = new System.Drawing.Point(104, 70);
            this.RchJobContent.Name = "RchJobContent";
            this.RchJobContent.Size = new System.Drawing.Size(338, 96);
            this.RchJobContent.TabIndex = 3;
            this.RchJobContent.Text = "";
            this.RchJobContent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RchJobContent_KeyDown);
            this.RchJobContent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RchJobContent_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Açıklama : ";
            // 
            // TxtJobName
            // 
            this.TxtJobName.Location = new System.Drawing.Point(104, 33);
            this.TxtJobName.Name = "TxtJobName";
            this.TxtJobName.Size = new System.Drawing.Size(338, 24);
            this.TxtJobName.TabIndex = 1;
            this.TxtJobName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtJobName_KeyDown);
            this.TxtJobName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtJobName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "İş Adı : ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnReport);
            this.groupBox4.Controls.Add(this.BtnRefresh);
            this.groupBox4.Controls.Add(this.BtnFinishJob);
            this.groupBox4.Location = new System.Drawing.Point(509, 455);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(243, 181);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aksiyonlar   ";
            // 
            // BtnReport
            // 
            this.BtnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnReport.Location = new System.Drawing.Point(38, 129);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(159, 38);
            this.BtnReport.TabIndex = 2;
            this.BtnReport.Text = "Çıktı Al";
            this.BtnReport.UseVisualStyleBackColor = true;
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRefresh.Location = new System.Drawing.Point(38, 80);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(159, 38);
            this.BtnRefresh.TabIndex = 1;
            this.BtnRefresh.Text = "Listeyi Yenile";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnFinishJob
            // 
            this.BtnFinishJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnFinishJob.Location = new System.Drawing.Point(50, 31);
            this.BtnFinishJob.Name = "BtnFinishJob";
            this.BtnFinishJob.Size = new System.Drawing.Size(130, 38);
            this.BtnFinishJob.TabIndex = 0;
            this.BtnFinishJob.Text = "İşi Bitir";
            this.BtnFinishJob.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CmbJobs
            // 
            this.CmbJobs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbJobs.FormattingEnabled = true;
            this.CmbJobs.Location = new System.Drawing.Point(537, 121);
            this.CmbJobs.Name = "CmbJobs";
            this.CmbJobs.Size = new System.Drawing.Size(215, 26);
            this.CmbJobs.TabIndex = 6;
            this.CmbJobs.SelectedValueChanged += new System.EventHandler(this.CmbJobs_SelectedValueChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(599, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "İş Menüsü";
            // 
            // FrmWorkerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 648);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CmbJobs);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LblTarih);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PctBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmWorkerDashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Ekran";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmWorkerDashboard_FormClosing);
            this.Load += new System.EventHandler(this.FrmWorkerDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgJobs)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PctBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblAuth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblDepartment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblSicil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTarih;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DtgJobs;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox RchJobContent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtJobName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnReport;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnFinishJob;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox CmbJobs;
        private System.Windows.Forms.Label label6;
    }
}