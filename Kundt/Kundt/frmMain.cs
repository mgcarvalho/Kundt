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

        public frmMain()
        {
            InitializeComponent();
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

                btnAnalyze.Enabled = true;
                btnAnalyze.BackColor = Color.YellowGreen;

                
            }
            frm.Dispose();            
        }

        private void btnClearStruct_Click(object sender, EventArgs e)
        {
            Clear();
            MensagenStatus("Clear!", levelMensage.info);
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

        enum levelMensage
        {
            info,
            warning,
            error
        }
    }
}
