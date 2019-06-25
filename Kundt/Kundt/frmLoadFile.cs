using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kundt
{
    public partial class frmLoadFile : Form
    {
        public Dictionary<string, string> StructName { get; set; }

        public frmLoadFile()
        {
            InitializeComponent();
        }

        private void PrepareInput()
        {
            lblStructName.Text = StructName["NAME"];
            txtCASE.Text = string.Empty;
            dtpDATA.Text = string.Empty;
            txtTEMP.Text = string.Empty;
            txtATP.Text = string.Empty;
            txtFILE1.Text = string.Empty;
            txtFILE2.Text = string.Empty;
        }

        private string FileName()
        {
            string result = string.Empty;
            ofdFiles.ShowDialog();
            result = ofdFiles.FileName;

            return result;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            StructName.Add("CASE", txtCASE.Text);
            StructName.Add("DATA", dtpDATA.Text);
            StructName.Add("TEMP", txtTEMP.Text);
            StructName.Add("ATP", txtATP.Text);
            StructName.Add("FILE1", txtFILE1.Text);
            StructName.Add("FILE2", txtFILE2.Text);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            StructName = null;
            this.Close();
        }

        private void frmLoadFile_Load(object sender, EventArgs e)
        {
            PrepareInput();
        }

        private void btnFile1_Click(object sender, EventArgs e)
        {
            txtFILE1.Text = FileName();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            txtFILE2.Text = FileName();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInput();
        }

        private void txtATP_LostFocus(object sender, EventArgs e)
        {

        }
    }
}
