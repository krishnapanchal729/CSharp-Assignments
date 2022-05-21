using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleInterestExample
{
    public partial class SimpleInterestForm : Form
    {
        public SimpleInterestForm()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Calculate()
        {
            //Calculate total by retrieving values from ctrls
            double dTotal = Convert.ToDouble(textBoxPrinciple.Text) + Convert.ToDouble(textBoxNoOfMonths.Text) * Convert.ToDouble(textBoxInterest.Text);
            textBoxTotal.Text = dTotal.ToString();

        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
