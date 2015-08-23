using System.Drawing;

namespace WinFormsGUI
{
    internal partial class GeneralSettingsPage : PropertyPage
    {
		public GeneralSettingsPage()
        {
            InitializeComponent();
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