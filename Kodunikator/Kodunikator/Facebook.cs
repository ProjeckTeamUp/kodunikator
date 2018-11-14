﻿using System;
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

        /// <summary>
        /// Logowanie do konta facebook. Zwraca 'true' dla udanego logowania.
        /// </summary>
        public static async Task<bool> LogIn(string mail, string password)
        {
            fb_client = new FBClient();
            var logged_in = await fb_client.DoLogin(mail, password);
            if (logged_in)
            {
                Log.NewLog("Poprawnie zalogowano do kota facebook.");
                Log.NewLog(GetFacebookID());
                return true;
            }
            else
            {
                Log.NewError("Błąd logowania do konta facebook.");
                return false;
            }
        }

        /// <summary>
        /// Zwraca FB ID aktualnie zalogowanego konta
        /// </summary>
        public static string GetFacebookID()
        {           
            return fb_client.GetUserUid();
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
        /// Zwraca imię i nazwisko z konta facebook
        /// </summary>
		public static string GetName()
		{
			if(fb_client != null)
			{
                // return ...
			}
			return "";
		}

        /// <summary>
        /// Wysyłanie wiadomości.
        /// </summary>
        /// <param name="text"> Tekst wiadomości. </param>
        /// <param name="id"> ID konta facebook odbiorcy wiadomości. </param>
        /// <param name="type"> 0 - klasyczna wiadomośc tekstowa. 1 - wiadomość w postaci kodu źródłowego. </param>
        public static async Task SendMessage(string text, string id, int type=0)
        {
            string message = "#Koduniaktor\n";
            if (type == 1)
                message += "#Code";
            message += text;

            var msg_uid = await fb_client.SendMessage(message, thread_id: id);
        }
    }
}
