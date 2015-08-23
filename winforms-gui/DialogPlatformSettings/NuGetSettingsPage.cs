using System.Drawing;

namespace WinFormsGUI
{
    internal partial class NuGetSettingsPage : PropertyPage
    {
        public NuGetSettingsPage()
        {
            InitializeComponent();
        }

        public override string Title
        {
            get { return "NuGet Settings"; }
        }

        public override Image Image
        {
			get { return new Bitmap(GetType(), "Resources.Bitmaps.NuGetSettingsPage.bmp"); }
        }
    }
}