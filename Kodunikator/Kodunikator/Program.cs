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
		public static string username;

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
			logForm = new LogForm();
            Application.Run(logForm);
        }

		/// <summary>
		/// Odpalenie aplikacji po zalogowaniu
		/// </summary>
		public static void StartKodunikator(List<Friend> friends)
		{
		    mainForm = new MainForm(friends);
			logForm.SuccessLogin();
			mainForm.FormClosing += delegate { logForm.Close(); };
			logForm.Hide();
			mainForm.Show();
		}

        /// <summary>
        /// Nieudane zalogowanie do aplikacji
        /// </summary>
        /// <param name="errorMessage"></param>
        public static void UnseuccessLogin(string errorMessage)
        {
            logForm.UnseuccessLogin(errorMessage);
        }

        /// <summary>
        /// Wylogowanie z aplikacji (żeby zalogować się na inne konto)
        /// </summary>
        public static void LogOut()
		{
			logForm.Location = mainForm.Location;
			logForm.StartPosition = FormStartPosition.Manual;
			mainForm.Hide();
			mainForm.Close();
            logForm.Show();          
		}
    }
}
