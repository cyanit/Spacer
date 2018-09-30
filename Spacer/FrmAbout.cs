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
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void btnGithub_Click(object sender, EventArgs e)
        {
            //Open Github in default Webbrowser
            System.Diagnostics.Process.Start("https://github.com/cyanit/Spacer");
        }

        private void btnTwitter_Click(object sender, EventArgs e)
        {
            //Open Twitter in default Webbrowser
            System.Diagnostics.Process.Start("https://twitter.com/cyanitofficial");
        }
    }
}
