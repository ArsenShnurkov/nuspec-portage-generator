using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Diagnostics;

namespace WinFormsGUI
{
	public partial class MainMenuForm : Form
	{
		public MainMenuForm()
		{
			InitializeComponent();
			Trace.WriteLine (saveFileDialog1.FileName);

			// http://www.gnu.org/software/bash/manual/html_node/Invoking-Bash.html
			consoleControl.ClearOutput ();
			consoleControl.StartProcess ("/bin/bash", "-i"); 
			consoleControl.IsInputEnabled = true;
			consoleControl.SendKeyboardCommandsToProcess = true;
			UpdateUIState ();
		}
		private void NonImplemented_Click(object sender, EventArgs e)
		{
		}
		private void editSettings_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
			var dlg = new OptionsDialog();
			dlg.Pages.Add(new GeneralSettingsPage());
			dlg.Pages.Add(new PortageSettingsPage());
			dlg.Pages.Add(new LaymanSettingsPage());
			dlg.Pages.Add(new NuGetSettingsPage());
			dlg.ShowDialog(this);
			}
			catch (Exception ex)
			{
				Debug.WriteLine (ex.ToString ());
			}
		}
		/// <summary>
		/// Updates the state of the UI.
		/// </summary>
		private void UpdateUIState()
		{
			//  Update the state.
			if (consoleControl.IsProcessRunning)
				toolStripStatusLabel1.Text = "Running " + System.IO.Path.GetFileName(consoleControl.ProcessInterface.ProcessFileName);
			else
				toolStripStatusLabel1.Text = "Not Running";

			//  Update toolbar buttons
		}
	}
}
