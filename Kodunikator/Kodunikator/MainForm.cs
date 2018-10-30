using System;
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
		public MainForm()
		{
			InitializeComponent();
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
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}
	}
}
