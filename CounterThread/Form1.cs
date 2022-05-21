using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace CounterThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bThreadStatus = false;
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CounterThread = new Thread(new ThreadStart(ThreadCounter));
            CounterThread.Start();
            bThreadStatus = true;
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CounterThread.Suspend(); // Pauses the Thread
        }

        private void resumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CounterThread.Resume();  // Resumes the Thread
        }

        public void ThreadCounter()
        {
            long iCounter = 0;
            try
            {
                while(true)
                {
                    iCounter++;
                    labelCounter.Invoke(new MethodInvoker(delegate { labelCounter.Text = iCounter.ToString(); }));
                    labelCounter.Text = iCounter.ToString();
                    Thread.Sleep(1000);
                }
            }
            catch ( Exception ex)
            {

            }
        }
    }
}
