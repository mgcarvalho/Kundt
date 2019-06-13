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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabLoad = new System.Windows.Forms.TabPage();
            this.btnLoadStruct = new System.Windows.Forms.Button();
            this.cmbStruct = new System.Windows.Forms.ComboBox();
            this.lblStruct = new System.Windows.Forms.Label();
            this.tabAnalyze = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabMain.SuspendLayout();
            this.tabLoad.SuspendLayout();
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
            this.tabLoad.Controls.Add(this.btnLoadStruct);
            this.tabLoad.Controls.Add(this.cmbStruct);
            this.tabLoad.Controls.Add(this.lblStruct);
            this.tabLoad.Location = new System.Drawing.Point(4, 29);
            this.tabLoad.Margin = new System.Windows.Forms.Padding(0);
            this.tabLoad.Name = "tabLoad";
            this.tabLoad.Size = new System.Drawing.Size(1162, 468);
            this.tabLoad.TabIndex = 0;
            this.tabLoad.Text = "Load Data";
            this.tabLoad.UseVisualStyleBackColor = true;
            // 
            // btnLoadStruct
            // 
            this.btnLoadStruct.Location = new System.Drawing.Point(425, 33);
            this.btnLoadStruct.Name = "btnLoadStruct";
            this.btnLoadStruct.Size = new System.Drawing.Size(102, 25);
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
            this.cmbStruct.Size = new System.Drawing.Size(270, 28);
            this.cmbStruct.TabIndex = 1;
            // 
            // lblStruct
            // 
            this.lblStruct.AutoSize = true;
            this.lblStruct.Location = new System.Drawing.Point(20, 35);
            this.lblStruct.Name = "lblStruct";
            this.lblStruct.Size = new System.Drawing.Size(133, 20);
            this.lblStruct.TabIndex = 0;
            this.lblStruct.Text = "Select structure:";
            // 
            // tabAnalyze
            // 
            this.tabAnalyze.Location = new System.Drawing.Point(4, 29);
            this.tabAnalyze.Margin = new System.Windows.Forms.Padding(4);
            this.tabAnalyze.Name = "tabAnalyze";
            this.tabAnalyze.Padding = new System.Windows.Forms.Padding(4);
            this.tabAnalyze.Size = new System.Drawing.Size(1162, 468);
            this.tabAnalyze.TabIndex = 1;
            this.tabAnalyze.Text = "Data Analyze";
            this.tabAnalyze.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 500);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1170, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 522);
            this.Controls.Add(this.statusStrip1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabLoad;
        private System.Windows.Forms.TabPage tabAnalyze;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ComboBox cmbStruct;
        private System.Windows.Forms.Label lblStruct;
        private System.Windows.Forms.Button btnLoadStruct;
    }
}