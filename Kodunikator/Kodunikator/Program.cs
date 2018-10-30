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
        private static FBLogin fbLogin = null;

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
		public static void StartKodunikator()
		{
            mainForm = new MainForm();
            mainForm.Show();
            fbLogin.Hide();
            fbLogin.Close();          
		}

        /// <summary>
        /// Logowanie do konta facebook
        /// </summary>
        public static void LoginToFb()
        {
            fbLogin = new FBLogin();
            fbLogin.Show();
            logForm.Hide();
        }


		/// <summary>
		/// Wylogowanie z aplikacji (żeby zalogować się na inne konto)
		/// </summary>
		public static void LogOut()
		{
            mainForm.Hide();
			mainForm.Close();
            logForm.Show();          
		}
    }
}
