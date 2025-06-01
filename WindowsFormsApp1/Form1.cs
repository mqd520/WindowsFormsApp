using System;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new Exception("This is a test exception from button1_Click.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var thread = new System.Threading.Thread(() =>
            {
                Thread.Sleep(1000);
                throw new Exception("This is a test exception from a thread.");
            });
            thread.Start();
        }
    }
}
