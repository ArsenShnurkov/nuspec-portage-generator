using System.Drawing;

namespace WinFormsGUI
{
    internal partial class PortageSettingsPage : PropertyPage
    {
        public PortageSettingsPage()
        {
            InitializeComponent();
        }

        public override string Title
        {
            get { return "Portage Settings"; }
        }

        public override Image Image
        {
			get { return new Bitmap(GetType(), "Resources.Bitmaps.PortageSettingsPage.bmp"); }
        }
    }
}