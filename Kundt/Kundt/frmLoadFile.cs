﻿namespace Kundt
{

    using DTO;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class frmLoadFile : Form
    {
        public Measurement ScreenMeasurement { get; set; }
        public Dictionary<string, Color> Colors { get; internal set; }

        private string Temperature;
        private string  ATP;
        private string s;
        private string x1;

        public frmLoadFile()
        {
            Temperature = "22";
            ATP = "101.32";
            s = "0.069";
            x1 = "0.1182";
            InitializeComponent();
        }

        private void PrepareInput()
        {
            lblStructName.Text = ScreenMeasurement.Struct;
            lblStructName.Location = new Point(lblTitle.Size.Width + 17, lblTitle.Location.Y);
            txtCASE.Text = string.Empty;
            dtpDATA.Text = string.Empty;
            txtTMP.Text = Temperature + " ºC";
            txtATP.Text = ATP + " KPa";
            txtMicDistance.Text = s + " m";
            txtFurtherMicDistance.Text = x1 + " m";
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
            double tp=0;
            double ap=0;
            double ts = 0;
            double tx = 0;

            if (!double.TryParse(ATP,         out ap)) { ap = 101.32; }
            if (!double.TryParse(Temperature, out tp)) { tp = 22; }
            if (!double.TryParse(s,           out ts)) { ts = 0.069; }
            if (!double.TryParse(x1,          out tx)) { tx = 0.1182; }

            if (string.IsNullOrEmpty(txtFILE1.Text) || string.IsNullOrEmpty(txtFILE2.Text))
            {
                MessageBox.Show("File 1 and File 2 are required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtFILE1.Text.Equals(txtFILE2.Text, StringComparison.InvariantCultureIgnoreCase))
            {
                MessageBox.Show("File 1 and File 2 are the same!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ScreenMeasurement.CaseName= txtCASE.Text;
            ScreenMeasurement.Date= dtpDATA.Value;
            ScreenMeasurement.Temperature = tp;
            ScreenMeasurement.AtmosphericPressure= ap;
            ScreenMeasurement.MicDistance = ts;
            ScreenMeasurement.furtherMicDistance = tx; 
            ScreenMeasurement.FileName1 = txtFILE1.Text;
            ScreenMeasurement.FileName2 = txtFILE2.Text;
            ScreenMeasurement.LineColor = cmbColors.Text;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ScreenMeasurement = null;
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
                if (Temperature.Length == 0 || !Temperature.Substring(0, 1).Equals("-"))
                {
                    Temperature = "-" + Temperature;
                }
            }
            else if (e.KeyChar.ToString().Equals(".") || e.KeyChar.ToString().Equals(","))
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
                if (Temperature.Length == 0) { Temperature = "22"; }
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
                txtMicDistance.Focus();
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

        private void txtMicDistance_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            if (e.KeyCode == Keys.Delete)
            {
                s = string.Empty;
                txtMicDistance.Text = s + " m";
                txtMicDistance.SelectionStart = 0;
                txtMicDistance.SelectionLength = 0;
            }
            else if (e.KeyCode == Keys.Back)
            {
                if (s.Length > 0) { s = s.Substring(0, s.Length - 1); }
            }
            else if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (s.Length == 0) { s = "0.069"; }
                txtMicDistance.Text = s + " m";
                txtFurtherMicDistance.Focus();
            }
        }

        private void txtMicDistance_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar))
            {
                s += e.KeyChar;
            }
            else if (e.KeyChar.ToString().Equals(".") || e.KeyChar.ToString().Equals(","))
            {
                if (s.IndexOf('.') == -1)
                {
                    if (ATP.Length == 0)
                    {
                        s = "0";
                    }
                    s += '.';
                }
            }
            txtMicDistance.Text = s + " m";
            txtMicDistance.SelectionStart = txtMicDistance.Text.Length - 2;
            txtMicDistance.SelectionLength = 0;
        }

        private void txtMicDistance_Leave(object sender, EventArgs e)
        {
            if (s.Length == 0 || s.Equals(".")) { s = "0.069"; }
            txtMicDistance.Text = s + " m";
        }

        private void txtFurtherMicDistance_Leave(object sender, EventArgs e)
        {
            if (x1.Length == 0 || x1.Equals(".")) { x1 = "0.1182"; }
            txtFurtherMicDistance.Text = x1 + " m";
        }

        private void txtFurtherMicDistance_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            if (e.KeyCode == Keys.Delete)
            {
                x1 = string.Empty;
                txtFurtherMicDistance.Text = s + " m";
                txtFurtherMicDistance.SelectionStart = 0;
                txtFurtherMicDistance.SelectionLength = 0;
            }
            else if (e.KeyCode == Keys.Back)
            {
                if (x1.Length > 0) { x1 = x1.Substring(0, x1.Length - 1); }
            }
            else if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (x1.Length == 0) { x1 = "0.1182"; }
                txtFurtherMicDistance.Text = x1 + " m";
                btnFile1.Focus();
            }
        }

        private void txtFurtherMicDistance_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar))
            {
                x1 += e.KeyChar;
            }
            else if (e.KeyChar.ToString().Equals(".") || e.KeyChar.ToString().Equals(","))
            {
                if (x1.IndexOf('.') == -1)
                {
                    if (x1.Length == 0)
                    {
                        x1 = "0";
                    }
                    x1 += '.';
                }
            }
            txtFurtherMicDistance.Text = x1 + " m";
            txtFurtherMicDistance.SelectionStart = txtMicDistance.Text.Length - 2;
            txtFurtherMicDistance.SelectionLength = 0;
        }
    }
}
