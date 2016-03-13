using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace NuspecPortageGenerator
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
		public static MainMenuForm GetMainForm()
		{
			var form = (MainMenuForm)aContext.MainForm;
			return form;
		}
	}
}

/*
var drives = Directory.GetLogicalDrives ();
foreach (var drive in drives)
{
	Trace.WriteLine (drive);
	Console.WriteLine (drive);
}

/
/mnt/LIFE
/var/lib/entropy/client/packages
/var/calculate
/home
/mnt/mail
/mnt/gentoo
/run/user/1000/gvfs
/var/run/user/1000/gvfs
/boot
/root/.gvfs
*/
