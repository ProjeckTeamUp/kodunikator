using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using fbchat_sharp.API;

namespace Kodunikator
{
    /// <summary>
    /// Zapewnia komunikacje między użytkownikami. Wysyłanie i wczytywanie wiadomości.
    /// </summary>
    static class Facebook
    {
        private class FBClient : MessengerClient
        {
            protected override async Task DeleteCookiesAsync()
            {
                await Task.Yield();
            }
            protected override async Task<List<Cookie>> ReadCookiesFromDiskAsync()
            {
                await Task.Yield();
                return null;
            }
            protected override async Task WriteCookiesToDiskAsync(List<Cookie> cookieJar)
            {
                await Task.Yield();
            }
            protected override string on2FACode()
            {
                throw new NotImplementedException();
            }
        } static FBClient fb_client; // Klient konta użytkownika na facebooku

        private const string loginFile = "fbLogin.txt"; // Nazwa pliku z danymi do logowania do facebooka.

        /// <summary>
        /// Zapisuje hasło i adres email do konta facebook w pliku.
        /// </summary>
        /// <param name="mail"> Adres email konta facebook. </param>
        /// <param name="password"> Hasło do konta facebook. </param>
        public static void SaveMailPassword(string mail, string password)
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(loginFile, true))
            {
                file.WriteLine(mail);
                file.WriteLine(password);
            }
        }

        /// <summary>
        /// Wczytuje wartość adresu email i hasła do konta facebook z pliku. Login i hasło zwraca w formie tablicy 'string'.
        /// </summary>
        private static string[] ReadMailPassword()
        {
            string[] tmp = new string[2];
            using (System.IO.StreamReader file =
            new System.IO.StreamReader(loginFile))
            {
                tmp[0] = file.ReadLine();
                tmp[1] = file.ReadLine();
            }

            return tmp;
        }

        /// <summary>
        /// Określa czy są zapisane dane do stałego logowania do konta facebook. Zwraca 'true' jeśli tak.
        /// </summary>
        public static bool IsPermamentLogin()
        {
            if (System.IO.File.Exists(loginFile))
                return true;
            return false;
        }

        /// <summary>
        /// Logowanie do konta facebook. Zwraca 'true' dla udanego logowania.
        /// </summary>
        public static async Task<bool> LogIn(string mail = null, string password = null)
        {
            if(mail == null || password == null)
            {
                string[] tmp = ReadMailPassword();
                mail = tmp[0];
                password = tmp[1];
            }

            fb_client = new FBClient();
            var logged_in = await fb_client.DoLogin(mail, password);
            if (logged_in)
            {
                Log.NewLog("Poprawnie zalogowano do kota facebook.");
                return true;
            }
            else
            {
                Log.NewError("Błąd logowania do konta facebook.");
                return false;
            }
        }

        /// <summary>
        /// Wylogowanie z konta facebook.
        /// </summary>
        public static void LogOut()
        {
            if (fb_client != null)
            {
                fb_client.DoLogout();
                Log.NewLog("Wylogowano z konta facebook.");
            }
            fb_client = null;
        }

        /// <summary>
        /// Wysyłanie wiadomości.
        /// </summary>
        /// <param name="text"> Tekst wiadomości. </param>
        /// <param name="id"> ID konta facebook odbiorcy wiadomości. </param>
        public static async Task SendMessage(string text, string id)
        {
            var msg_uid = await fb_client.SendMessage(text, thread_id: id);
        }
    }
}
