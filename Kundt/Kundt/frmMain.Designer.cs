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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabLoad = new System.Windows.Forms.TabPage();
            this.btnRemoveAllNodes = new System.Windows.Forms.Button();
            this.btnRemoveNode = new System.Windows.Forms.Button();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.gpbFilesLoad = new System.Windows.Forms.GroupBox();
            this.trvFilesLoad = new System.Windows.Forms.TreeView();
            this.dgvStructures = new System.Windows.Forms.DataGridView();
            this.btnLoadStruct = new System.Windows.Forms.Button();
            this.cmbStruct = new System.Windows.Forms.ComboBox();
            this.lblStruct = new System.Windows.Forms.Label();
            this.tabAnalyze = new System.Windows.Forms.TabPage();
            this.chtAnalyze = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabMath = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.cmbFormulas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpParameters = new System.Windows.Forms.GroupBox();
            this.btnDoFormula = new System.Windows.Forms.Button();
            this.lblPar3 = new System.Windows.Forms.Label();
            this.txtPar3 = new System.Windows.Forms.TextBox();
            this.lblPar2 = new System.Windows.Forms.Label();
            this.txtPar2 = new System.Windows.Forms.TextBox();
            this.lblPar1 = new System.Windows.Forms.Label();
            this.txtPar1 = new System.Windows.Forms.TextBox();
            this.btnClearStruct = new System.Windows.Forms.Button();
            this.stsInfo = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLoadAnalyze = new System.Windows.Forms.Button();
            this.btnSaveAnalyze = new System.Windows.Forms.Button();
            this.sfdSaveStruct = new System.Windows.Forms.SaveFileDialog();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Field = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabMain.SuspendLayout();
            this.tabLoad.SuspendLayout();
            this.gpbFilesLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStructures)).BeginInit();
            this.tabAnalyze.SuspendLayout();
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
            this.tabMain.Size = new System.Drawing.Size(1086, 543);
            this.tabMain.TabIndex = 0;
            // 
            // tabLoad
            // 
            this.tabLoad.Controls.Add(this.btnRemoveAllNodes);
            this.tabLoad.Controls.Add(this.btnRemoveNode);
            this.tabLoad.Controls.Add(this.btnAnalyze);
            this.tabLoad.Controls.Add(this.btnAddFile);
            this.tabLoad.Controls.Add(this.gpbFilesLoad);
            this.tabLoad.Controls.Add(this.dgvStructures);
            this.tabLoad.Controls.Add(this.btnLoadStruct);
            this.tabLoad.Controls.Add(this.cmbStruct);
            this.tabLoad.Controls.Add(this.lblStruct);
            this.tabLoad.Location = new System.Drawing.Point(4, 26);
            this.tabLoad.Margin = new System.Windows.Forms.Padding(0);
            this.tabLoad.Name = "tabLoad";
            this.tabLoad.Size = new System.Drawing.Size(1078, 513);
            this.tabLoad.TabIndex = 0;
            this.tabLoad.Text = "Create Analyze";
            this.tabLoad.UseVisualStyleBackColor = true;
            // 
            // btnRemoveAllNodes
            // 
            this.btnRemoveAllNodes.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveAllNodes.Enabled = false;
            this.btnRemoveAllNodes.Location = new System.Drawing.Point(921, 480);
            this.btnRemoveAllNodes.Name = "btnRemoveAllNodes";
            this.btnRemoveAllNodes.Size = new System.Drawing.Size(150, 26);
            this.btnRemoveAllNodes.TabIndex = 9;
            this.btnRemoveAllNodes.Text = "Remove All";
            this.btnRemoveAllNodes.UseVisualStyleBackColor = false;
            this.btnRemoveAllNodes.Click += new System.EventHandler(this.btnRemoveAllNodes_Click);
            // 
            // btnRemoveNode
            // 
            this.btnRemoveNode.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveNode.Enabled = false;
            this.btnRemoveNode.Location = new System.Drawing.Point(765, 480);
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
            this.btnAnalyze.Location = new System.Drawing.Point(609, 480);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(150, 26);
            this.btnAnalyze.TabIndex = 7;
            this.btnAnalyze.Text = "Analyze Files";
            this.btnAnalyze.UseVisualStyleBackColor = false;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Enabled = false;
            this.btnAddFile.Location = new System.Drawing.Point(453, 480);
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
            this.gpbFilesLoad.Size = new System.Drawing.Size(315, 471);
            this.gpbFilesLoad.TabIndex = 4;
            this.gpbFilesLoad.TabStop = false;
            this.gpbFilesLoad.Text = "Groups";
            // 
            // trvFilesLoad
            // 
            this.trvFilesLoad.Location = new System.Drawing.Point(6, 22);
            this.trvFilesLoad.Name = "trvFilesLoad";
            this.trvFilesLoad.Size = new System.Drawing.Size(303, 443);
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
            this.tabAnalyze.Controls.Add(this.chtAnalyze);
            this.tabAnalyze.Location = new System.Drawing.Point(4, 26);
            this.tabAnalyze.Margin = new System.Windows.Forms.Padding(4);
            this.tabAnalyze.Name = "tabAnalyze";
            this.tabAnalyze.Padding = new System.Windows.Forms.Padding(4);
            this.tabAnalyze.Size = new System.Drawing.Size(1078, 513);
            this.tabAnalyze.TabIndex = 1;
            this.tabAnalyze.Text = "Graphics";
            this.tabAnalyze.UseVisualStyleBackColor = true;
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
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtAnalyze.Series.Add(series1);
            this.chtAnalyze.Size = new System.Drawing.Size(1031, 492);
            this.chtAnalyze.TabIndex = 0;
            // 
            // tabMath
            // 
            this.tabMath.Controls.Add(this.groupBox1);
            this.tabMath.Controls.Add(this.grpParameters);
            this.tabMath.Location = new System.Drawing.Point(4, 26);
            this.tabMath.Name = "tabMath";
            this.tabMath.Size = new System.Drawing.Size(1078, 513);
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
            this.groupBox1.Size = new System.Drawing.Size(1056, 93);
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
            this.grpParameters.Controls.Add(this.btnDoFormula);
            this.grpParameters.Controls.Add(this.lblPar3);
            this.grpParameters.Controls.Add(this.txtPar3);
            this.grpParameters.Controls.Add(this.lblPar2);
            this.grpParameters.Controls.Add(this.txtPar2);
            this.grpParameters.Controls.Add(this.lblPar1);
            this.grpParameters.Controls.Add(this.txtPar1);
            this.grpParameters.Location = new System.Drawing.Point(7, 112);
            this.grpParameters.Name = "grpParameters";
            this.grpParameters.Size = new System.Drawing.Size(1057, 198);
            this.grpParameters.TabIndex = 4;
            this.grpParameters.TabStop = false;
            this.grpParameters.Text = "Parameters";
            // 
            // btnDoFormula
            // 
            this.btnDoFormula.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoFormula.Location = new System.Drawing.Point(949, 166);
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
            // btnClearStruct
            // 
            this.btnClearStruct.Location = new System.Drawing.Point(1093, 27);
            this.btnClearStruct.Name = "btnClearStruct";
            this.btnClearStruct.Size = new System.Drawing.Size(136, 40);
            this.btnClearStruct.TabIndex = 5;
            this.btnClearStruct.Text = "New";
            this.btnClearStruct.UseVisualStyleBackColor = true;
            this.btnClearStruct.Click += new System.EventHandler(this.btnClearStruct_Click);
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
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(1093, 500);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(136, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLoadAnalyze
            // 
            this.btnLoadAnalyze.Location = new System.Drawing.Point(1093, 82);
            this.btnLoadAnalyze.Margin = new System.Windows.Forms.Padding(0);
            this.btnLoadAnalyze.Name = "btnLoadAnalyze";
            this.btnLoadAnalyze.Size = new System.Drawing.Size(136, 40);
            this.btnLoadAnalyze.TabIndex = 6;
            this.btnLoadAnalyze.Text = "Load Analyze";
            this.btnLoadAnalyze.UseVisualStyleBackColor = true;
            // 
            // btnSaveAnalyze
            // 
            this.btnSaveAnalyze.Location = new System.Drawing.Point(1093, 136);
            this.btnSaveAnalyze.Margin = new System.Windows.Forms.Padding(0);
            this.btnSaveAnalyze.Name = "btnSaveAnalyze";
            this.btnSaveAnalyze.Size = new System.Drawing.Size(136, 40);
            this.btnSaveAnalyze.TabIndex = 5;
            this.btnSaveAnalyze.Text = "Save Analyze";
            this.btnSaveAnalyze.UseVisualStyleBackColor = true;
            this.btnSaveAnalyze.Click += new System.EventHandler(this.btnSaveAnalyze_Click);
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 569);
            this.Controls.Add(this.btnLoadAnalyze);
            this.Controls.Add(this.btnSaveAnalyze);
            this.Controls.Add(this.btnClearStruct);
            this.Controls.Add(this.btnClose);
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
        private System.Windows.Forms.Button btnClearStruct;
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
        private System.Windows.Forms.Button btnLoadAnalyze;
        private System.Windows.Forms.Button btnSaveAnalyze;
        private System.Windows.Forms.SaveFileDialog sfdSaveStruct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Field;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
    }
}