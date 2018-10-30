using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kodunikator
{
    static class Program
    {

		private static MainForm mainForm = null;
		private static LogForm logForm = null;
		/// <summary>
		/// Główny punkt wejścia dla aplikacji.
		/// </summary>
		[STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
			mainForm = new MainForm();
			logForm = new LogForm();
            Application.Run(logForm);
        }

		/// <summary>
		/// Odpalenie aplikacji po zalogowaniu
		/// </summary>
		public static void StartKodunikator()
		{
			mainForm.Location = logForm.Location;
			mainForm.StartPosition = FormStartPosition.Manual;
			mainForm.FormClosing += delegate { logForm.Close(); };
			logForm.Hide();
			mainForm.Show();
		}


		/// <summary>
		/// Wylogowanie z aplikacji (żeby zalogować się na inne konto)
		/// </summary>
		public static void StartLogin()
		{
			logForm.Location = mainForm.Location;
			logForm.StartPosition = FormStartPosition.Manual;
			mainForm.Close();
			logForm.Show();
		}
    }
}
