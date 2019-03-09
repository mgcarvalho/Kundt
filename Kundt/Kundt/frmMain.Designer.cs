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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carregarAnaliseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivoTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.absorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impedanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reflectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabAbs = new System.Windows.Forms.TabPage();
            this.tabImp = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivosToolStripMenuItem,
            this.exibirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1340, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivosToolStripMenuItem
            // 
            this.arquivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carregarAnaliseToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivosToolStripMenuItem.Name = "arquivosToolStripMenuItem";
            this.arquivosToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.arquivosToolStripMenuItem.Text = "Files";
            // 
            // carregarAnaliseToolStripMenuItem
            // 
            this.carregarAnaliseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoTextoToolStripMenuItem,
            this.excelToolStripMenuItem});
            this.carregarAnaliseToolStripMenuItem.Name = "carregarAnaliseToolStripMenuItem";
            this.carregarAnaliseToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.carregarAnaliseToolStripMenuItem.Text = "Load Analisys";
            // 
            // arquivoTextoToolStripMenuItem
            // 
            this.arquivoTextoToolStripMenuItem.Name = "arquivoTextoToolStripMenuItem";
            this.arquivoTextoToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.arquivoTextoToolStripMenuItem.Text = "Text File";
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.excelToolStripMenuItem.Text = "Excel";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.sairToolStripMenuItem.Text = "Close";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graficosToolStripMenuItem,
            this.statusLineToolStripMenuItem});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.exibirToolStripMenuItem.Text = "Show";
            // 
            // graficosToolStripMenuItem
            // 
            this.graficosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.absorToolStripMenuItem,
            this.impedanceToolStripMenuItem,
            this.reflectionToolStripMenuItem});
            this.graficosToolStripMenuItem.Name = "graficosToolStripMenuItem";
            this.graficosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.graficosToolStripMenuItem.Text = "Graphics";
            // 
            // absorToolStripMenuItem
            // 
            this.absorToolStripMenuItem.Checked = true;
            this.absorToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.absorToolStripMenuItem.Name = "absorToolStripMenuItem";
            this.absorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.absorToolStripMenuItem.Text = "Absorption";
            // 
            // impedanceToolStripMenuItem
            // 
            this.impedanceToolStripMenuItem.Checked = true;
            this.impedanceToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.impedanceToolStripMenuItem.Name = "impedanceToolStripMenuItem";
            this.impedanceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.impedanceToolStripMenuItem.Text = "Impedance";
            // 
            // reflectionToolStripMenuItem
            // 
            this.reflectionToolStripMenuItem.Checked = true;
            this.reflectionToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.reflectionToolStripMenuItem.Name = "reflectionToolStripMenuItem";
            this.reflectionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reflectionToolStripMenuItem.Text = "Reflection";
            // 
            // statusLineToolStripMenuItem
            // 
            this.statusLineToolStripMenuItem.Name = "statusLineToolStripMenuItem";
            this.statusLineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.statusLineToolStripMenuItem.Text = "Status Line";
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabAbs);
            this.tabMain.Controls.Add(this.tabImp);
            this.tabMain.Location = new System.Drawing.Point(0, 27);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(646, 357);
            this.tabMain.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabMain.TabIndex = 1;
            // 
            // tabAbs
            // 
            this.tabAbs.Location = new System.Drawing.Point(4, 22);
            this.tabAbs.Name = "tabAbs";
            this.tabAbs.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbs.Size = new System.Drawing.Size(638, 331);
            this.tabAbs.TabIndex = 0;
            this.tabAbs.Text = "Absorption";
            this.tabAbs.UseVisualStyleBackColor = true;
            // 
            // tabImp
            // 
            this.tabImp.Location = new System.Drawing.Point(4, 22);
            this.tabImp.Name = "tabImp";
            this.tabImp.Padding = new System.Windows.Forms.Padding(3);
            this.tabImp.Size = new System.Drawing.Size(638, 331);
            this.tabImp.TabIndex = 1;
            this.tabImp.Text = "Impedance";
            this.tabImp.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 611);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Kundt Analisys";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carregarAnaliseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arquivoTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem absorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impedanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reflectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusLineToolStripMenuItem;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabAbs;
        private System.Windows.Forms.TabPage tabImp;
    }
}