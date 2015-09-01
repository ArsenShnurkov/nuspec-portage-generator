using System;
using System.Diagnostics;
using System.Text;
using System.Web;
using System.IO;
using System.Web.Hosting;

namespace TemplateEngine
{
	public class MyExeHost : MarshalByRefObject
	{
		readonly string category = "TemplateEngine";
		public string ProcessRequest(String page, String query)
		{
			try
			{
				var message = string.Format("page is '{0}'", page);
				Trace.WriteLine(message, category);
				var target = new StringBuilder(4096);
				using (var stream = new StringWriter(target))
				{
					//public SimpleWorkerRequest(
					//	string appVirtualDir,
					//	string appPhysicalDir,
					//	string page,
				    //	string query,
					//	TextWriter output
					//)
					HttpWorkerRequest hwr = new SimpleWorkerRequest(page, query, stream);
					HttpRuntime.ProcessRequest(hwr);
					stream.Flush();
				} 
				string targetString = target.ToString();
				Trace.WriteLine(targetString, category);
				return targetString; 
			}
			catch (Exception ex)
			{
				Trace.WriteLine(ex.ToString(), "TemplateEngine");
				return ex.ToString();
			}
		}

		/// <returns>null = object creates once and stays forever</returns>
		public override object InitializeLifetimeService()
		{
			return null;
		}
	}
}

