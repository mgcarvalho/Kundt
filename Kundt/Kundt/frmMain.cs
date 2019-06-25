namespace Kundt
{

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    using DTO;
    using KundtExceptions;
    using KundtManager;



    public partial class frmMain : Form
    {
        public string SelectStruct { get; set; }
        public string StructName { get; set; }

        public List<Dictionary<string, string>> ListAnalizer { get; set; }

        public frmMain()
        {
            InitializeComponent();
            ListAnalizer = new List<Dictionary<string, string>>();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var lS = new LoadStructs();
            cmbStruct.DataSource = new BindingSource(lS.GetSavedStructs(), null);
            cmbStruct.DisplayMember = "Value";
            cmbStruct.ValueMember = "Key";
        }

        private void btnLoadStruct_Click(object sender, EventArgs e)
        {
            Clear();
            SelectStruct = cmbStruct.SelectedValue.ToString();
            StructName = cmbStruct.Text;
            BindingData();
        }


        private void btnAddFile_Click(object sender, EventArgs e)
        {
            frmLoadFile frm = new frmLoadFile();
            frm.StructName = new Dictionary<string, string>();
            frm.StructName.Add("NAME", StructName);
            frm.ShowDialog();

            if (frm.StructName == null)
            {
                MensagenStatus("Files not informated!", levelMensage.warning);
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
                }
                MensagenStatus("Group insered!", levelMensage.info);
            }
            frm.Dispose();
        }

        private void btnClearStruct_Click(object sender, EventArgs e)
        {
            Clear();
            MensagenStatus("Clear!", levelMensage.info);
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
                MensagenStatus("Group removed!", levelMensage.info);
                if (ListAnalizer.Count == 0)
                {
                    btnRemoveNode.Enabled = false;
                    btnRemoveNode.BackColor = Color.Transparent;
                }
            }
            else
            {
                MessageBox.Show("Select a group at tree to remove it!");
                MensagenStatus("Select a Group!", levelMensage.error);
            }
        }

        private void BindingData()
        {
            try
            {
                var lS = new LoadStructs();
                dgvStructures.DataSource = new BindingSource(lS.GetStructs(SelectStruct), null);

                btnAddFile.Enabled = true;
                btnAddFile.BackColor = Color.YellowGreen;
                MensagenStatus("Structure loaded with success", levelMensage.info);
            }
            catch (LoadExceptions le)
            {
                MensagenStatus(le.Message, levelMensage.warning);
            }
            catch (Exception ex)
            {
                MensagenStatus(ex.Message, levelMensage.error);
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

            btnRemoveNode.Enabled = false;
            btnRemoveNode.BackColor = Color.Transparent;
        }


        private void MensagenStatus(string mensage, levelMensage level)
        {
            toolStripStatusLabelInfo.Text = mensage;
            switch (level)
            {
                case levelMensage.info:
                    stsInfo.ForeColor = Color.Green;
                    break;
                case levelMensage.warning:
                    stsInfo.ForeColor = Color.OrangeRed;
                    break;
                case levelMensage.error:
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
                trvFilesLoad.Nodes[rootIndex].Nodes.Add($"Temperature: {itemAnalizer["TEMP"]} C");
                trvFilesLoad.Nodes[rootIndex].Nodes.Add($"Atmospheric Pressure: {itemAnalizer["ATP"]} KPa");
                trvFilesLoad.Nodes[rootIndex].Nodes.Add("Files");
                trvFilesLoad.Nodes[rootIndex].Nodes[3].Nodes.Add($"File (1): {itemAnalizer["FILE1"]}");
                trvFilesLoad.Nodes[rootIndex].Nodes[3].Nodes.Add($"File (2): {itemAnalizer["FILE2"]}");
            }
        }

        private void RemoveCase(string CaseName)
        {
            trvFilesLoad.Nodes.RemoveByKey(CaseName);
            foreach (var item in ListAnalizer)
            {
                if (item["CASE"].Equals(CaseName))
                {
                    ListAnalizer.Remove(item);
                    return;
                }
            }
        }

        enum levelMensage
        {
            info,
            warning,
            error
        }

    }
}
