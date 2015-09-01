using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections;

namespace WinFormsGUI
{

	//public interface INotifyPropertyChanged
	//{
	//	event PropertyChangedEventHandler PropertyChanged;
	//}
	//namespace System.ComponentModel
	//{
	//	[HostProtection (SharedState = true)]
	//	public delegate void PropertyChangedEventHandler (object sender, PropertyChangedEventArgs e);
	//}
	public class FileBrowserModel : INotifyPropertyChanged
	{
		public FileBrowserModel ()
		{
		}

		private string eclassName;
		public string EclassName
		{
			get
			{
				return eclassName;
			}
			set
			{
				if (EqualityComparer<string>.Default.Equals (eclassName, value)) {
					return;
				}
				eclassName = value;
				OnPropertyChanged(new PropertyChangedEventArgs("EclassName"));
			}
		}
		private string ebuildName;
		public string EbuildName
		{
			get
			{
				return ebuildName;
			}
			set
			{
				if (EqualityComparer<string>.Default.Equals (ebuildName, value)) {
					return;
				}
				ebuildName = value;
				OnPropertyChanged(new PropertyChangedEventArgs("EbuildName"));
			}
		}

		#region INotifyPropertyChanged implementation

		public event PropertyChangedEventHandler PropertyChanged;
/*		event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged {
			add {
				throw new NotImplementedException ();
			}
			remove {
				throw new NotImplementedException ();
			}
		}
*/		
		protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
		{
			if(PropertyChanged != null)
			{
				PropertyChanged(this, e);
			}
		}
		#endregion
	}
}

