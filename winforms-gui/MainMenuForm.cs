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
using ConsoleControlAPI;
using ICSharpCode.TextEditor;

namespace WinFormsGUI
{
	public partial class MainMenuForm : Form
	{
		public MainMenuForm()
		{
			InitializeComponent();
			AddEbuildTab ();
			// AddConsoleTab ();
			UpdateUIState ();
		}
		private void AddEbuildTab()
		{
			this.tabControl1.SuspendLayout();
			try
			{
				var tabPage = new System.Windows.Forms.TabPage();
				tabPage.SuspendLayout();
				try
				{
					var control = new TextEditorControl();

					control.Dock = DockStyle.Fill;

					//control.Text = "Default text";
					tabPage.Controls.Add (control);
					tabPage.Text = "somefile.ebuild";

					this.tabControl1.TabPages.Add(tabPage);
				}
				finally
				{
					tabPage.ResumeLayout(true);
				}
			}
			finally {
				this.tabControl1.ResumeLayout (true);
				//this.tabControl1.PerformLayout ();
			}
		}
		private void AddConsoleTab()
		{

			var consoleTabPage = new System.Windows.Forms.TabPage();
			var consoleControl = new ConsoleControlAPI.ConsoleControl();

			consoleControl.Dock = DockStyle.Fill;

			consoleTabPage.Text = "Default console";
			consoleTabPage.Controls.Add (consoleControl);

			// http://www.gnu.org/software/bash/manual/html_node/Invoking-Bash.html
			consoleControl.ClearOutput ();
			consoleControl.StartProcess ("/bin/bash", "-i +m"); 
			consoleControl.IsInputEnabled = true;
			consoleControl.SendKeyboardCommandsToProcess = true;


			consoleTabPage.Controls.Add (consoleControl);

			this.tabControl1.TabPages.Add(consoleTabPage);
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
				Trace.WriteLine (ex.ToString ());
			}
		}
		/// <summary>
		/// Updates the state of the UI.
		/// </summary>
		private void UpdateUIState()
		{
			var tab = this.tabControl1.SelectedTab;
			var control = tab.Controls [0];
			if (control is ConsoleControl) {
				var consoleControl = control as ConsoleControl;
				//  Update the state.
				if (consoleControl.IsProcessRunning)
					toolStripStatusLabel1.Text = "Running " + System.IO.Path.GetFileName (consoleControl.ProcessInterface.ProcessFileName);
				else
					toolStripStatusLabel1.Text = "Not Running";
				//  Update toolbar buttons
			}
		}
	}
}
