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

namespace NuspecPortageGenerator
{
	public partial class MainMenuForm : Form
	{
		public MainMenuForm()
		{
			InitializeComponent();
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
	}
}
