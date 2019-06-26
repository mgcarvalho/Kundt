namespace Kundt
{
    partial class frmLoadFile
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStructName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCASE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDATA = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFILE1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFILE2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFile1 = new System.Windows.Forms.Button();
            this.btnFile2 = new System.Windows.Forms.Button();
            this.ofdFiles = new System.Windows.Forms.OpenFileDialog();
            this.txtTMP = new System.Windows.Forms.TextBox();
            this.txtATP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(607, 184);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 26);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(319, 184);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(136, 26);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(17, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(592, 17);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Select the files that will be used for analizes corresponding structure: ";
            // 
            // lblStructName
            // 
            this.lblStructName.AutoSize = true;
            this.lblStructName.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStructName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblStructName.Location = new System.Drawing.Point(601, 20);
            this.lblStructName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStructName.Name = "lblStructName";
            this.lblStructName.Size = new System.Drawing.Size(0, 16);
            this.lblStructName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name:";
            // 
            // txtCASE
            // 
            this.txtCASE.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCASE.Location = new System.Drawing.Point(99, 54);
            this.txtCASE.Margin = new System.Windows.Forms.Padding(4);
            this.txtCASE.Name = "txtCASE";
            this.txtCASE.Size = new System.Drawing.Size(644, 22);
            this.txtCASE.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Date:";
            // 
            // dtpDATA
            // 
            this.dtpDATA.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dtpDATA.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDATA.Location = new System.Drawing.Point(99, 86);
            this.dtpDATA.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDATA.Name = "dtpDATA";
            this.dtpDATA.Size = new System.Drawing.Size(138, 22);
            this.dtpDATA.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(261, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Temperature:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(475, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Atmospheric Pressure:";
            // 
            // txtFILE1
            // 
            this.txtFILE1.Enabled = false;
            this.txtFILE1.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFILE1.Location = new System.Drawing.Point(99, 118);
            this.txtFILE1.Margin = new System.Windows.Forms.Padding(4);
            this.txtFILE1.Name = "txtFILE1";
            this.txtFILE1.Size = new System.Drawing.Size(603, 22);
            this.txtFILE1.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "File (1):";
            // 
            // txtFILE2
            // 
            this.txtFILE2.Enabled = false;
            this.txtFILE2.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFILE2.Location = new System.Drawing.Point(99, 150);
            this.txtFILE2.Margin = new System.Windows.Forms.Padding(4);
            this.txtFILE2.Name = "txtFILE2";
            this.txtFILE2.Size = new System.Drawing.Size(603, 22);
            this.txtFILE2.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 152);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "File (2):";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(463, 184);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 26);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFile1
            // 
            this.btnFile1.Location = new System.Drawing.Point(702, 117);
            this.btnFile1.Margin = new System.Windows.Forms.Padding(4);
            this.btnFile1.Name = "btnFile1";
            this.btnFile1.Size = new System.Drawing.Size(42, 23);
            this.btnFile1.TabIndex = 4;
            this.btnFile1.Text = "...";
            this.btnFile1.UseVisualStyleBackColor = true;
            this.btnFile1.Click += new System.EventHandler(this.btnFile1_Click);
            // 
            // btnFile2
            // 
            this.btnFile2.Location = new System.Drawing.Point(702, 149);
            this.btnFile2.Margin = new System.Windows.Forms.Padding(4);
            this.btnFile2.Name = "btnFile2";
            this.btnFile2.Size = new System.Drawing.Size(42, 21);
            this.btnFile2.TabIndex = 5;
            this.btnFile2.Text = "...";
            this.btnFile2.UseVisualStyleBackColor = true;
            this.btnFile2.Click += new System.EventHandler(this.btnFile2_Click);
            // 
            // ofdFiles
            // 
            this.ofdFiles.FileName = "openFileDialog1";
            // 
            // txtTMP
            // 
            this.txtTMP.Location = new System.Drawing.Point(372, 87);
            this.txtTMP.Name = "txtTMP";
            this.txtTMP.ShortcutsEnabled = false;
            this.txtTMP.Size = new System.Drawing.Size(82, 22);
            this.txtTMP.TabIndex = 2;
            this.txtTMP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTMP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTMP_KeyDown);
            this.txtTMP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTMP_KeyPress);
            this.txtTMP.Leave += new System.EventHandler(this.txtTMP_Leave);
            // 
            // txtATP
            // 
            this.txtATP.Location = new System.Drawing.Point(658, 88);
            this.txtATP.Name = "txtATP";
            this.txtATP.ShortcutsEnabled = false;
            this.txtATP.Size = new System.Drawing.Size(85, 22);
            this.txtATP.TabIndex = 3;
            this.txtATP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtATP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtATP_KeyDown);
            this.txtATP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtATP_KeyPress);
            this.txtATP.Leave += new System.EventHandler(this.txtATP_Leave);
            // 
            // frmLoadFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 230);
            this.ControlBox = false;
            this.Controls.Add(this.txtATP);
            this.Controls.Add(this.txtTMP);
            this.Controls.Add(this.btnFile2);
            this.Controls.Add(this.btnFile1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtFILE2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFILE1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDATA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCASE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStructName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLoadFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Files for analizer";
            this.Load += new System.EventHandler(this.frmLoadFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStructName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCASE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDATA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFILE1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFILE2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFile1;
        private System.Windows.Forms.Button btnFile2;
        private System.Windows.Forms.OpenFileDialog ofdFiles;
        private System.Windows.Forms.TextBox txtTMP;
        private System.Windows.Forms.TextBox txtATP;
    }
}