﻿using fbchat_sharp.API;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kodunikator
{
	public partial class MainForm : Form, FbMessageListener 
	{
        private List<Friend> friends; // Lista przyjaciół i ich danych
        private Friend currentFriend = null; // Aktualnie wybrany przyjaciel
        private List<FB_Thread> threads; // wątki rozmów konta facebook

        ToolBar toolBar;

		private ContextMenuStrip friendsListContextMenu;

        public MainForm() { }

		public MainForm(List<Friend> _friends)
		{
			InitializeComponent();
			main_username_sign.Text = Program.username;
			toolBar = new ToolBar();
			ToolBarButton toolBarBtnAddFriend = new ToolBarButton();

			//TODO: toolbar rozciągniety w wysokości

			// Set the Text properties of the ToolBarButton controls.
			toolBarBtnAddFriend.Text = "Friends";

			// Add the ToolBarButton controls to the ToolBar.
			toolBar.Buttons.Add(toolBarBtnAddFriend);

			// Add the event-handler delegate.
			toolBar.ButtonClick += new ToolBarButtonClickEventHandler(
			   this.toolBar_ButtonClick);

			// Add the ToolBar to the Form.
			Controls.Add(toolBar);

            friends = _friends;
        }

        private void toolBar_ButtonClick(Object sender, ToolBarButtonClickEventArgs e)
        {
            // Evaluate the Button property to determine which button was clicked.
            switch (toolBar.Buttons.IndexOf(e.Button))
            {
                case 0:
					OpenAddFriendForm();
					break;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
		{
			foreach(Friend x in friends)
			{
				friends_list.Items.Add(x.nickname);
			}
			if (friends.Count != 0)
			{
				currentFriend = friends[0];
				friends_list.SelectedIndex = 0;
			}
			friendsListContextMenu = new ContextMenuStrip();
			friendsListContextMenu.Items.Add("Delete");
			friendsListContextMenu.ItemClicked += FriendsListContextMenu_ItemClicked;
			friendsListContextMenu.Opening += new CancelEventHandler(friendsListContextMenu_Opening);
			friends_list.ContextMenuStrip = friendsListContextMenu;
			Facebook.MessageListener = this;            
		}

		private void FriendsListContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			//TODO: tą łączenie się z bazą trzeba zrobić w leprzy sposób
			DBConnection dbcon = new DBConnection();
			dbcon.Connect();
			switch (e.ClickedItem.Text)
			{
				case "Delete":
					friends.Remove(friends[friends_list.SelectedIndex]);
					dbcon.deleteFriend(friends);
					friends_list.Items.Clear();
					foreach (Friend x in friends)
					{
						friends_list.Items.Add(x.nickname);
					}
					if (friends.Count > 0)
					{
						selectFriend(0);
						friends_list.SelectedIndex = 0;
					}
					else
					{
						message_feild.Clear();
						conversation_view.Items.Clear();
						currentFriend = null;
					}
					break;
			}
		}

		#region Interface

		private void conversation_view_View_DrawItem(object sender, DrawItemEventArgs e)
		{
			if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
			{
				e = new DrawItemEventArgs(e.Graphics, e.Font, e.Bounds,
					e.Index, e.State ^ DrawItemState.Selected, e.ForeColor, SystemColors.Control);
			}

			if (e.Index != -1)
			{
				e.DrawBackground();
				var dataItem = conversation_view.Items[e.Index] as Tuple<string, string>;
				var nameFont = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
				e.Graphics.DrawString(dataItem.Item1, nameFont, Brushes.Black, e.Bounds.Left + 3, e.Bounds.Top + 5);
				var msgFont = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular);
				e.Graphics.DrawString(dataItem.Item2, msgFont, Brushes.Black, e.Bounds.Left + 30, e.Bounds.Top + 18);

				var linePen = new Pen(SystemBrushes.Control);
				var lineStartPoint = new Point(e.Bounds.Left, e.Bounds.Height + e.Bounds.Top - 1);
				var lineEndPoint = new Point(e.Bounds.Width, e.Bounds.Height + e.Bounds.Top - 1);

				e.Graphics.DrawLine(linePen, lineStartPoint, lineEndPoint);
			}
		}

		private void conversation_view_MeasureItem(object sender, MeasureItemEventArgs e)
		{
			e.ItemHeight = 20 * GetLinesNumber((Tuple<string, string>)conversation_view.Items[e.Index]);
		}

		private void friends_list_MouseDown(object sender, MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Right)
			{
				friends_list.SelectedIndex = friends_list.IndexFromPoint(e.Location);
				if (friends_list.SelectedIndex != -1)
				{
					friendsListContextMenu.Show();
				}
			}
		}

		private void friendsListContextMenu_Opening(object sender, CancelEventArgs e)
		{
			//onCreate contextList
		}


		private void friends_list_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void friends_list_View_DrawItem(object sender, DrawItemEventArgs e)
		{
			if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
			{
				e = new DrawItemEventArgs(e.Graphics, e.Font, e.Bounds,
					e.Index, e.State ^ DrawItemState.Selected, e.ForeColor, SystemColors.ControlDark);
				selectFriend(e.Index);
			}

			e.DrawBackground();
            if (friends.Count > 0 && e.Index != -1)
            {
                var dataItem = friends_list.Items[e.Index] as string;
                var nameFont = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
                e.Graphics.DrawString(dataItem, nameFont, Brushes.Black, e.Bounds.Left + 3, e.Bounds.Top + 3);
            }
		}

		/// <summary>
		/// Liczy w zwraca ilość linijek w wiadomości
		/// </summary>
		private int GetLinesNumber(Tuple<string, string> text)
		{
			int count = 1;
			int pos = 0;
			if (text.Item2.Contains("\r\n"))
			{
				while ((pos = text.Item2.IndexOf("\r\n", pos)) != -1) { count++; pos += 2; }
				return 1 + count;
			}
			else
				return 2;
		}

		private void conversation_view_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// Wysyła wiadomość
		/// </summary>
		private void send_btn_Click(object sender, EventArgs e)
		{
			if (Control.ModifierKeys == Keys.Shift)
			{
				message_feild.AppendText(Environment.NewLine);
			}
			else if (message_feild.Text != "") //TODO: nie wysyłać pustych akapitów
			{
				conversation_view.Items.Add(new Tuple<string, string>(Program.username, message_feild.Text));
                Facebook.SendMessage(message_feild.Text, currentFriend.fbID);
				message_feild.Clear();
			}
		}

        private void OpenAddFriendForm()
        {
            AddFriend addFriend = new AddFriend(this);
            addFriend.Show();
        }

		/// <summary>
		/// Zaznacza znajomego w widoku, i ładuje rozmowę z nim (TODO)
		/// </summary>
		private void selectFriend(int index)
		{
			if (currentFriend != friends[index])
			{
				currentFriend = friends[index];
				message_feild.Clear();
				conversation_view.Items.Clear();
				LoadMessages();
			}
		}

		/// <summary>
		/// Dodaje nowego przyjaciela do widoku.
		/// Wywoływane z AddFriend form.
		/// </summary>
		public void AddFriendFormResult(List<Friend> _friends)
		{
			friends = _friends;
			friends_list.Items.Clear();
			foreach (Friend x in friends)
			{
				friends_list.Items.Add(x.nickname);
			}
			if(friends.Count == 1)
			{
				selectFriend(0);
			}
			friends_list.SelectedIndex = friends.Count - 1;
		}

		/// <summary>
		/// Ładuje nową wiadomość do widoku
		/// </summary>
		public void messageArrived(FB_Message msg)
		{
			if (!msg.is_from_me && isKodunikatorsMassege(msg.text))
			{
				if (msg.author.Equals(currentFriend.fbID))
				{
					conversation_view.Invoke(new Action(() => conversation_view.Items.Add(new Tuple<string, string>(currentFriend.nickname, msg.text))));
				}
			}
		}

		#endregion

        /// <summary>
        /// Ładuje wiadomości z aktualnie otworzonym przyjacielem
        /// </summary>
        public async void LoadMessages(int amount = 100)
        {
            Log.NewLog("Ładowanie wątków rozmów...");
            threads = await Facebook.LoadThreads();

            for (int i = 0; i < threads.Count; i++)
            {
                if(threads[i].uid == currentFriend.fbID)
                {
                    Log.NewLog("Znaleziono wątek rozmowy z aktualnym przyjacielem.");

                    List<FB_Message> messages = await Facebook.LoadMessages(currentFriend.fbID, amount);

                    for(int j=messages.Count-1; j>0; j--)
                    {
                        if (isKodunikatorsMassege(messages[j].text))
                            conversation_view.Invoke(new Action(() => conversation_view.Items.Add(new Tuple<string, string>(MessagesAuthor(messages[j].author), messages[j].text.Substring(13)))));
                    }
                }
            }
        }

		/// <summary>
		///	Sprawdza czy wiadomość jest Kodunikatorowa
		/// </summary>
		private bool isKodunikatorsMassege(string msg)
		{
			if (msg.Length > 4)
				return msg.Substring(0, 5) == "#Kodu";

			return false;
		}

		/// <summary>
		/// Zwraca nazwę autora wiadomości
		/// </summary>
		public string MessagesAuthor(string uid)
        {
            if (uid.Equals(currentFriend.fbID))
                return currentFriend.nickname;
             return Program.username;
        }


    }
}
