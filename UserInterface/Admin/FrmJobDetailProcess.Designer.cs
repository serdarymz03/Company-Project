namespace UserInterface.Admin
{
    partial class FrmJobDetailProcess
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DtgJobs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtJobName = new System.Windows.Forms.TextBox();
            this.RchJobContent = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbPersonnels = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDepartment = new System.Windows.Forms.TextBox();
            this.BtnSendJob = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DtgJobs);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1176, 320);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İş Listesi   ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnSendJob);
            this.groupBox2.Controls.Add(this.TxtDepartment);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.CmbPersonnels);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.RchJobContent);
            this.groupBox2.Controls.Add(this.TxtJobName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(140, 355);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(912, 189);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Görev Bilgileri ve Personel   ";
            // 
            // DtgJobs
            // 
            this.DtgJobs.AllowUserToAddRows = false;
            this.DtgJobs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DtgJobs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgJobs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DtgJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgJobs.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.DtgJobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtgJobs.Location = new System.Drawing.Point(3, 20);
            this.DtgJobs.MultiSelect = false;
            this.DtgJobs.Name = "DtgJobs";
            this.DtgJobs.ReadOnly = true;
            this.DtgJobs.RowHeadersVisible = false;
            this.DtgJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgJobs.Size = new System.Drawing.Size(1170, 297);
            this.DtgJobs.TabIndex = 0;
            this.DtgJobs.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtgJobs_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "İş Adı : ";
            // 
            // TxtJobName
            // 
            this.TxtJobName.Location = new System.Drawing.Point(110, 34);
            this.TxtJobName.Name = "TxtJobName";
            this.TxtJobName.Size = new System.Drawing.Size(318, 24);
            this.TxtJobName.TabIndex = 1;
            this.TxtJobName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtJobName_KeyDown);
            this.TxtJobName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtJobName_KeyPress);
            // 
            // RchJobContent
            // 
            this.RchJobContent.Location = new System.Drawing.Point(110, 73);
            this.RchJobContent.Name = "RchJobContent";
            this.RchJobContent.Size = new System.Drawing.Size(318, 96);
            this.RchJobContent.TabIndex = 2;
            this.RchJobContent.Text = "";
            this.RchJobContent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RchJobContent_KeyDown);
            this.RchJobContent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RchJobContent_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Açıklama : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Personeller : ";
            // 
            // CmbPersonnels
            // 
            this.CmbPersonnels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPersonnels.FormattingEnabled = true;
            this.CmbPersonnels.Location = new System.Drawing.Point(604, 30);
            this.CmbPersonnels.Name = "CmbPersonnels";
            this.CmbPersonnels.Size = new System.Drawing.Size(230, 26);
            this.CmbPersonnels.TabIndex = 6;
            this.CmbPersonnels.SelectedValueChanged += new System.EventHandler(this.CmbPersonnels_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Departman : ";
            // 
            // TxtDepartment
            // 
            this.TxtDepartment.Location = new System.Drawing.Point(623, 80);
            this.TxtDepartment.Name = "TxtDepartment";
            this.TxtDepartment.Size = new System.Drawing.Size(197, 24);
            this.TxtDepartment.TabIndex = 8;
            this.TxtDepartment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDepartment_KeyDown);
            this.TxtDepartment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDepartment_KeyPress);
            // 
            // BtnSendJob
            // 
            this.BtnSendJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSendJob.Location = new System.Drawing.Point(561, 130);
            this.BtnSendJob.Name = "BtnSendJob";
            this.BtnSendJob.Size = new System.Drawing.Size(236, 39);
            this.BtnSendJob.TabIndex = 9;
            this.BtnSendJob.Text = "Görevi Ver";
            this.BtnSendJob.UseVisualStyleBackColor = true;
            this.BtnSendJob.Click += new System.EventHandler(this.BtnSendJob_Click);
            // 
            // FrmJobDetailProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 580);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmJobDetailProcess";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Görevlendirme Paneli";
            this.Load += new System.EventHandler(this.FrmJobDetailProcess_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgJobs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DtgJobs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtDepartment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbPersonnels;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox RchJobContent;
        private System.Windows.Forms.TextBox TxtJobName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSendJob;
    }
}