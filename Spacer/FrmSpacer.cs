using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spacer
{
    public partial class FrmSpacer : Form
    {
        public FrmSpacer()
        {
            InitializeComponent();
        }

        private void labelCyanit_Click(object sender, EventArgs e)
        {
            // Create a new instance of the FrmAbout class
            FrmAbout About = new FrmAbout();

            // Show the About form
            About.ShowDialog();
        }
    }
}
