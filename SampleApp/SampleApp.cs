using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract1SampleApp
{
    public partial class SampleApp : Form
    {
        public SampleApp()
        {
            InitializeComponent();
        }

        private void buttonreadcontent_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TextBoxContent.Text);
        }
    }
}
