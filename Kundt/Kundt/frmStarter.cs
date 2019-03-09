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
    public partial class frmStarter : Form
    {
        Timer Clock = new Timer();

        public frmStarter()
        {
            InitializeComponent();

            
            Clock.Interval = 1500; 
            Clock.Tick += new EventHandler(JumpToMain);
            Clock.Start();

            
        }

        private void JumpToMain(object sender, EventArgs e)
        {
            Form main = new frmMain();
            main.Show();
            this.Hide();

            Clock.Stop();
            
        }
    }
}
