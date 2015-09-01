using System;
using System.Windows.Forms;
using Mono.WebBrowser;
using System.Diagnostics;

namespace WinFormsGUI
{
	public partial class WebBrowserControl : UserControl
	{
		IWebBrowser browser;

		public WebBrowserControl ()
		{
			InitializeComponent ();
			try
			{
				browser = Mono.WebBrowser.Manager.GetNewInstance(Mono.WebBrowser.Platform.Winforms);
			}
			catch (System.Exception ex) {
				Trace.WriteLine (ex.ToString ());
				throw;
			}
		}


		private void WebBrowserControl_Load(object sender, System.EventArgs e)
		{
			try {
				// 1. libgluezilla not found. To have webbrowser support, you need libgluezilla installed
				// http://askubuntu.com/questions/164218/what-is-mozilla-xpcom-and-how-i-install-it-on-ubuntu
				// 2. checking Mozilla XPCOM > 1.8... not found
				// checking Mozilla XPCOM 1.8... You need to install the Mozilla XPCOM development package.
				this.SuspendLayout ();
				browser.Load (this.Handle, 500, 250);
				browser.Navigation.Go ("http://google.com/");
			} catch (System.Exception ex) {
				Trace.WriteLine (ex.ToString ());
			}
		}
	}
}
