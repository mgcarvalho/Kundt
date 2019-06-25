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
            this.txtTEMP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFILE1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFILE2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFile1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ofdFiles = new System.Windows.Forms.OpenFileDialog();
            this.txtATP = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(725, 199);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 32);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(437, 199);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(136, 32);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(17, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(536, 20);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Select the files that will be used for analizes  corresponding  structure ";
            // 
            // lblStructName
            // 
            this.lblStructName.AutoSize = true;
            this.lblStructName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStructName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblStructName.Location = new System.Drawing.Point(624, 20);
            this.lblStructName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStructName.Name = "lblStructName";
            this.lblStructName.Size = new System.Drawing.Size(0, 20);
            this.lblStructName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name:";
            // 
            // txtCASE
            // 
            this.txtCASE.Location = new System.Drawing.Point(100, 55);
            this.txtCASE.Margin = new System.Windows.Forms.Padding(4);
            this.txtCASE.Name = "txtCASE";
            this.txtCASE.Size = new System.Drawing.Size(760, 22);
            this.txtCASE.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Date:";
            // 
            // dtpDATA
            // 
            this.dtpDATA.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dtpDATA.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDATA.Location = new System.Drawing.Point(100, 92);
            this.dtpDATA.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDATA.Name = "dtpDATA";
            this.dtpDATA.Size = new System.Drawing.Size(204, 22);
            this.dtpDATA.TabIndex = 16;
            // 
            // txtTEMP
            // 
            this.txtTEMP.Location = new System.Drawing.Point(452, 92);
            this.txtTEMP.Margin = new System.Windows.Forms.Padding(4);
            this.txtTEMP.Name = "txtTEMP";
            this.txtTEMP.Size = new System.Drawing.Size(88, 22);
            this.txtTEMP.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(319, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Temperature:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(549, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Pressure Atmospheric:";
            // 
            // txtFILE1
            // 
            this.txtFILE1.Enabled = false;
            this.txtFILE1.Location = new System.Drawing.Point(100, 129);
            this.txtFILE1.Margin = new System.Windows.Forms.Padding(4);
            this.txtFILE1.Name = "txtFILE1";
            this.txtFILE1.Size = new System.Drawing.Size(695, 22);
            this.txtFILE1.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "File (1):";
            // 
            // txtFILE2
            // 
            this.txtFILE2.Enabled = false;
            this.txtFILE2.Location = new System.Drawing.Point(100, 166);
            this.txtFILE2.Margin = new System.Windows.Forms.Padding(4);
            this.txtFILE2.Name = "txtFILE2";
            this.txtFILE2.Size = new System.Drawing.Size(695, 22);
            this.txtFILE2.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "File (2):";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(581, 199);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 32);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFile1
            // 
            this.btnFile1.Location = new System.Drawing.Point(796, 128);
            this.btnFile1.Margin = new System.Windows.Forms.Padding(4);
            this.btnFile1.Name = "btnFile1";
            this.btnFile1.Size = new System.Drawing.Size(65, 27);
            this.btnFile1.TabIndex = 26;
            this.btnFile1.Text = "...";
            this.btnFile1.UseVisualStyleBackColor = true;
            this.btnFile1.Click += new System.EventHandler(this.btnFile1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(796, 165);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 27);
            this.button1.TabIndex = 27;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ofdFiles
            // 
            this.ofdFiles.FileName = "openFileDialog1";
            // 
            // txtATP
            // 
            this.txtATP.Location = new System.Drawing.Point(737, 92);
            this.txtATP.Mask = "900.00 KP\\a";
            this.txtATP.Name = "txtATP";
            this.txtATP.Size = new System.Drawing.Size(123, 22);
            this.txtATP.TabIndex = 28;
            this.txtATP.LostFocus += new System.EventHandler(this.txtATP_LostFocus);
            // 
            // frmLoadFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 271);
            this.ControlBox = false;
            this.Controls.Add(this.txtATP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFile1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtFILE2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFILE1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTEMP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDATA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCASE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStructName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
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
        private System.Windows.Forms.TextBox txtTEMP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFILE1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFILE2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFile1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog ofdFiles;
        private System.Windows.Forms.MaskedTextBox txtATP;
    }
}