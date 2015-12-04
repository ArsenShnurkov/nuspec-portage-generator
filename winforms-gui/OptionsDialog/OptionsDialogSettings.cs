using System;

namespace NuspecPortageGenerator
{
	internal sealed partial class OptionsDialogSettings : global::System.Configuration.ApplicationSettingsBase
	{
		private static OptionsDialogSettings defaultInstance = 
			((OptionsDialogSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized (new OptionsDialogSettings ())));

		public static OptionsDialogSettings Default {
			get {
				return defaultInstance;
			}
		}

		[global::System.Configuration.UserScopedSettingAttribute ()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute ()]
		public string EbuildLocation {
			get {
				return ((string)(this ["EbuildLocation"]));
			}
			set {
				this ["EbuildLocation"] = value;
			}
		}

		[global::System.Configuration.UserScopedSettingAttribute ()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute ()]
		public string NupkgLocation {
			get {
				return ((string)(this ["NupkgLocation"]));
			}
			set {
				this ["NupkgLocation"] = value;
			}
		}
	}
}

