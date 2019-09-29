namespace Kundt
{

    using DTO;
    using KundtExceptions;
    using KundtManager;
    using Solver;

    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Windows.Forms;

    public partial class frmMain : Form
    {
        public string SelectStruct { get; set; }

        public string StructName { get; set; }

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
                item.FRFFixed = CalculateFRF(item); 

                count++;
            }
            toolStripStatusLabelInfo.Text = "Processing file finish!";
        }

        private List<FRF> CalculateFRF(Measurement measurement)
        {
            List<FRF> frf = new List<FRF>();
            foreach (var item in measurement.MeasurementsFile1)
            {
                double ortherMicValue = 0;
                FRF f = new FRF();
                f.Frequency = item.M1.Frequency;
                if (measurement.MeasurementsFile2.Any(x => x.M2.Frequency == f.Frequency))
                {
                    ortherMicValue = measurement.MeasurementsFile2.First(x => x.M2.Frequency == f.Frequency).M2.Amplification;
                    f.Amplification = KundtFunctions.TFFixed(item.M1.Amplification, ortherMicValue);
                    frf.Add(f);                    
                }
            }
            return frf;
        }

        private IList<DataMeasurement> LoadDataFile(string fileName, string structName)
        {
            List<DataMeasurement> rt = new List<DataMeasurement>();
            var lS = new LoadStructs();
            var structs = lS.GetStructs(SelectStruct);

            int startLine = -1;
            int structLine = -1;
            string structValues = string.Empty;
            int C1t = 0, C1p = 0, C2t = 0, C2p = 0, M1f = 0, M1a = 0, M2f = 0, M2a = 0, M3f = 0, M3a = 0, M4f = 0, M4a = 0;

            //; C1: Time[s]; C1:  [Pa]; C2: Time[s]; C2:  [Pa]; M1: FRF(C1, C2) Frequency[Hz]; M1: FRF(C1, C2)[](A); ; M2: FRF(C2, C1) Frequency[Hz]; M2: FRF(C2, C1)[](A); ; M3: FFT(C1) Frequency[Hz]; M3: FFT(C1)[Pa](A); ; M4: FFT(C2) Frequency[Hz]; M4: FFT(C2)[Pa](A);

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

            var lines = File.ReadAllLines(fileName);
            if (lines.Length < structLine - 1 || lines.Length < startLine - 1)
            {
                MessageBox.Show($"The file {fileName} doesn't has information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MensagenStatus("File doesn't has information!", LevelMensage.error);
                return null;
            }



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
                dM.Id = rt.Count + 1;

                //Calculate
                //dM.M1Calculate.Amplification = ;
                //dM.M1Calculate.Frequency;
                //dM.M2Calculate.Amplification;
                //dM.M2Calculate.Frequency;

                rt.Add(dM);
            }
            return rt;
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

            LoadMeasureFiles();
            //LoadGraphic(Measurements);

            tabMain.SelectedIndex = 1;
        }
        #endregion

        #region FORMULA
        private void cmbFormulas_SelectedIndexChanged(object sender, EventArgs e)
        {

            //TODO: Gerar automaticamente
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
                    for (int i = 0; i < parameters.Count(); i++)
                    {
                        switch (i)
                        {
                            case 0:
                                parametersArray[i] = Convert.ToDouble(txtPar1.Text);
                                break;
                            case 1:
                                parametersArray[i] = Convert.ToDouble(txtPar2.Text);
                                break;
                            case 2:
                                parametersArray[i] = Convert.ToDouble(txtPar3.Text);
                                break;
                            default:
                                break;
                        }
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




        #endregion

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
            }
        }

    }
}
