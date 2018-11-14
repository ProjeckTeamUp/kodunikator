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
	public partial class MainForm : Form
	{
		private IList messages;

        private List<Friend> friends; // Lista przyjaciół i ich danych
        private Friend currentFriend = null; // Aktualnie wybrany przyjaciel

        public MainForm() { }

		public MainForm(List<Friend> _friends)
		{
			InitializeComponent();
			main_username_sign.Text = Program.username;
			ToolBar toolBar1 = new ToolBar();
			ToolBarButton toolBarButton1 = new ToolBarButton();
			ToolBarButton toolBarButton2 = new ToolBarButton();
			ToolBarButton toolBarButton3 = new ToolBarButton();

			//TODO: toolbar rozciągniety w wysokości

			// Set the Text properties of the ToolBarButton controls.
			toolBarButton1.Text = "Tu";
			toolBarButton2.Text = "Będą";
			toolBarButton3.Text = "Przyciski";

			// Add the ToolBarButton controls to the ToolBar.
			toolBar1.Buttons.Add(toolBarButton1);
			toolBar1.Buttons.Add(toolBarButton2);
			toolBar1.Buttons.Add(toolBarButton3);

			// Add the event-handler delegate.
			/*toolBar1.ButtonClick += new ToolBarButtonClickEventHandler(
			   this.toolBar1_ButtonClick);*/

			// Add the ToolBar to the Form.
			Controls.Add(toolBar1);

            friends = _friends;
            currentFriend = new Friend("Aleks", "100004033446947"); // DEL
        }

		private void MainForm_Load(object sender, EventArgs e)
		{
			friends_list.Items.Add("test");
		}

        #region Interface

        private void conversation_view_View_DrawItem(object sender, DrawItemEventArgs e)
		{

			if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
			{
				e = new DrawItemEventArgs(e.Graphics, e.Font, e.Bounds,
					e.Index, e.State ^ DrawItemState.Selected, e.ForeColor, SystemColors.Control);
			}
			
			e.DrawBackground();
			var dataItem = conversation_view.Items[e.Index] as Tuple<string, string>;
			var nameFont = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
			e.Graphics.DrawString(dataItem.Item1, nameFont, Brushes.Black, e.Bounds.Left + 3, e.Bounds.Top + 5);
			var msgFont = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular);
			e.Graphics.DrawString(dataItem.Item2, msgFont, Brushes.Black, e.Bounds.Left + 30, e.Bounds.Top + 18);

			var linePen = new Pen(SystemBrushes.Control);
			var lineStartPoint = new Point(e.Bounds.Left, e.Bounds.Height + e.Bounds.Top -1);
			var lineEndPoint = new Point(e.Bounds.Width, e.Bounds.Height + e.Bounds.Top -1);

			e.Graphics.DrawLine(linePen, lineStartPoint, lineEndPoint);
		}

		private void conversation_view_MeasureItem(object sender, MeasureItemEventArgs e)
		{
			e.ItemHeight = 20 * GetLinesNumber((Tuple<string, string>)conversation_view.Items[e.Index]);
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
			}

			e.DrawBackground();
			var dataItem = friends_list.Items[e.Index] as string;
			var nameFont = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
			e.Graphics.DrawString(dataItem, nameFont, Brushes.Black, e.Bounds.Left + 3, e.Bounds.Top + 3);
		}

		private int GetLinesNumber(Tuple<string, string> text)
		{
			int count = 1;
			int pos = 0;
			while ((pos = text.Item2.IndexOf("\r\n", pos)) != -1) { count++; pos += 2; }
			return 1 + count;
		}

		private void conversation_view_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

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

        #endregion


    }
}
