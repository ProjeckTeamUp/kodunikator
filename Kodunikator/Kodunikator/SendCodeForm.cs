using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kodunikator
{
	public partial class SendCodeForm : Form
	{
		string directory;
		List<string> files;
		SendCodeListener sendListener;

		public SendCodeForm(SendCodeListener sendListener)
		{
			InitializeComponent();
			directory = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\code_files";
			if (!System.IO.Directory.Exists(directory))
			{
				System.IO.Directory.CreateDirectory(directory);
			}
			files = System.IO.Directory.EnumerateFiles(directory).ToList();
			for (int i = 0; i < files.Count; i++)
			{
				files[i] = files[i].Replace(directory + "\\", "");
			}
			this.sendListener = sendListener;
			code_file_name_box.Items.AddRange(files.ToArray());
		}

		/// <summary>
		/// Sprawdza dane, i wysyła do zapisania i wysłania
		/// </summary>
		private void save_and_send_btn_Click(object sender, EventArgs e)
		{
			if (code_file_name_box.Text.Equals(String.Empty))
			{
				save_code_error_msg.Text = "Enter name of the file!";
				save_code_error_msg.Visible = true;
				return;
			}
			if (code_file_name_box.Text.Contains('.'))
			{
				if (code_file_name_box.Text.Split('.')[0].Equals(String.Empty))
				{
					save_code_error_msg.Text = "Incorrect filename!";
					save_code_error_msg.Visible = true;
					return;
				}
				if (!code_file_name_box.Text.Split('.')[1].Equals(String.Empty))
				{
					if (files.Contains(code_file_name_box.Text))
					{
						using (StreamReader file = new StreamReader(directory + "\\" + code_file_name_box.Text))
						{
							sendListener.sendCode(code_file_name_box.Text, file.ReadToEnd());
						}
					}
					else
					{
						sendListener.sendCode(code_file_name_box.Text);
					}
					this.Hide();
					return;
				}
			}
			save_code_error_msg.Text = "No extension of the file given!";
			save_code_error_msg.Visible = true;
		}

		/// <summary>
		/// Zapisuje do pliku kod
		/// </summary>
		public void saveToFile(string title, string code)
		{
			using (StreamWriter file =new StreamWriter(directory + "\\" + title, false))
			{
				file.WriteLine(code);
			}
			files.Add(title);
		}

		/// <summary>
		/// Otwiera plik
		/// </summary>
		internal void openFile(string codeTitle)
		{
			Process.Start(directory + "\\" + codeTitle);
		}
	}
}
