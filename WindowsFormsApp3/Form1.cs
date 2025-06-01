using System;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            AppendText("Button1 clicked");
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            var thread = new Thread(() =>
            {
                AppendText("Button2 clicked");
            });
            thread.Start();
        }

        private void AppendText(string text)
        {
            if (textBox1.InvokeRequired)
            {
                textBox1.Invoke(new MethodInvoker(() =>
                {
                    InternalAppendText(text);
                }));
            }
            else
            {
                InternalAppendText(text);
            }
        }

        private void InternalAppendText(string text)
        {
            textBox1.AppendText(string.Format("[{0}] {1}{2}"
                , DateTime.Now.ToString("yyyyy-MM-dd HH:mm:ss fff")
                , text
                , Environment.NewLine));
        }
    }
}
