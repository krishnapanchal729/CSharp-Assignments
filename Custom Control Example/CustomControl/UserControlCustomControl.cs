using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl
{
    public partial class UserControlCustomControl: UserControl
    {
        public UserControlCustomControl()
        {
            InitializeComponent();
        }

        private void buttonSayHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Custom Control Hello from Krishna");
        }
    }
}
