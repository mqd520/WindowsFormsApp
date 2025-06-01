using System.Windows.Forms;

using log4net;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private readonly ILog _log = LogManager.GetLogger(typeof(Form1));

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            _log.Info("Form1 is loading...");
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            _log.Debug("Debug button clicked.");
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            _log.Info("Info button clicked.");
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            _log.Warn("Warn button clicked.");
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            _log.Error("Error button clicked.");
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            _log.Fatal("Fatal button clicked.");
        }
    }
}
