using System;
using System.Reflection;
using System.IO;
using System.Web.Hosting;
using System.Web;

namespace TemplateEngine
{
	public abstract class TemplateEngine
	{
		public static string GetPhysicalRoot()
		{
			return GetPhysicalRoot ("aspnet_templates");
		}
		public static string GetPhysicalRoot(string subdir)
		{
			string loc = Assembly.GetEntryAssembly().Location;
			var fi = new FileInfo(loc);
			var res = Path.Combine (fi.DirectoryName, subdir);
			return res;
		}
		public static string GetVirtualRoot()
		{
			var res = new string (Path.DirectorySeparatorChar, 1);
			return res;
		}
	}

	class TemplateEngine1 : TemplateEngine
	{
		public static string ProcessRequest(string fileName, string query)
		{
			using (var te = new DomainHolder(GetVirtualRoot(), GetPhysicalRoot()))
			{
				MyExeHost myHost = (MyExeHost)te.CreateProxy(typeof(MyExeHost));
				string res = myHost.ProcessRequest(fileName, query);
				return res;
			}
		}
	}

	/// <summary>
	/// Uses standart way to launch engine
	/// </summary>
	/// <remarks>>
	/// usage example:
	/// TemplateEngine2.ProcessRequest("text1.aspx", "a=1&b=2&c=3");
	/// </remarks>
	public class TemplateEngine2 : TemplateEngine
	{
		static MyExeHost myHost = null;

		public static MyExeHost MyExeHost {
			get { 
				if (myHost == null)
				{
					myHost = (MyExeHost)ApplicationHost.CreateApplicationHost(typeof(MyExeHost), GetVirtualRoot(), GetPhysicalRoot());
				} 
				return myHost;
			}
		}

		public static string ProcessRequest(string fileName, string query)
		{
			string res = MyExeHost.ProcessRequest(fileName, query);
			return res;
		}
	}
	// http://stackoverflow.com/questions/3236909/using-applicationhost-createapplicationhost-to-create-an-asp-net-post-while-l
}

