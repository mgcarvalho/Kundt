namespace Kundt
{

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Xml;
    using System.Xml.Linq;
    using DTO;
    using KundtExceptions;
    using KundtManager;
    using Solver;



    public partial class frmMain : Form
    {
        public string SelectStruct { get; set; }

        public string StructName { get; set; }

        public List<Dictionary<string, string>> ListAnalizer { get; set; }

        public Dictionary<string, string> ListFormulas { get; set; }

        public Dictionary<string, Color> ListColors { get; set; }

        public frmMain()
        {
            InitializeComponent();
            LoadFormulas();
            ListAnalizer = new List<Dictionary<string, string>>();
            ListColors = GetAllColors();

        }
        
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
            ListAnalizer = new List<Dictionary<string, string>>();
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

        private void LoadTreeView(Dictionary<string, string> itemAnalizer)
        {
            if (trvFilesLoad.Nodes.ContainsKey(itemAnalizer["CASE"]))
            {
                RemoveCase(itemAnalizer["CASE"]);
            }
            ListAnalizer.Add(itemAnalizer);

            trvFilesLoad.Nodes.Add(itemAnalizer["CASE"], itemAnalizer["CASE"]);

            int rootIndex = trvFilesLoad.Nodes.IndexOfKey(itemAnalizer["CASE"]);
            if (rootIndex >= 0)
            {
                trvFilesLoad.Nodes[rootIndex].Nodes.Add($"Data: {itemAnalizer["DATA"]}");
                trvFilesLoad.Nodes[rootIndex].Nodes.Add($"Temperature: {itemAnalizer["TEMP"]} ºC");
                trvFilesLoad.Nodes[rootIndex].Nodes.Add($"Atmospheric Pressure: {itemAnalizer["ATP"]} KPa");
                trvFilesLoad.Nodes[rootIndex].Nodes.Add($"Line Color: {itemAnalizer["COLOR"]}");
                trvFilesLoad.Nodes[rootIndex].Nodes[3].Nodes.Add("      ");
                trvFilesLoad.Nodes[rootIndex].Nodes[3].Nodes[0].BackColor = Color.FromName(itemAnalizer["COLOR"]);
                trvFilesLoad.Nodes[rootIndex].Nodes.Add("Files");
                trvFilesLoad.Nodes[rootIndex].Nodes[4].Nodes.Add($"File (1): {itemAnalizer["FILE1"]}");
                trvFilesLoad.Nodes[rootIndex].Nodes[4].Nodes.Add($"File (2): {itemAnalizer["FILE2"]}");
            }
            //Remove color used
            ListColors.Remove(itemAnalizer["COLOR"]);
        }

        private void RemoveCase(string CaseName)
        {
            trvFilesLoad.Nodes.RemoveByKey(CaseName);
            foreach (var item in ListAnalizer)
            {
                if (item["CASE"].Equals(CaseName))
                {
                    ListColors.Add(item["COLOR"], Color.FromName(item["COLOR"]));
                    ListAnalizer.Remove(item);
                    return;
                }
            }
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
                MessageBox.Show("This version has a limited amount of five files for analysis.","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MensagenStatus("No more slots for files!", LevelMensage.warning);
                return;
            }

            frmLoadFile frm = new frmLoadFile
            {
                StructName = new Dictionary<string, string>(),
                Colors = ListColors
            };
            frm.StructName.Add("NAME", StructName);
            frm.ShowDialog();

            if (frm.StructName == null)
            {
                MensagenStatus("Files not informated!", LevelMensage.warning);
            }
            else
            {
                LoadTreeView(frm.StructName);
                btnAnalyze.Enabled = true;
                btnAnalyze.BackColor = Color.YellowGreen;
                if (ListAnalizer.Count > 0 && !btnRemoveNode.Enabled)
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

        private void btnClearStruct_Click(object sender, EventArgs e)
        {
            Clear();
            MensagenStatus("Clear!", LevelMensage.info);
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
                if (ListAnalizer.Count == 0)
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
            trvFilesLoad.Nodes.Clear();
            ListAnalizer = new List<Dictionary<string, string>>();

            btnRemoveNode.Enabled = false;
            btnRemoveNode.BackColor = Color.Transparent;

            btnRemoveAllNodes.Enabled = false;
            btnRemoveAllNodes.BackColor = Color.Transparent;

            ListColors = GetAllColors();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
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

        private void btnSaveAnalyze_Click(object sender, EventArgs e)
        {
            if (ListAnalizer.Count == 0)
            {
                MessageBox.Show("It`s need at least one file group to save!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sfdSaveStruct.ShowDialog();
            string FileName = sfdSaveStruct.FileName;

            try
            {
                if (!string.IsNullOrEmpty(FileName))
                {
                    if (!FileName.EndsWith(".xml"))
                    {
                        FileName = FileName + ".xml";
                    }
                    using (XmlWriter writer = XmlWriter.Create(FileName))
                    {


                        writer.WriteStartElement("Struct");
                        writer.WriteAttributeString("name", StructName);
                        writer.WriteAttributeString("version", "1.0");
                        writer.WriteAttributeString("target", "Kundt Tube Analyzer");
                        
                        writer.WriteStartElement("Files");

                        foreach (var item in ListAnalizer)
                        {
                            writer.WriteStartElement("Group");
                            writer.WriteAttributeString("name", item["CASE"]);

                            writer.WriteStartElement("Data");
                            writer.WriteAttributeString("value", item["DATA"]);
                            writer.WriteEndElement();

                            writer.WriteStartElement("Temperature");
                            writer.WriteAttributeString("value", item["TEMP"]);
                            writer.WriteEndElement();

                            writer.WriteStartElement("Pressure");
                            writer.WriteAttributeString("value", item["ATP"]);
                            writer.WriteEndElement();

                            writer.WriteStartElement("Color");
                            writer.WriteAttributeString("value", item["COLOR"]);
                            writer.WriteEndElement();

                            writer.WriteStartElement("File1");
                            writer.WriteAttributeString("value", item["FILE1"]);
                            writer.WriteEndElement();

                            writer.WriteStartElement("File2");
                            writer.WriteAttributeString("value", item["FILE2"]);
                            writer.WriteEndElement();

                            writer.WriteEndElement();
                        }
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        writer.Flush();
                    }
                }
            }
            catch (IOException IOex)
            {
                MensagenStatus($"Error on create the file {FileName}. ERROR: {IOex.Message}", LevelMensage.error);
            }
            catch (Exception ex)
            {
                MensagenStatus($"Unexpected error: {ex.Message}", LevelMensage.error);
            }
            

        }

    }
}
