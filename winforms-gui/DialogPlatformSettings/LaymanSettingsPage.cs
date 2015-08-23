using System.Drawing;

namespace WinFormsGUI
{
    internal partial class LaymanSettingsPage : PropertyPage
    {
		public LaymanSettingsPage()
        {
            InitializeComponent();
        }

        public override string Title
        {
            get { return "Layman Settings"; }
        }

        public override Image Image
        {
			get { return new Bitmap(GetType(), "Resources.Bitmaps.LaymanSettingsPage.bmp"); }
        }
    }
}