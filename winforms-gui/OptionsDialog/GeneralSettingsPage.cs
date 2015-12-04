using System.Drawing;

namespace NuspecPortageGenerator
{
    internal partial class GeneralSettingsPage : PropertyPage
    {
		public GeneralSettingsPage()
        {
            InitializeComponent();
			this.ebuildPath.Text = OptionsDialogSettings.Default.EbuildLocation;
			this.nuspecPath.Text = OptionsDialogSettings.Default.NupkgLocation;
        }

		public override void OnApply()
		{
			OptionsDialogSettings.Default.EbuildLocation = this.ebuildPath.Text;
			OptionsDialogSettings.Default.NupkgLocation = this.nuspecPath.Text;
		}

        public override string Title
        {
			get { return "General Settings"; }
        }

        public override Image Image
        {
			get { return new Bitmap(GetType(), "Resources.Bitmaps.GeneralSettingsPage.bmp"); }
        }
    }
}