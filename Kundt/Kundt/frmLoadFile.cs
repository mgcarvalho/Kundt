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
            //Nome Structure
            //CASE Name
            //Data HORA

            //Temperatura (MANUAL or FILE or DEFAULT)
            //ATP (MANUAL or FILE or CALCULATE)

            //FILE 1
            //File 2
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            StructName.Add("FILE1", "TEST OK");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            StructName = null;
            this.Close();
        }
    }
}
