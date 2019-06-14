namespace Kundt
{

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    using DTO;
    using KundtManager;



    public partial class frmMain : Form
    {
        public string SelectStruct { get; set; }

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
            SelectStruct = cmbStruct.SelectedValue.ToString();
            BindingData();
        }


        private void BindingData()
        {
            var lS = new LoadStructs();
            dgvStructures.DataSource = new BindingSource(lS.GetStructs(SelectStruct), null);
        }
    }
}
