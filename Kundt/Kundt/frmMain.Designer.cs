namespace Kundt
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabLoad = new System.Windows.Forms.TabPage();
            this.dgvStructures = new System.Windows.Forms.DataGridView();
            this.btnLoadStruct = new System.Windows.Forms.Button();
            this.cmbStruct = new System.Windows.Forms.ComboBox();
            this.lblStruct = new System.Windows.Forms.Label();
            this.tabAnalyze = new System.Windows.Forms.TabPage();
            this.stsInfo = new System.Windows.Forms.StatusStrip();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Field = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbFilesLoad = new System.Windows.Forms.GroupBox();
            this.trvFilesLoad = new System.Windows.Forms.TreeView();
            this.btnClearStruct = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.toolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabMain.SuspendLayout();
            this.tabLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStructures)).BeginInit();
            this.stsInfo.SuspendLayout();
            this.gpbFilesLoad.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabLoad);
            this.tabMain.Controls.Add(this.tabAnalyze);
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Margin = new System.Windows.Forms.Padding(4);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1170, 501);
            this.tabMain.TabIndex = 0;
            // 
            // tabLoad
            // 
            this.tabLoad.Controls.Add(this.btnAnalyze);
            this.tabLoad.Controls.Add(this.btnAddFile);
            this.tabLoad.Controls.Add(this.btnClearStruct);
            this.tabLoad.Controls.Add(this.gpbFilesLoad);
            this.tabLoad.Controls.Add(this.dgvStructures);
            this.tabLoad.Controls.Add(this.btnLoadStruct);
            this.tabLoad.Controls.Add(this.cmbStruct);
            this.tabLoad.Controls.Add(this.lblStruct);
            this.tabLoad.Location = new System.Drawing.Point(4, 26);
            this.tabLoad.Margin = new System.Windows.Forms.Padding(0);
            this.tabLoad.Name = "tabLoad";
            this.tabLoad.Size = new System.Drawing.Size(1162, 471);
            this.tabLoad.TabIndex = 0;
            this.tabLoad.Text = "Load Data";
            this.tabLoad.UseVisualStyleBackColor = true;
            // 
            // dgvStructures
            // 
            this.dgvStructures.AllowUserToAddRows = false;
            this.dgvStructures.AllowUserToDeleteRows = false;
            this.dgvStructures.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvStructures.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStructures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStructures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Field,
            this.Value,
            this.Unit});
            this.dgvStructures.Location = new System.Drawing.Point(24, 80);
            this.dgvStructures.Name = "dgvStructures";
            this.dgvStructures.RowTemplate.Height = 24;
            this.dgvStructures.Size = new System.Drawing.Size(730, 349);
            this.dgvStructures.TabIndex = 3;
            // 
            // btnLoadStruct
            // 
            this.btnLoadStruct.Location = new System.Drawing.Point(528, 32);
            this.btnLoadStruct.Name = "btnLoadStruct";
            this.btnLoadStruct.Size = new System.Drawing.Size(102, 26);
            this.btnLoadStruct.TabIndex = 2;
            this.btnLoadStruct.Text = "Load Struct";
            this.btnLoadStruct.UseVisualStyleBackColor = true;
            this.btnLoadStruct.Click += new System.EventHandler(this.btnLoadStruct_Click);
            // 
            // cmbStruct
            // 
            this.cmbStruct.FormattingEnabled = true;
            this.cmbStruct.Location = new System.Drawing.Point(137, 32);
            this.cmbStruct.Name = "cmbStruct";
            this.cmbStruct.Size = new System.Drawing.Size(365, 25);
            this.cmbStruct.TabIndex = 1;
            // 
            // lblStruct
            // 
            this.lblStruct.AutoSize = true;
            this.lblStruct.Location = new System.Drawing.Point(20, 35);
            this.lblStruct.Name = "lblStruct";
            this.lblStruct.Size = new System.Drawing.Size(111, 17);
            this.lblStruct.TabIndex = 0;
            this.lblStruct.Text = "Select structure:";
            // 
            // tabAnalyze
            // 
            this.tabAnalyze.Location = new System.Drawing.Point(4, 26);
            this.tabAnalyze.Margin = new System.Windows.Forms.Padding(4);
            this.tabAnalyze.Name = "tabAnalyze";
            this.tabAnalyze.Padding = new System.Windows.Forms.Padding(4);
            this.tabAnalyze.Size = new System.Drawing.Size(1162, 471);
            this.tabAnalyze.TabIndex = 1;
            this.tabAnalyze.Text = "Data Analyze";
            this.tabAnalyze.UseVisualStyleBackColor = true;
            // 
            // stsInfo
            // 
            this.stsInfo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelInfo});
            this.stsInfo.Location = new System.Drawing.Point(0, 500);
            this.stsInfo.Name = "stsInfo";
            this.stsInfo.Size = new System.Drawing.Size(1170, 22);
            this.stsInfo.SizingGrip = false;
            this.stsInfo.TabIndex = 1;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Type.DefaultCellStyle = dataGridViewCellStyle2;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.Width = 175;
            // 
            // Field
            // 
            this.Field.DataPropertyName = "Field";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Field.DefaultCellStyle = dataGridViewCellStyle3;
            this.Field.HeaderText = "Field";
            this.Field.Name = "Field";
            this.Field.Width = 220;
            // 
            // Value
            // 
            this.Value.DataPropertyName = "Value";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Value.DefaultCellStyle = dataGridViewCellStyle4;
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.Width = 220;
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "Unit";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Unit.DefaultCellStyle = dataGridViewCellStyle5;
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.Width = 55;
            // 
            // gpbFilesLoad
            // 
            this.gpbFilesLoad.Controls.Add(this.trvFilesLoad);
            this.gpbFilesLoad.Location = new System.Drawing.Point(760, 3);
            this.gpbFilesLoad.Name = "gpbFilesLoad";
            this.gpbFilesLoad.Size = new System.Drawing.Size(399, 458);
            this.gpbFilesLoad.TabIndex = 4;
            this.gpbFilesLoad.TabStop = false;
            this.gpbFilesLoad.Text = "Files";
            // 
            // trvFilesLoad
            // 
            this.trvFilesLoad.Location = new System.Drawing.Point(6, 22);
            this.trvFilesLoad.Name = "trvFilesLoad";
            this.trvFilesLoad.Size = new System.Drawing.Size(387, 430);
            this.trvFilesLoad.TabIndex = 0;
            // 
            // btnClearStruct
            // 
            this.btnClearStruct.Location = new System.Drawing.Point(652, 31);
            this.btnClearStruct.Name = "btnClearStruct";
            this.btnClearStruct.Size = new System.Drawing.Size(102, 26);
            this.btnClearStruct.TabIndex = 5;
            this.btnClearStruct.Text = "Clear Struct";
            this.btnClearStruct.UseVisualStyleBackColor = true;
            this.btnClearStruct.Click += new System.EventHandler(this.btnClearStruct_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Enabled = false;
            this.btnAddFile.Location = new System.Drawing.Point(528, 435);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(102, 26);
            this.btnAddFile.TabIndex = 6;
            this.btnAddFile.Text = "Add Files";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.BackColor = System.Drawing.Color.Transparent;
            this.btnAnalyze.Enabled = false;
            this.btnAnalyze.Location = new System.Drawing.Point(652, 435);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(102, 26);
            this.btnAnalyze.TabIndex = 7;
            this.btnAnalyze.Text = "Analyze Files";
            this.btnAnalyze.UseVisualStyleBackColor = false;
            // 
            // toolStripStatusLabelInfo
            // 
            this.toolStripStatusLabelInfo.Name = "toolStripStatusLabelInfo";
            this.toolStripStatusLabelInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 522);
            this.Controls.Add(this.stsInfo);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kundt Analisys";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabMain.ResumeLayout(false);
            this.tabLoad.ResumeLayout(false);
            this.tabLoad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStructures)).EndInit();
            this.stsInfo.ResumeLayout(false);
            this.stsInfo.PerformLayout();
            this.gpbFilesLoad.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabLoad;
        private System.Windows.Forms.TabPage tabAnalyze;
        private System.Windows.Forms.StatusStrip stsInfo;
        private System.Windows.Forms.ComboBox cmbStruct;
        private System.Windows.Forms.Label lblStruct;
        private System.Windows.Forms.Button btnLoadStruct;
        private System.Windows.Forms.DataGridView dgvStructures;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.Button btnClearStruct;
        private System.Windows.Forms.GroupBox gpbFilesLoad;
        private System.Windows.Forms.TreeView trvFilesLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Field;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInfo;
    }
}