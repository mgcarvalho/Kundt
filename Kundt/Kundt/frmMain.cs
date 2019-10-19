namespace Kundt
{

    using DTO;
    using DTO.Enum;
    using KundtExceptions;
    using KundtManager;
    using Solver;

    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Drawing;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Windows.Forms;
    using System.Windows.Forms.DataVisualization.Charting;

    public partial class frmMain : Form
    {
        public string SelectStruct { get; set; }

        public string StructName { get; set; }

        private bool ValuesLoaded = false;

        public Dictionary<string, string> ListFormulas { get; set; }

        public Dictionary<string, Color> ListColors { get; set; }

        private List<Measurement> Measurements;

        #region ctor
        public frmMain()
        {
            InitializeComponent();
            LoadFormulas();
            Measurements = new List<Measurement>();
            ListColors = GetAllColors();

        }
        #endregion

        #region Privates

        private enum LevelMensage
        {
            info,
            warning,
            error
        }

        private Dictionary<string, Color> GetAllColors()
        {
            Dictionary<string, Color> result = new Dictionary<string, Color>
            {
                { "Blue", Color.Blue },
                { "Red", Color.Red },
                { "Green", Color.Green },
                { "Orange", Color.Orange },
                { "Purple", Color.Purple }
            };
            return result;
        }

        private void BindingData()
        {
            try
            {
                var lS = new LoadStructs();
                dgvStructures.DataSource = new BindingSource(lS.GetStructs(SelectStruct), null);

                btnAddFile.Enabled = true;
                btnAddFile.BackColor = Color.YellowGreen;
                MensagenStatus("Structure loaded with success", LevelMensage.info);
            }
            catch (LoadExceptions le)
            {
                MensagenStatus(le.Message, LevelMensage.warning);
            }
            catch (Exception ex)
            {
                MensagenStatus(ex.Message, LevelMensage.error);
            }
        }

        private void Clear()
        {
            List<StructFile> ls = new List<StructFile>();
            dgvStructures.DataSource = new BindingSource(ls, null);

            btnAddFile.Enabled = false;
            btnAddFile.BackColor = Color.Transparent;

            btnAnalyze.Enabled = false;
            btnAnalyze.BackColor = Color.Transparent;

            trvFilesLoad.Nodes.Clear();
            Measurements = new List<Measurement>();
            ListColors = GetAllColors();

            btnRemoveNode.Enabled = false;
            btnRemoveNode.BackColor = Color.Transparent;

            btnRemoveAllNodes.Enabled = false;
            btnRemoveAllNodes.BackColor = Color.Transparent;

            ListColors = GetAllColors();
        }

        private void MensagenStatus(string mensage, LevelMensage level)
        {
            toolStripStatusLabelInfo.Text = mensage;
            switch (level)
            {
                case LevelMensage.info:
                    stsInfo.ForeColor = Color.Green;
                    break;
                case LevelMensage.warning:
                    stsInfo.ForeColor = Color.OrangeRed;
                    break;
                case LevelMensage.error:
                    stsInfo.ForeColor = Color.Red;
                    break;
                default:
                    stsInfo.ForeColor = Color.OrangeRed;
                    break;
            }
        }

        private void LoadTreeView(Measurement measurement)
        {
            if (trvFilesLoad.Nodes.ContainsKey(measurement.CaseName))
            {
                trvFilesLoad.Nodes.RemoveByKey(measurement.CaseName);
            }

            trvFilesLoad.Nodes.Add(measurement.CaseName, measurement.CaseName);

            int rootIndex = trvFilesLoad.Nodes.IndexOfKey(measurement.CaseName);
            if (rootIndex >= 0)
            {
                trvFilesLoad.Nodes[rootIndex].Nodes.Add($"Data: {measurement.Date}");
                trvFilesLoad.Nodes[rootIndex].Nodes.Add($"Temperature: {measurement.Temperature} ºC");
                trvFilesLoad.Nodes[rootIndex].Nodes.Add($"Atmospheric Pressure: {measurement.AtmosphericPressure} KPa");
                trvFilesLoad.Nodes[rootIndex].Nodes.Add($"Line Color: {measurement.LineColor}");
                trvFilesLoad.Nodes[rootIndex].Nodes[3].Nodes.Add("      ");
                trvFilesLoad.Nodes[rootIndex].Nodes[3].Nodes[0].BackColor = Color.FromName(measurement.LineColor);
                trvFilesLoad.Nodes[rootIndex].Nodes.Add("Files");
                trvFilesLoad.Nodes[rootIndex].Nodes[4].Nodes.Add($"File (1): {measurement.FileName1}");
                trvFilesLoad.Nodes[rootIndex].Nodes[4].Nodes.Add($"File (2): {measurement.FileName2}");
            }
            //Remove used color
            ListColors.Remove(measurement.LineColor);
        }

        private void AddNewMeasures(Measurement measurement)
        {
            Measurements.RemoveAll(x => x.CaseName.Equals(measurement.CaseName)); ;
            Measurements.Add(measurement);
        }

        private void LoadFormulas()
        {
            ListFormulas = new Dictionary<string, string>();
            Type tSolver = typeof(KundtFunctions);

            MethodInfo[] methods = tSolver.GetMethods();

            ListFormulas.Add("--", "Select One");
            foreach (var item in methods.Where(x => x.IsStatic))
            {
                ListFormulas.Add(item.Name, item.Name);
                var tst = item.GetParameters();
            }
            cmbFormulas.DataSource = new BindingSource(ListFormulas, null);
            cmbFormulas.DisplayMember = "Value";
            cmbFormulas.ValueMember = "Key";
        }

        private void RemoveCase(string CaseName)
        {
            trvFilesLoad.Nodes.RemoveByKey(CaseName);
            Measurements.RemoveAll(x => x.CaseName.Equals(CaseName));
        }

        private void LoadMeasureFiles()
        {
            int count = 1;
            foreach (var item in Measurements)
            {
                //FILE 1
                toolStripStatusLabelInfo.Text = $"Processing file A {count} of {Measurements.Count}! Wait...";
                var file1 = LoadDataFile(item.FileName1, item.Struct);
                if (item.MeasurementsFile1.Count == 0) item.MeasurementsFile1.AddRange(file1);

                //File 2
                toolStripStatusLabelInfo.Text = $"Processing file B {count} of {Measurements.Count}! Wait...";
                var file2 = LoadDataFile(item.FileName2, item.Struct);
                if (item.MeasurementsFile2.Count == 0) item.MeasurementsFile2.AddRange(file2);

                //Calculate FRF
                item.Results = CalculateFRF(item);

                count++;
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Frequency;{Measurements[0].CaseName};{Measurements[1].CaseName};{Measurements[2].CaseName}");
            for (int i = 440; i < 1901; i++)
            {
                //Results                
                Double v1=0, v2=0, v3=0;

                if (Measurements[0].Results.Any(x => x.Frequency == i) 
                    && Measurements[1].Results.Any(x => x.Frequency == i)
                    && Measurements[2].Results.Any(x => x.Frequency == i))
                {
                    v1 = Measurements[0].Results.Where(x => x.Frequency == i).Select(x => x.Absorption).First();
                    v2 = Measurements[1].Results.Where(x => x.Frequency == i).Select(x => x.Absorption).First();
                    v3 = Measurements[2].Results.Where(x => x.Frequency == i).Select(x => x.Absorption).First();
                    sb.AppendLine($"{i};{v1};{v2};{v3}");
                }

            }



            toolStripStatusLabelInfo.Text = "Processing file finish!";
        }

        private List<ResultSet> CalculateFRF(Measurement measurement)
        {
            List<ResultSet> frf = new List<ResultSet>();
            foreach (var item in measurement.MeasurementsFile1)
            {
                //double ortherMicValue = 0;
                ResultSet f = new ResultSet();
                f.Frequency = item.M1.Frequency;
                if (measurement.MeasurementsFile2.Any(x => x.M2.Frequency == f.Frequency))
                {
                    double m2Aplification = 0;
                    double m2phase = 0;
                    if (chkUseOne.Checked)
                    {
                        m2Aplification = Math.Abs(item.M1.Amplification);
                        m2phase = item.M1.Phase;
                    }
                    else
                    {
                        var ortherMicValue = measurement.MeasurementsFile2.First(x => x.M2.Frequency == f.Frequency);
                        if (ortherMicValue != null)
                        {
                            m2Aplification = KundtFunctions.TransferFunction(Math.Abs(item.M1.Amplification), Math.Abs(ortherMicValue.M2.Amplification));
                            m2phase = KundtFunctions.TransferFunction(item.M1.Phase, ortherMicValue.M2.Phase); ;
                        }
                    }
                    f.Amplification = m2Aplification;
                    f.Phase = m2phase;
                    f.Reflection = KundtFunctions.Reflection(f.Frequency, f.Amplification, f.Phase, measurement.Temperature, measurement.MicDistance, measurement.furtherMicDistance);
                    f.Absorption = KundtFunctions.Absorption(f.Reflection);
                    f.Impedance = KundtFunctions.Impedance(f.Reflection);

                    if (CheckValues(f))
                    {
                        if (chkPossible.Checked)
                        {
                            if (f.Reflection >= -0.2 && f.Reflection <= 1.2)
                            { frf.Add(f); }
                        }
                        else
                        { frf.Add(f); }
                    }
                }
            }
            return frf;
        }

        private bool CheckValues(ResultSet values)
        {
            if (values.Absorption < -0.5) return false;

            return !Double.IsNaN(values.Amplification)
                && !Double.IsNaN(values.Phase)
                && !Double.IsInfinity(values.Impedance)
                && !Double.IsInfinity(values.Reflection)
                && !Double.IsInfinity(values.Absorption);
        }

        private void LoadGraphic(IList<Measurement> measurements, AnalyzerType type)
        {
            this.chtAnalyze.Series.Clear();

            foreach (var item in measurements)
            {
                this.chtAnalyze.Series.Add(CreateSerie(item, type));
            }



        }

        private Series CreateSerie(Measurement measurement, AnalyzerType ChartType)
        {
            //Filter
            List<ResultSet> partialData = measurement.Results.Where(x => x.Frequency >= tbLow.Value && x.Frequency <= tbHi.Value).ToList();

            Series sr = new Series();
            sr.Name = measurement.CaseName;
            sr.ChartType = SeriesChartType.Line;
            sr.Color = Color.FromName(measurement.LineColor);
            List<double> listX = partialData.Select(x => x.Frequency).ToList();
            List<double> listY = new List<double>();

            switch (ChartType)
            {
                case AnalyzerType.Alpha:
                    listY = partialData.Select(x => x.Absorption).ToList();
                    break;
                case AnalyzerType.R:
                    listY = partialData.Select(x => x.Reflection).ToList();
                    break;
                case AnalyzerType.I:
                    listY = partialData.Select(x => x.Impedance).ToList();
                    break;
                default:
                    break;
            }
            sr.Points.DataBindXY(listX, listY);
            sr.BorderWidth = 1;
            return sr;
        }

        private IList<DataMeasurement> LoadDataFile(string fileName, string structName)
        {
            int frenquencyLimit = 2000;
            List<DataMeasurement> rt = new List<DataMeasurement>();
            var lS = new LoadStructs();
            var structs = lS.GetStructs(SelectStruct);

            int startLine = -1;
            int structLine = -1;
            string structValues = string.Empty;
            int C1t = 0, C1p = 0, C2t = 0, C2p = 0, M1f = 0, M1a = 0, M2f = 0, M2a = 0, M3f = 0, M3a = 0, M4f = 0, M4a = 0, M5p = 0, M6p = 0;

            //; C1: Time[s]; C1:  [Pa]; C2: Time[s]; C2:  [Pa]; M1: FRF(C1, C2) Frequency[Hz]; M1: FRF(C1, C2)[](A); ; M2: FRF(C2, C1) Frequency[Hz]; M2: FRF(C2, C1)[](A); ; M3: FFT(C1) Frequency[Hz]; M3: FFT(C1)[Pa](A); ; M4: FFT(C2) Frequency[Hz]; M4: FFT(C2)[Pa](A);;M5: PHASE(M1) Frequency[Hz];M5: PHASE(M1) Phase[°](A);M6: PHASE(M2) Frequency[Hz];M6: PHASE(M2) Phase[°](A)

            int.TryParse(structs.FirstOrDefault(x => x.Type == StructType.DataStart).Value, out startLine);

            int.TryParse(structs.FirstOrDefault(x => x.Type == StructType.DataIndex).Value, out structLine);

            if (startLine == -1 || structLine == -1)
            {
                MessageBox.Show("Error on load struct file, see Start Line and Struct Line *numbers* values!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MensagenStatus("Cann't load struct file!", LevelMensage.error);
                return null;
            }

            if (!File.Exists(fileName))
            {
                MessageBox.Show($"File {fileName} doesn't exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MensagenStatus("File doesn't exist!", LevelMensage.error);
                return null;
            }

            var lines = File.ReadAllLines(fileName, System.Text.Encoding.UTF7);
            if (lines.Length < structLine - 1 || lines.Length < startLine - 1)
            {
                MessageBox.Show($"The file {fileName} doesn't has information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MensagenStatus("File doesn't has information!", LevelMensage.error);
                return null;
            }


            //TODO:: Colocar a frequencia para fora dos objectos menores
            structValues = lines[structLine - 1];
            var arrayIndex = structValues.Split(';');
            for (var i = 0; i < arrayIndex.Length; i++)
            {
                switch (arrayIndex[i].Trim().ToUpper())
                {
                    case "C1:  TIME[S]":
                        C1t = i;
                        break;
                    case "C1:  [PA]":
                        C1p = i;
                        break;
                    case "C2:  TIME[S]":
                        C2t = i;
                        break;
                    case "C2:  [PA]":
                        C2p = i;
                        break;
                    case "M1: FRF(C1,C2) FREQUENCY[HZ]":
                        M1f = i;
                        break;
                    case "M1: FRF(C1,C2) [](A)":
                        M1a = i;
                        break;
                    case "M2: FRF(C2,C1) FREQUENCY[HZ]":
                        M2f = i;
                        break;
                    case "M2: FRF(C2,C1) [](A)":
                        M2a = i;
                        break;
                    case "M3: FFT(C1) FREQUENCY[HZ]":
                        M3f = i;
                        break;
                    case "M3: FFT(C1) [PA](A)":
                        M3a = i;
                        break;
                    case "M4: FFT(C2) FREQUENCY[HZ]":
                        M4f = i;
                        break;
                    case "M4: FFT(C2) [PA](A)":
                        M4a = i;
                        break;
                    case "M5: PHASE(M1) PHASE[°](A)":
                        M5p = i;
                        break;
                    case "M6: PHASE(M2) PHASE[°](A)":
                        M6p = i;
                        break;
                    default:
                        break;
                }
            }


            for (var i = startLine - 1; i < lines.Length; i++)
            {
                var dM = new DataMeasurement();

                double oV = 0;
                var dataLine = lines[i];
                var dataArray = dataLine.Split(';');
                //C1
                double.TryParse(dataArray[C1t], out oV);
                dM.C1.Time = oV;
                double.TryParse(dataArray[C1p], out oV);
                dM.C1.Pressure = oV;
                //C2
                double.TryParse(dataArray[C2t], out oV);
                dM.C2.Time = oV;
                double.TryParse(dataArray[C2p], out oV);
                dM.C2.Pressure = oV;
                //M1
                double.TryParse(dataArray[M1f], out oV);
                dM.M1.Frequency = oV;
                double.TryParse(dataArray[M1a], out oV);
                dM.M1.Amplification = oV;

                //M2
                double.TryParse(dataArray[M2f], out oV);
                dM.M2.Frequency = oV;
                double.TryParse(dataArray[M2a], out oV);
                dM.M2.Amplification = oV;
                //M3
                double.TryParse(dataArray[M3f], out oV);
                dM.M3.Frequency = oV;
                double.TryParse(dataArray[M3a], out oV);
                dM.M3.Amplitude = oV;
                //M4
                double.TryParse(dataArray[M4f], out oV);
                dM.M4.Frequency = oV;
                double.TryParse(dataArray[M4a], out oV);
                dM.M4.Amplitude = oV;
                //M5
                double.TryParse(dataArray[M5p], out oV);
                dM.M1.Phase = oV;
                //M6
                double.TryParse(dataArray[M6p], out oV);
                dM.M2.Phase = oV;

                dM.Id = rt.Count + 1;

                if (dM.M1.Frequency > frenquencyLimit)
                {
                    break;
                }

                rt.Add(dM);
            }
            return rt;
        }

        private void CheckFrenquancy()
        {
            if (tbHi.Value < tbLow.Value)
            {
                lblHi.ForeColor = Color.Red;
                lblLow.ForeColor = Color.Red;
            }
            else
            {
                lblHi.ForeColor = Color.Green;
                lblLow.ForeColor = Color.Green;

                if (rbGraphTypeR.Checked && ValuesLoaded)
                {
                    LoadGraphic(Measurements, AnalyzerType.R);
                }
                else if (rbGraphTypeAlpha.Checked && ValuesLoaded)
                {
                    LoadGraphic(Measurements, AnalyzerType.Alpha);
                }
            }
        }
        #endregion

        #region MAIN_FORM

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var lS = new LoadStructs();
            cmbStruct.DataSource = new BindingSource(lS.GetSavedStructs(), null);
            cmbStruct.DisplayMember = "Value";
            cmbStruct.ValueMember = "Key";

            SelectStruct = cmbStruct.SelectedValue.ToString();
            StructName = cmbStruct.Text;
            BindingData();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region LOAD_DATA
        private void btnLoadStruct_Click(object sender, EventArgs e)
        {
            Clear();
            SelectStruct = cmbStruct.SelectedValue.ToString();
            StructName = cmbStruct.Text;
            BindingData();
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            ValuesLoaded = false;
            if (ListColors.Count == 0)
            {
                MessageBox.Show("This version has a limited amount of five files for analysis.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MensagenStatus("No more slots for files!", LevelMensage.warning);
                return;
            }

            frmLoadFile frm = new frmLoadFile
            {
                ScreenMeasurement = new Measurement(),
                Colors = ListColors
            };
            frm.ScreenMeasurement.Struct = StructName;
            frm.ShowDialog();

            if (frm.ScreenMeasurement == null)
            {
                MensagenStatus("No Information!", LevelMensage.warning);
            }
            else
            {
                AddNewMeasures(frm.ScreenMeasurement);
                LoadTreeView(frm.ScreenMeasurement);
                btnAnalyze.Enabled = true;
                btnAnalyze.BackColor = Color.YellowGreen;
                if (Measurements.Count > 0 && !btnRemoveNode.Enabled)
                {
                    btnRemoveNode.Enabled = true;
                    btnRemoveNode.BackColor = Color.YellowGreen;

                    btnRemoveAllNodes.Enabled = true;
                    btnRemoveAllNodes.BackColor = Color.YellowGreen;
                }
                MensagenStatus("Group insered!", LevelMensage.info);

            }
            frm.Dispose();
        }

        private void btnRemoveNode_Click(object sender, EventArgs e)
        {
            //Verificar se está selecionado e achar
            TreeNode node = trvFilesLoad.SelectedNode;
            if (node != null)
            {
                while (node.Parent != null)
                {
                    node = node.Parent;
                }
                RemoveCase(node.Name);
                MensagenStatus("Group removed!", LevelMensage.info);
                if (Measurements.Count == 0)
                {
                    btnRemoveNode.Enabled = false;
                    btnRemoveNode.BackColor = Color.Transparent;

                    btnRemoveAllNodes.Enabled = false;
                    btnRemoveAllNodes.BackColor = Color.Transparent;
                }
            }
            else
            {
                MessageBox.Show("Select a group at tree to remove it!");
                MensagenStatus("Select a Group!", LevelMensage.error);
            }
        }

        private void btnRemoveAllNodes_Click(object sender, EventArgs e)
        {
            Clear();
            MensagenStatus("Clear!", LevelMensage.info);
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            if (Measurements.Count == 0)
            {
                MessageBox.Show("It`s need at least one file group to continue!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ValuesLoaded = true;
            LoadMeasureFiles();
            LoadGraphic(Measurements, AnalyzerType.Alpha);

            tabMain.SelectedIndex = 1;
        }

        private void tbLow_ValueChanged(object sender, EventArgs e)
        {
            lblLow.Text = $"{tbLow.Value} Hz";
            CheckFrenquancy();
        }

        private void tbHi_ValueChanged(object sender, EventArgs e)
        {
            lblHi.Text = $"{tbHi.Value} Hz";
            CheckFrenquancy();

        }

        #endregion

        #region FORMULA
        private void cmbFormulas_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPar1.Text = string.Empty;
            lblPar1.Visible = false;
            txtPar1.Text = string.Empty;
            txtPar1.Visible = false;
            lblPar2.Text = string.Empty;
            lblPar2.Visible = false;
            txtPar2.Text = string.Empty;
            txtPar2.Visible = false;
            lblPar3.Text = string.Empty;
            lblPar3.Visible = false;
            txtPar3.Text = string.Empty;
            txtPar3.Visible = false;

            lblPar4.Text = string.Empty;
            lblPar4.Visible = false;
            txtPar4.Text = string.Empty;
            txtPar4.Visible = false;
            lblPar5.Text = string.Empty;
            lblPar5.Visible = false;
            txtPar5.Text = string.Empty;
            txtPar5.Visible = false;
            lblPar6.Text = string.Empty;
            lblPar6.Visible = false;
            txtPar6.Text = string.Empty;
            txtPar6.Visible = false;

            string MethodName = ((KeyValuePair<string, string>)cmbFormulas.SelectedItem).Value;

            if (!MethodName.Equals("Select One") && !String.IsNullOrEmpty(MethodName))
            {
                Type tSolver = typeof(KundtFunctions);
                MethodInfo methods = tSolver.GetMethods().Where(x => x.Name.Equals(MethodName)).FirstOrDefault();
                int pos = 1;
                foreach (var item in methods.GetParameters())
                {
                    switch (pos)
                    {
                        case 1:
                            lblPar1.Text = item.Name;
                            lblPar1.Visible = true;
                            txtPar1.Text = string.Empty;
                            txtPar1.Visible = true;
                            break;
                        case 2:
                            lblPar2.Text = item.Name;
                            lblPar2.Visible = true;
                            txtPar2.Text = string.Empty;
                            txtPar2.Visible = true;
                            break;
                        case 3:
                            lblPar3.Text = item.Name;
                            lblPar3.Visible = true;
                            txtPar3.Text = string.Empty;
                            txtPar3.Visible = true;
                            break;
                        case 4:
                            lblPar4.Text = item.Name;
                            lblPar4.Visible = true;
                            txtPar4.Text = string.Empty;
                            txtPar4.Visible = true;
                            break;
                        case 5:
                            lblPar5.Text = item.Name;
                            lblPar5.Visible = true;
                            txtPar5.Text = string.Empty;
                            txtPar5.Visible = true;
                            break;
                        case 6:
                            lblPar6.Text = item.Name;
                            lblPar6.Visible = true;
                            txtPar6.Text = string.Empty;
                            txtPar6.Visible = true;
                            break;
                        default:
                            break;
                    }
                    pos++;
                }
            }
        }

        private void btnDoFormula_Click(object sender, EventArgs e)
        {
            string MethodName = ((KeyValuePair<string, string>)cmbFormulas.SelectedItem).Value;
            Type tSolver = typeof(KundtFunctions);
            MethodInfo methods = tSolver.GetMethods().Where(x => x.Name.Equals(MethodName)).FirstOrDefault();

            if (methods != null)
            {
                ParameterInfo[] parameters = methods.GetParameters();
                //object classInstance = Activator.CreateInstance(tSolver, null);
                try
                {
                    object[] parametersArray = new object[parameters.Count()];
                    double outValue;
                    for (int i = 0; i < parameters.Count(); i++)
                    {
                        outValue = double.MinValue;
                        switch (i)
                        {
                            case 0:
                                double.TryParse(txtPar1.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out outValue);
                                break;
                            case 1:
                                double.TryParse(txtPar2.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out outValue);
                                break;
                            case 2:
                                double.TryParse(txtPar3.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out outValue);
                                break;
                            case 3:
                                double.TryParse(txtPar4.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out outValue);
                                break;
                            case 4:
                                double.TryParse(txtPar5.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out outValue);
                                break;
                            case 5:
                                double.TryParse(txtPar6.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out outValue);
                                break;
                            default:
                                break;
                        }
                        parametersArray[i] = outValue;
                    }
                    txtResult.Text = tSolver.GetMethod(MethodName).Invoke(null, parametersArray).ToString();
                    MensagenStatus($"Success on invoke {MethodName} with result {txtResult.Text}.", LevelMensage.info);
                }
                catch (Exception ex)
                {
                    MensagenStatus($"Error on invoke {MethodName}. The parameters of method need to be a number. ERROR: {ex.Message}", LevelMensage.error);
                }
            }
        }

        private void rbGraphTypeAlpha_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGraphTypeAlpha.Checked && ValuesLoaded)
            {
                LoadGraphic(Measurements, AnalyzerType.Alpha);
            }
        }

        private void rbGraphTypeR_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGraphTypeR.Checked && ValuesLoaded)
            {
                LoadGraphic(Measurements, AnalyzerType.R);
            }
        }

        #endregion

    }
}
