using System;
using System.Windows.Forms;

using log4net;

namespace WindowsFormsApp2
{
    internal static class Program
    {
        private static readonly ILog _log = LogManager.GetLogger(typeof(Program));

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            _log.Info("Application is starting...");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
