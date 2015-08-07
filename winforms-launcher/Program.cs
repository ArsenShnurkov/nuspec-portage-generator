using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace WinFormsGUI
{

	static class Program
	{
		static ApplicationContext aContext;
		static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			var form = new MainMenuForm ();
			aContext = new ApplicationContext (form);
			Application.Run(aContext);
		}
		public static WinFormsGUI.MainMenuForm GetMainForm()
		{
			var form = (WinFormsGUI.MainMenuForm)aContext.MainForm;
			return form;
		}
	}
}
