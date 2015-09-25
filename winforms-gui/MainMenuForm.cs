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
		private TextEditorControl AddEbuildTab()
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

					return control;
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
			consoleControl.ShowDiagnostics = true;
			consoleControl.FirstActivation += init_control;

			consoleTabPage.Text = "Default console";
			consoleTabPage.Controls.Add (consoleControl);

			//consoleControl.StartProcess ("/usr/bin/script", "-c '/bin/bash -i'");
			//consoleControl.StartProcess ("/usr/bin/screen", "-l '/bin/bash -i'");
			//consoleControl.StartProcess ("/usr/bin/screen", "");
			consoleControl.IsInputEnabled = true;
			consoleControl.SendKeyboardCommandsToProcess = true;

			consoleTabPage.Controls.Add (consoleControl);

			this.tabControl1.TabPages.Add(consoleTabPage);

		}
		private void init_control(object sender, EventArgs e)
		{
			var consoleControl = sender as ConsoleControlAPI.ConsoleControl;
			consoleControl.WriteOutput ("---", Color.Blue);
			consoleControl.ClearOutput ();
			// http://www.gnu.org/software/bash/manual/html_node/Invoking-Bash.html
			// -i
			// If the -i option is present, the shell is interactive. 
			// 
			//consoleControl.StartProcess ("/bin/bash", "-i +m"); 
			consoleControl.StartProcess ("/bin/bash", "-i"); 
		}

		private void AddFileBrowserTab()
		{
			var tabPage = new System.Windows.Forms.TabPage();
			var control = new FileBrowserControl();

			control.Dock = DockStyle.Fill;

			tabPage.Text = "Ebuild files";
			tabPage.Controls.Add (control);
			this.tabControl1.TabPages.Add(tabPage);
		}
		private void AddWebBrowserTab()
		{
			var tabPage = new System.Windows.Forms.TabPage();
			var control = new WebBrowserControl();

			control.Dock = DockStyle.Fill;

			tabPage.Text = "WebBrowser";
			tabPage.Controls.Add (control);

			this.tabControl1.TabPages.Add(tabPage);
		}
		private void NonImplemented_Click(object sender, EventArgs e)
		{
		}

		private void EbuildProperties_Click(object sender, EventArgs e)
		{
			AddConsoleTab ();

			var dlg = new DialogEbuildProperties ();
			dlg.StartPosition = FormStartPosition.CenterParent;
			var res = dlg.ShowDialog(this);
			if (res == DialogResult.OK) {
				var editor = AddEbuildTab(); // TextEditorControl
				editor.GenerateEbuildText (dlg.Uri, dlg.Sha1, dlg.EbuildCategory, dlg.EbuildName);
			}
		}
		private void editSettings_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				var dlg = new OptionsDialog();
				dlg.StartPosition = FormStartPosition.CenterParent;
				dlg.Pages.Add(new GeneralSettingsPage());
				dlg.Pages.Add(new PortageSettingsPage());
				dlg.Pages.Add(new LaymanSettingsPage());
				dlg.Pages.Add(new NuGetSettingsPage());
				var res = dlg.ShowDialog(this);
				if (res == DialogResult.OK) {
					
				}
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
