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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabLoad = new System.Windows.Forms.TabPage();
            this.chkUseOne = new System.Windows.Forms.CheckBox();
            this.btnRemoveAllNodes = new System.Windows.Forms.Button();
            this.btnRemoveNode = new System.Windows.Forms.Button();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.gpbFilesLoad = new System.Windows.Forms.GroupBox();
            this.trvFilesLoad = new System.Windows.Forms.TreeView();
            this.dgvStructures = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Field = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoadStruct = new System.Windows.Forms.Button();
            this.cmbStruct = new System.Windows.Forms.ComboBox();
            this.lblStruct = new System.Windows.Forms.Label();
            this.tabAnalyze = new System.Windows.Forms.TabPage();
            this.lblHi = new System.Windows.Forms.Label();
            this.lblLow = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.lblL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbGraphTypeR = new System.Windows.Forms.RadioButton();
            this.rbGraphTypeAlpha = new System.Windows.Forms.RadioButton();
            this.tbHi = new System.Windows.Forms.TrackBar();
            this.tbLow = new System.Windows.Forms.TrackBar();
            this.chtAnalyze = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabMath = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.cmbFormulas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpParameters = new System.Windows.Forms.GroupBox();
            this.lblPar6 = new System.Windows.Forms.Label();
            this.txtPar6 = new System.Windows.Forms.TextBox();
            this.lblPar5 = new System.Windows.Forms.Label();
            this.txtPar5 = new System.Windows.Forms.TextBox();
            this.lblPar4 = new System.Windows.Forms.Label();
            this.txtPar4 = new System.Windows.Forms.TextBox();
            this.btnDoFormula = new System.Windows.Forms.Button();
            this.lblPar3 = new System.Windows.Forms.Label();
            this.txtPar3 = new System.Windows.Forms.TextBox();
            this.lblPar2 = new System.Windows.Forms.Label();
            this.txtPar2 = new System.Windows.Forms.TextBox();
            this.lblPar1 = new System.Windows.Forms.Label();
            this.txtPar1 = new System.Windows.Forms.TextBox();
            this.stsInfo = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.sfdSaveStruct = new System.Windows.Forms.SaveFileDialog();
            this.chkPossible = new System.Windows.Forms.CheckBox();
            this.tabMain.SuspendLayout();
            this.tabLoad.SuspendLayout();
            this.gpbFilesLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStructures)).BeginInit();
            this.tabAnalyze.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbHi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtAnalyze)).BeginInit();
            this.tabMath.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpParameters.SuspendLayout();
            this.stsInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabLoad);
            this.tabMain.Controls.Add(this.tabAnalyze);
            this.tabMain.Controls.Add(this.tabMath);
            this.tabMain.Location = new System.Drawing.Point(0, 1);
            this.tabMain.Margin = new System.Windows.Forms.Padding(4);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1233, 543);
            this.tabMain.TabIndex = 0;
            // 
            // tabLoad
            // 
            this.tabLoad.Controls.Add(this.chkPossible);
            this.tabLoad.Controls.Add(this.chkUseOne);
            this.tabLoad.Controls.Add(this.btnRemoveAllNodes);
            this.tabLoad.Controls.Add(this.btnRemoveNode);
            this.tabLoad.Controls.Add(this.btnAnalyze);
            this.tabLoad.Controls.Add(this.btnClose);
            this.tabLoad.Controls.Add(this.btnAddFile);
            this.tabLoad.Controls.Add(this.gpbFilesLoad);
            this.tabLoad.Controls.Add(this.dgvStructures);
            this.tabLoad.Controls.Add(this.btnLoadStruct);
            this.tabLoad.Controls.Add(this.cmbStruct);
            this.tabLoad.Controls.Add(this.lblStruct);
            this.tabLoad.Location = new System.Drawing.Point(4, 26);
            this.tabLoad.Margin = new System.Windows.Forms.Padding(0);
            this.tabLoad.Name = "tabLoad";
            this.tabLoad.Size = new System.Drawing.Size(1225, 513);
            this.tabLoad.TabIndex = 0;
            this.tabLoad.Text = "Create Analyze";
            this.tabLoad.UseVisualStyleBackColor = true;
            // 
            // chkUseOne
            // 
            this.chkUseOne.AutoSize = true;
            this.chkUseOne.Location = new System.Drawing.Point(8, 485);
            this.chkUseOne.Name = "chkUseOne";
            this.chkUseOne.Size = new System.Drawing.Size(163, 21);
            this.chkUseOne.TabIndex = 10;
            this.chkUseOne.Text = "Use only one file";
            this.chkUseOne.UseVisualStyleBackColor = true;
            // 
            // btnRemoveAllNodes
            // 
            this.btnRemoveAllNodes.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveAllNodes.Enabled = false;
            this.btnRemoveAllNodes.Location = new System.Drawing.Point(909, 480);
            this.btnRemoveAllNodes.Name = "btnRemoveAllNodes";
            this.btnRemoveAllNodes.Size = new System.Drawing.Size(150, 26);
            this.btnRemoveAllNodes.TabIndex = 9;
            this.btnRemoveAllNodes.Text = "Clear All";
            this.btnRemoveAllNodes.UseVisualStyleBackColor = false;
            this.btnRemoveAllNodes.Click += new System.EventHandler(this.btnRemoveAllNodes_Click);
            // 
            // btnRemoveNode
            // 
            this.btnRemoveNode.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveNode.Enabled = false;
            this.btnRemoveNode.Location = new System.Drawing.Point(753, 480);
            this.btnRemoveNode.Name = "btnRemoveNode";
            this.btnRemoveNode.Size = new System.Drawing.Size(150, 26);
            this.btnRemoveNode.TabIndex = 8;
            this.btnRemoveNode.Text = "Remove Group";
            this.btnRemoveNode.UseVisualStyleBackColor = false;
            this.btnRemoveNode.Click += new System.EventHandler(this.btnRemoveNode_Click);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.BackColor = System.Drawing.Color.Transparent;
            this.btnAnalyze.Enabled = false;
            this.btnAnalyze.Location = new System.Drawing.Point(597, 480);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(150, 26);
            this.btnAnalyze.TabIndex = 7;
            this.btnAnalyze.Text = "Load Data";
            this.btnAnalyze.UseVisualStyleBackColor = false;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(1064, 480);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 26);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Enabled = false;
            this.btnAddFile.Location = new System.Drawing.Point(441, 480);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(150, 26);
            this.btnAddFile.TabIndex = 6;
            this.btnAddFile.Text = "Add  Files";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // gpbFilesLoad
            // 
            this.gpbFilesLoad.Controls.Add(this.trvFilesLoad);
            this.gpbFilesLoad.Location = new System.Drawing.Point(760, 3);
            this.gpbFilesLoad.Name = "gpbFilesLoad";
            this.gpbFilesLoad.Size = new System.Drawing.Size(457, 471);
            this.gpbFilesLoad.TabIndex = 4;
            this.gpbFilesLoad.TabStop = false;
            this.gpbFilesLoad.Text = "Groups";
            // 
            // trvFilesLoad
            // 
            this.trvFilesLoad.Location = new System.Drawing.Point(6, 22);
            this.trvFilesLoad.Name = "trvFilesLoad";
            this.trvFilesLoad.Size = new System.Drawing.Size(445, 443);
            this.trvFilesLoad.TabIndex = 0;
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
            this.dgvStructures.Location = new System.Drawing.Point(8, 55);
            this.dgvStructures.Name = "dgvStructures";
            this.dgvStructures.RowTemplate.Height = 24;
            this.dgvStructures.Size = new System.Drawing.Size(746, 419);
            this.dgvStructures.TabIndex = 3;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Type.DefaultCellStyle = dataGridViewCellStyle2;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.Width = 180;
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
            this.Unit.Width = 65;
            // 
            // btnLoadStruct
            // 
            this.btnLoadStruct.Location = new System.Drawing.Point(602, 14);
            this.btnLoadStruct.Name = "btnLoadStruct";
            this.btnLoadStruct.Size = new System.Drawing.Size(152, 26);
            this.btnLoadStruct.TabIndex = 2;
            this.btnLoadStruct.Text = "Load Struct";
            this.btnLoadStruct.UseVisualStyleBackColor = true;
            this.btnLoadStruct.Click += new System.EventHandler(this.btnLoadStruct_Click);
            // 
            // cmbStruct
            // 
            this.cmbStruct.FormattingEnabled = true;
            this.cmbStruct.Location = new System.Drawing.Point(164, 14);
            this.cmbStruct.Name = "cmbStruct";
            this.cmbStruct.Size = new System.Drawing.Size(414, 25);
            this.cmbStruct.TabIndex = 1;
            // 
            // lblStruct
            // 
            this.lblStruct.AutoSize = true;
            this.lblStruct.Location = new System.Drawing.Point(12, 17);
            this.lblStruct.Name = "lblStruct";
            this.lblStruct.Size = new System.Drawing.Size(144, 17);
            this.lblStruct.TabIndex = 0;
            this.lblStruct.Text = "Select structure:";
            // 
            // tabAnalyze
            // 
            this.tabAnalyze.Controls.Add(this.lblHi);
            this.tabAnalyze.Controls.Add(this.lblLow);
            this.tabAnalyze.Controls.Add(this.lblH);
            this.tabAnalyze.Controls.Add(this.lblL);
            this.tabAnalyze.Controls.Add(this.label4);
            this.tabAnalyze.Controls.Add(this.label3);
            this.tabAnalyze.Controls.Add(this.rbGraphTypeR);
            this.tabAnalyze.Controls.Add(this.rbGraphTypeAlpha);
            this.tabAnalyze.Controls.Add(this.tbHi);
            this.tabAnalyze.Controls.Add(this.tbLow);
            this.tabAnalyze.Controls.Add(this.chtAnalyze);
            this.tabAnalyze.Location = new System.Drawing.Point(4, 26);
            this.tabAnalyze.Margin = new System.Windows.Forms.Padding(4);
            this.tabAnalyze.Name = "tabAnalyze";
            this.tabAnalyze.Padding = new System.Windows.Forms.Padding(4);
            this.tabAnalyze.Size = new System.Drawing.Size(1225, 513);
            this.tabAnalyze.TabIndex = 1;
            this.tabAnalyze.Text = "Graphics";
            this.tabAnalyze.UseVisualStyleBackColor = true;
            // 
            // lblHi
            // 
            this.lblHi.AutoSize = true;
            this.lblHi.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHi.ForeColor = System.Drawing.Color.Green;
            this.lblHi.Location = new System.Drawing.Point(1155, 485);
            this.lblHi.Name = "lblHi";
            this.lblHi.Size = new System.Drawing.Size(64, 16);
            this.lblHi.TabIndex = 11;
            this.lblHi.Text = "2000 Hz";
            // 
            // lblLow
            // 
            this.lblLow.AutoSize = true;
            this.lblLow.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLow.ForeColor = System.Drawing.Color.Green;
            this.lblLow.Location = new System.Drawing.Point(1155, 466);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(40, 16);
            this.lblLow.TabIndex = 10;
            this.lblLow.Text = "0 Hz";
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Location = new System.Drawing.Point(1117, 485);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(24, 17);
            this.lblH.TabIndex = 9;
            this.lblH.Text = "Hi";
            // 
            // lblL
            // 
            this.lblL.AutoSize = true;
            this.lblL.Location = new System.Drawing.Point(1117, 466);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(32, 17);
            this.lblL.TabIndex = 8;
            this.lblL.Text = "Low";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1185, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1121, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Low";
            // 
            // rbGraphTypeR
            // 
            this.rbGraphTypeR.AutoSize = true;
            this.rbGraphTypeR.Location = new System.Drawing.Point(1124, 408);
            this.rbGraphTypeR.Name = "rbGraphTypeR";
            this.rbGraphTypeR.Size = new System.Drawing.Size(34, 21);
            this.rbGraphTypeR.TabIndex = 4;
            this.rbGraphTypeR.Text = "R";
            this.rbGraphTypeR.UseVisualStyleBackColor = true;
            this.rbGraphTypeR.CheckedChanged += new System.EventHandler(this.rbGraphTypeR_CheckedChanged);
            // 
            // rbGraphTypeAlpha
            // 
            this.rbGraphTypeAlpha.AutoSize = true;
            this.rbGraphTypeAlpha.Checked = true;
            this.rbGraphTypeAlpha.Location = new System.Drawing.Point(1124, 381);
            this.rbGraphTypeAlpha.Name = "rbGraphTypeAlpha";
            this.rbGraphTypeAlpha.Size = new System.Drawing.Size(66, 21);
            this.rbGraphTypeAlpha.TabIndex = 3;
            this.rbGraphTypeAlpha.TabStop = true;
            this.rbGraphTypeAlpha.Text = "Alpha";
            this.rbGraphTypeAlpha.UseVisualStyleBackColor = true;
            this.rbGraphTypeAlpha.CheckedChanged += new System.EventHandler(this.rbGraphTypeAlpha_CheckedChanged);
            // 
            // tbHi
            // 
            this.tbHi.Location = new System.Drawing.Point(1173, 32);
            this.tbHi.Maximum = 2000;
            this.tbHi.Name = "tbHi";
            this.tbHi.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbHi.Size = new System.Drawing.Size(45, 343);
            this.tbHi.TabIndex = 2;
            this.tbHi.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbHi.Value = 2000;
            this.tbHi.ValueChanged += new System.EventHandler(this.tbHi_ValueChanged);
            // 
            // tbLow
            // 
            this.tbLow.Location = new System.Drawing.Point(1120, 32);
            this.tbLow.Maximum = 2000;
            this.tbLow.Name = "tbLow";
            this.tbLow.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbLow.Size = new System.Drawing.Size(45, 343);
            this.tbLow.TabIndex = 1;
            this.tbLow.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbLow.ValueChanged += new System.EventHandler(this.tbLow_ValueChanged);
            // 
            // chtAnalyze
            // 
            this.chtAnalyze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea1.Name = "ChartArea1";
            this.chtAnalyze.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.chtAnalyze.Legends.Add(legend1);
            this.chtAnalyze.Location = new System.Drawing.Point(15, 14);
            this.chtAnalyze.Name = "chtAnalyze";
            this.chtAnalyze.Size = new System.Drawing.Size(1092, 481);
            this.chtAnalyze.TabIndex = 0;
            // 
            // tabMath
            // 
            this.tabMath.Controls.Add(this.groupBox1);
            this.tabMath.Controls.Add(this.grpParameters);
            this.tabMath.Location = new System.Drawing.Point(4, 26);
            this.tabMath.Name = "tabMath";
            this.tabMath.Size = new System.Drawing.Size(1225, 513);
            this.tabMath.TabIndex = 2;
            this.tabMath.Text = "Mathematical Formulas Test";
            this.tabMath.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Controls.Add(this.cmbFormulas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1209, 93);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(746, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Result:";
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.OldLace;
            this.txtResult.Enabled = false;
            this.txtResult.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(817, 37);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(233, 22);
            this.txtResult.TabIndex = 1;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbFormulas
            // 
            this.cmbFormulas.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFormulas.FormattingEnabled = true;
            this.cmbFormulas.Location = new System.Drawing.Point(127, 37);
            this.cmbFormulas.Name = "cmbFormulas";
            this.cmbFormulas.Size = new System.Drawing.Size(564, 24);
            this.cmbFormulas.TabIndex = 3;
            this.cmbFormulas.SelectedIndexChanged += new System.EventHandler(this.cmbFormulas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Formula:";
            // 
            // grpParameters
            // 
            this.grpParameters.Controls.Add(this.lblPar6);
            this.grpParameters.Controls.Add(this.txtPar6);
            this.grpParameters.Controls.Add(this.lblPar5);
            this.grpParameters.Controls.Add(this.txtPar5);
            this.grpParameters.Controls.Add(this.lblPar4);
            this.grpParameters.Controls.Add(this.txtPar4);
            this.grpParameters.Controls.Add(this.btnDoFormula);
            this.grpParameters.Controls.Add(this.lblPar3);
            this.grpParameters.Controls.Add(this.txtPar3);
            this.grpParameters.Controls.Add(this.lblPar2);
            this.grpParameters.Controls.Add(this.txtPar2);
            this.grpParameters.Controls.Add(this.lblPar1);
            this.grpParameters.Controls.Add(this.txtPar1);
            this.grpParameters.Location = new System.Drawing.Point(7, 112);
            this.grpParameters.Name = "grpParameters";
            this.grpParameters.Size = new System.Drawing.Size(1210, 378);
            this.grpParameters.TabIndex = 4;
            this.grpParameters.TabStop = false;
            this.grpParameters.Text = "Parameters";
            // 
            // lblPar6
            // 
            this.lblPar6.AutoSize = true;
            this.lblPar6.Location = new System.Drawing.Point(755, 111);
            this.lblPar6.Name = "lblPar6";
            this.lblPar6.Size = new System.Drawing.Size(64, 17);
            this.lblPar6.TabIndex = 17;
            this.lblPar6.Text = "Result:";
            this.lblPar6.Visible = false;
            // 
            // txtPar6
            // 
            this.txtPar6.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPar6.Location = new System.Drawing.Point(758, 135);
            this.txtPar6.Margin = new System.Windows.Forms.Padding(4);
            this.txtPar6.Name = "txtPar6";
            this.txtPar6.Size = new System.Drawing.Size(291, 22);
            this.txtPar6.TabIndex = 16;
            this.txtPar6.Visible = false;
            // 
            // lblPar5
            // 
            this.lblPar5.AutoSize = true;
            this.lblPar5.Location = new System.Drawing.Point(386, 111);
            this.lblPar5.Name = "lblPar5";
            this.lblPar5.Size = new System.Drawing.Size(64, 17);
            this.lblPar5.TabIndex = 15;
            this.lblPar5.Text = "Result:";
            this.lblPar5.Visible = false;
            // 
            // txtPar5
            // 
            this.txtPar5.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPar5.Location = new System.Drawing.Point(390, 135);
            this.txtPar5.Margin = new System.Windows.Forms.Padding(4);
            this.txtPar5.Name = "txtPar5";
            this.txtPar5.Size = new System.Drawing.Size(291, 22);
            this.txtPar5.TabIndex = 14;
            this.txtPar5.Visible = false;
            // 
            // lblPar4
            // 
            this.lblPar4.AutoSize = true;
            this.lblPar4.Location = new System.Drawing.Point(10, 111);
            this.lblPar4.Name = "lblPar4";
            this.lblPar4.Size = new System.Drawing.Size(64, 17);
            this.lblPar4.TabIndex = 13;
            this.lblPar4.Text = "Result:";
            this.lblPar4.Visible = false;
            // 
            // txtPar4
            // 
            this.txtPar4.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPar4.Location = new System.Drawing.Point(14, 135);
            this.txtPar4.Margin = new System.Windows.Forms.Padding(4);
            this.txtPar4.Name = "txtPar4";
            this.txtPar4.Size = new System.Drawing.Size(291, 22);
            this.txtPar4.TabIndex = 12;
            this.txtPar4.Visible = false;
            // 
            // btnDoFormula
            // 
            this.btnDoFormula.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoFormula.Location = new System.Drawing.Point(1102, 346);
            this.btnDoFormula.Name = "btnDoFormula";
            this.btnDoFormula.Size = new System.Drawing.Size(102, 26);
            this.btnDoFormula.TabIndex = 11;
            this.btnDoFormula.Text = "Do";
            this.btnDoFormula.UseVisualStyleBackColor = true;
            this.btnDoFormula.Click += new System.EventHandler(this.btnDoFormula_Click);
            // 
            // lblPar3
            // 
            this.lblPar3.AutoSize = true;
            this.lblPar3.Location = new System.Drawing.Point(756, 43);
            this.lblPar3.Name = "lblPar3";
            this.lblPar3.Size = new System.Drawing.Size(64, 17);
            this.lblPar3.TabIndex = 10;
            this.lblPar3.Text = "Result:";
            this.lblPar3.Visible = false;
            // 
            // txtPar3
            // 
            this.txtPar3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPar3.Location = new System.Drawing.Point(759, 67);
            this.txtPar3.Margin = new System.Windows.Forms.Padding(4);
            this.txtPar3.Name = "txtPar3";
            this.txtPar3.Size = new System.Drawing.Size(291, 22);
            this.txtPar3.TabIndex = 9;
            this.txtPar3.Visible = false;
            // 
            // lblPar2
            // 
            this.lblPar2.AutoSize = true;
            this.lblPar2.Location = new System.Drawing.Point(387, 43);
            this.lblPar2.Name = "lblPar2";
            this.lblPar2.Size = new System.Drawing.Size(64, 17);
            this.lblPar2.TabIndex = 8;
            this.lblPar2.Text = "Result:";
            this.lblPar2.Visible = false;
            // 
            // txtPar2
            // 
            this.txtPar2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPar2.Location = new System.Drawing.Point(391, 67);
            this.txtPar2.Margin = new System.Windows.Forms.Padding(4);
            this.txtPar2.Name = "txtPar2";
            this.txtPar2.Size = new System.Drawing.Size(291, 22);
            this.txtPar2.TabIndex = 7;
            this.txtPar2.Visible = false;
            // 
            // lblPar1
            // 
            this.lblPar1.AutoSize = true;
            this.lblPar1.Location = new System.Drawing.Point(11, 43);
            this.lblPar1.Name = "lblPar1";
            this.lblPar1.Size = new System.Drawing.Size(64, 17);
            this.lblPar1.TabIndex = 6;
            this.lblPar1.Text = "Result:";
            this.lblPar1.Visible = false;
            // 
            // txtPar1
            // 
            this.txtPar1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPar1.Location = new System.Drawing.Point(15, 67);
            this.txtPar1.Margin = new System.Windows.Forms.Padding(4);
            this.txtPar1.Name = "txtPar1";
            this.txtPar1.Size = new System.Drawing.Size(291, 22);
            this.txtPar1.TabIndex = 5;
            this.txtPar1.Visible = false;
            // 
            // stsInfo
            // 
            this.stsInfo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelInfo});
            this.stsInfo.Location = new System.Drawing.Point(0, 547);
            this.stsInfo.Name = "stsInfo";
            this.stsInfo.Size = new System.Drawing.Size(1233, 22);
            this.stsInfo.SizingGrip = false;
            this.stsInfo.TabIndex = 1;
            // 
            // toolStripStatusLabelInfo
            // 
            this.toolStripStatusLabelInfo.Name = "toolStripStatusLabelInfo";
            this.toolStripStatusLabelInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // chkPossible
            // 
            this.chkPossible.AutoSize = true;
            this.chkPossible.Location = new System.Drawing.Point(178, 484);
            this.chkPossible.Name = "chkPossible";
            this.chkPossible.Size = new System.Drawing.Size(251, 21);
            this.chkPossible.TabIndex = 11;
            this.chkPossible.Text = "Limited with possible values";
            this.chkPossible.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 569);
            this.Controls.Add(this.stsInfo);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kundt Analisys";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabMain.ResumeLayout(false);
            this.tabLoad.ResumeLayout(false);
            this.tabLoad.PerformLayout();
            this.gpbFilesLoad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStructures)).EndInit();
            this.tabAnalyze.ResumeLayout(false);
            this.tabAnalyze.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbHi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtAnalyze)).EndInit();
            this.tabMath.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpParameters.ResumeLayout(false);
            this.grpParameters.PerformLayout();
            this.stsInfo.ResumeLayout(false);
            this.stsInfo.PerformLayout();
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
        private System.Windows.Forms.GroupBox gpbFilesLoad;
        private System.Windows.Forms.TreeView trvFilesLoad;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInfo;
        private System.Windows.Forms.Button btnRemoveNode;
        private System.Windows.Forms.Button btnRemoveAllNodes;
        private System.Windows.Forms.TabPage tabMath;
        private System.Windows.Forms.ComboBox cmbFormulas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpParameters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblPar3;
        private System.Windows.Forms.TextBox txtPar3;
        private System.Windows.Forms.Label lblPar2;
        private System.Windows.Forms.TextBox txtPar2;
        private System.Windows.Forms.Label lblPar1;
        private System.Windows.Forms.TextBox txtPar1;
        private System.Windows.Forms.Button btnDoFormula;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtAnalyze;
        private System.Windows.Forms.SaveFileDialog sfdSaveStruct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Field;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.TrackBar tbHi;
        private System.Windows.Forms.TrackBar tbLow;
        private System.Windows.Forms.RadioButton rbGraphTypeR;
        private System.Windows.Forms.RadioButton rbGraphTypeAlpha;
        private System.Windows.Forms.Label lblHi;
        private System.Windows.Forms.Label lblLow;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPar6;
        private System.Windows.Forms.TextBox txtPar6;
        private System.Windows.Forms.Label lblPar5;
        private System.Windows.Forms.TextBox txtPar5;
        private System.Windows.Forms.Label lblPar4;
        private System.Windows.Forms.TextBox txtPar4;
        private System.Windows.Forms.CheckBox chkUseOne;
        private System.Windows.Forms.CheckBox chkPossible;
    }
}