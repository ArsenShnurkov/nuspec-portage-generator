using System;
using System.IO;
using System.Diagnostics;
using System.Web;
using System.Runtime.Remoting;
using System.Globalization;

namespace TemplateEngine
{
	class DomainHolder : IDisposable
	{
		protected AppDomain ad;

		public DomainHolder(string virtualDir, string physicalDir)
		{
			string slash = Path.DirectorySeparatorChar.ToString();
			if (physicalDir.EndsWith(slash) == false)
			{
				physicalDir = physicalDir + slash;
			}
			Trace.WriteLine(string.Format("Physical Dir is '{0}'", physicalDir), "TemplateEngine");

			AppDomainSetup setup = new AppDomainSetup();

			string appName = (virtualDir + physicalDir).GetHashCode().ToString("x");
			setup.ApplicationName = appName;
			Trace.WriteLine(string.Format("appName is '{0}'", appName), "TemplateEngine");

			//setup.ConfigurationFile = "web.config"; // not necessary except for debugging

			string domainId = DateTime.Now.ToString(DateTimeFormatInfo.InvariantInfo).GetHashCode().ToString("x");
			Trace.WriteLine(string.Format("domainID is '{0}'", domainId), "TemplateEngine");

			ad = AppDomain.CreateDomain(domainId, /*System.Security.Policy.Evidence*/null, /* AppDomainSetup */setup);
			ad.SetData(".appDomain", "*");
			ad.SetData(".appPath", physicalDir);
			ad.SetData(".appVPath", virtualDir);

			ad.SetData(".domainId", domainId);

			ad.SetData(".hostingVirtualPath", virtualDir);
			Trace.WriteLine(string.Format("virtualDir is '{0}'", virtualDir), "TemplateEngine");

			string hostingInstallDir = HttpRuntime.AspInstallDirectory;
			ad.SetData(".hostingInstallDir", hostingInstallDir);
			Trace.WriteLine(string.Format("aspDir is '{0}'", hostingInstallDir), "TemplateEngine");
		}

		void IDisposable.Dispose()
		{
			AppDomain.Unload(ad);
		}

		public object CreateProxy(Type hostType)
		{
			ObjectHandle oh = ad.CreateInstance(hostType.Module.Assembly.FullName, hostType.FullName);
			return oh.Unwrap();
		}
	}
}

