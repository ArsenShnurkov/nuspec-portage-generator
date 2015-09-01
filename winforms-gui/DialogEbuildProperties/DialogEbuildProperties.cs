using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System;

namespace WinFormsGUI
{
    public partial class DialogEbuildProperties : Form
    {
		string _Uri = String.Empty;
		public string Uri
		{
			get
			{ 
				if (this.userControlClassAndName != null) {
					return this.userControlClassAndName.Uri;
				}
				return _Uri;
			}
			set
			{
				if (this.userControlClassAndName != null) {
					this.userControlClassAndName.Uri = value;
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
				if (this.userControlClassAndName != null) {
					return this.userControlClassAndName.Sha1;
				}
				return _Sha1;
			}
			set
			{
				if (this.userControlClassAndName != null) {
					this.userControlClassAndName.Sha1 = value;
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
				if (this.userControlClassAndName != null) {
					return this.userControlClassAndName.EbuildCategory;
				}
				return _EbuildCategory;
			}
			set
			{
				if (this.userControlClassAndName != null) {
					this.userControlClassAndName.EbuildCategory = value;
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
				if (this.userControlClassAndName != null) {
					return this.userControlClassAndName.EbuildName;
				}
				return _EbuildName;
			}
			set
			{
				if (this.userControlClassAndName != null) {
					this.userControlClassAndName.EbuildName = value;
				} else {
					_EbuildName = value;
				}
			}
		}

		public DialogEbuildProperties()
        {
            InitializeComponent();
			this.userControlClassAndName.Uri = Uri;
			this.userControlClassAndName.Sha1 = Sha1;
			this.userControlClassAndName.EbuildCategory = EbuildCategory;
			this.userControlClassAndName.EbuildName = EbuildName;
        }

		EbuildPropertiesSettings settings = new EbuildPropertiesSettings();

        private void OptionsDialog_Load(object sender, System.EventArgs e)
        {
			try
			{
				settings.LoadFromDisk ();
			}
			catch (Exception ex)
			{
				Trace.WriteLine (ex.ToString ());
			}
        }

        private void okButton_Click(object sender, System.EventArgs e)
        {
        }
    }
}
