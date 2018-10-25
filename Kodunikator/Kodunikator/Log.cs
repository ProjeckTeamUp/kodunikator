using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kodunikator
{
    /// <summary>
    /// Tworzenie logów.
    /// </summary>
    static class Log
    {
        private static string logFileName = "Logs.txt"; // nazwa pliku z logami

        /// <summary>
        /// Tworzy nowy log.
        /// </summary>
        /// <param name="text"> Tekst logu. </param>
        public static void NewLog(string text)
        {
            var date = DateTime.UtcNow.ToLocalTime();
            using (StreamWriter file =
            new StreamWriter(logFileName, true))
            {
                file.WriteLine(date + " | " + text);
            }
        }

        /// <summary>
        /// Tworzy nowy log błędu.
        /// </summary>
        /// <param name="text"> Treśc błędu. </param>
        public static void NewError(string text = "")
        {
            var date = DateTime.UtcNow.ToLocalTime();
            using (StreamWriter file =
            new StreamWriter(logFileName, true))
            {
                file.WriteLine(date + " [ERROR] " + text);
            }
        }

        /// <summary>
        /// Usuwa wszystkie logi.
        /// </summary>
        public static void Clear()
        {
            File.Create(logFileName).Close();
        }
    }
}
