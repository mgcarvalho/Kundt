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
        public Dictionary<string, Color> Colors { get; internal set; }

        private string Temperature;
        private string ATP;

        public frmLoadFile()
        {
            Temperature = string.Empty;
            ATP = string.Empty;
            InitializeComponent();
        }

        private void PrepareInput()
        {
            lblStructName.Text = StructName["NAME"];
            lblStructName.Location = new Point(lblTitle.Size.Width + 17, lblTitle.Location.Y);
            txtCASE.Text = string.Empty;
            dtpDATA.Text = string.Empty;
            txtTMP.Text = Temperature + " ºC";
            txtATP.Text = ATP + " KPa";
            txtFILE1.Text = string.Empty;
            txtFILE2.Text = string.Empty;
            cmbColors.DataSource = new BindingSource(Colors, null);
            cmbColors.DisplayMember = "Value";
            cmbColors.ValueMember = "Key";
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
            if (string.IsNullOrEmpty(txtFILE1.Text) || string.IsNullOrEmpty(txtFILE1.Text))
            {
                MessageBox.Show("File 1 and File 2 are required!", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            if (ATP.Length == 0) { ATP = "101.32"; }
            if (Temperature.Length == 0) { Temperature = "22"; }
            StructName.Add("CASE", txtCASE.Text);
            StructName.Add("DATA", dtpDATA.Text);
            StructName.Add("TEMP", Temperature);
            StructName.Add("ATP", ATP);
            StructName.Add("FILE1", txtFILE1.Text);
            StructName.Add("FILE2", txtFILE2.Text);
            StructName.Add("COLOR", cmbColors.Text);
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

        private void btnFile2_Click(object sender, EventArgs e)
        {
            txtFILE2.Text = FileName();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInput();
        }

        private void txtTMP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar))
            {
                Temperature += e.KeyChar;
            }
            else if (e.KeyChar.ToString().Equals("-"))
            {
                if (Temperature.Length == 0 || !Temperature.Substring(0,1).Equals("-"))
                {
                    Temperature = "-" + Temperature;
                }
            }
            else if (e.KeyChar.ToString().Equals(".")|| e.KeyChar.ToString().Equals(","))
            {
                if (Temperature.IndexOf('.') == -1)
                {
                    if (Temperature.Length == 0)
                    {
                        Temperature = "0";
                    }
                    Temperature += '.';
                }
            }
            txtTMP.Text = Temperature + " ºC";
            txtTMP.SelectionStart = txtTMP.Text.Length - 3;
            txtTMP.SelectionLength = 0;
        }

        private void txtTMP_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            if (e.KeyCode == Keys.Delete)
            {
                Temperature = string.Empty;
                txtTMP.Text = Temperature + " ºC";
                txtTMP.SelectionStart = 0;
                txtTMP.SelectionLength = 0;
            }
            else if (e.KeyCode == Keys.Back)
            {
                if (Temperature.Length > 0) { Temperature = Temperature.Substring(0, Temperature.Length - 1); }
            }
            else if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (Temperature.Length == 0 ) { Temperature = "22"; }
                else if (Temperature.Equals("-")) { Temperature = "-1"; }
                txtTMP.Text = Temperature + " ºC";
                txtATP.Focus();
            }
        }

        private void txtATP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar))
            {
                ATP += e.KeyChar;
            }
            else if (e.KeyChar.ToString().Equals(".") || e.KeyChar.ToString().Equals(","))
            {
                if (ATP.IndexOf('.') == -1)
                {
                    if (ATP.Length == 0)
                    {
                        ATP = "0";
                    }
                    ATP += '.';
                }
            }
            txtATP.Text = ATP + " KPa";
            txtATP.SelectionStart = txtATP.Text.Length - 4;
            txtATP.SelectionLength = 0;
        }

        private void txtATP_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            if (e.KeyCode == Keys.Delete)
            {
                ATP = string.Empty;
                txtATP.Text = ATP + " KPa";
                txtATP.SelectionStart = 0;
                txtATP.SelectionLength = 0;
            }
            else if (e.KeyCode == Keys.Back)
            {
                if (ATP.Length > 0) { ATP = ATP.Substring(0, ATP.Length - 1); }
            }
            else if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (ATP.Length == 0 || ATP.Equals(".")) { ATP = "101.32"; }
                txtATP.Text = ATP + " KPa";
                btnFile1.Focus();
            }
        }

        private void txtATP_Leave(object sender, EventArgs e)
        {
            if (ATP.Length == 0 || ATP.Equals(".")) { ATP = "101.32"; }
            txtATP.Text = ATP + " KPa";
        }

        private void txtTMP_Leave(object sender, EventArgs e)
        {
            if (Temperature.Length == 0) { Temperature = "22"; }
            else if (Temperature.Equals("-")) { Temperature = "-1"; }
            txtTMP.Text = Temperature + " ºC";
        }
    }
}
