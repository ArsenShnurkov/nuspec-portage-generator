using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System;


namespace WinFormsGUI
{
	public partial class EbuildPropertiesControl : UserControl
	{
		string _Uri = String.Empty;
		public string Uri
		{
			get
			{ 
				if (this.textboxRepositoryUrl != null) {
					return this.textboxRepositoryUrl.Text;
				}
				return _Uri;
			}
			set
			{
				if (this.textboxRepositoryUrl != null) {
					this.textboxRepositoryUrl.Text = value;
				} else {
					_Uri = value;
				}
			}
		}
		string _Sha1 = String.Empty;
		public string Sha1
		{
			get
			{ 
				if (this.textboxSha1 != null) {
					return this.textboxSha1.Text;
				}
				return _Sha1;
			}
			set
			{
				if (this.textboxSha1 != null) {
					this.textboxSha1.Text = value;
				} else {
					_Sha1 = value;
				}
			}
		}
		string _EbuildCategory = String.Empty;
		public string EbuildCategory
		{
			get
			{ 
				if (this.textboxEbuildCategory != null) {
					return this.textboxEbuildCategory.Text;
				}
				return _EbuildCategory;
			}
			set
			{
				if (this.textboxEbuildCategory != null) {
					this.textboxEbuildCategory.Text = value;
				} else {
					_EbuildCategory = value;
				}
			}
		}
		string _EbuildName = String.Empty;
		public string EbuildName
		{
			get
			{ 
				if (this.textboxEbuildName != null) {
					return this.textboxEbuildName.Text;
				}
				return _EbuildName;
			}
			set
			{
				if (this.textboxEbuildName != null) {
					this.textboxEbuildName.Text = value;
				} else {
					_EbuildName = value;
				}
			}
		}

		public EbuildPropertiesControl ()
		{
			InitializeComponent();
			// fill values after construction of controls
			this.textboxRepositoryUrl.Text = _Uri;
			this.textboxSha1.Text = _Sha1;
			this.textboxEbuildCategory.Text = _EbuildCategory;
			this.textboxEbuildName.Text = _EbuildName;
		}
	}
}

