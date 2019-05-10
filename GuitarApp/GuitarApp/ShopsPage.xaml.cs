using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GuitarApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ShopsPage : ContentPage
	{
		public ShopsPage ()
		{
			InitializeComponent ();
		}

        public void ShopOneOnClicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://www.kraftmusic.com"));
        }

        public void ShopTwoOnClicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://www.guitarcenter.com"));
        }

        public void ShopThreeOnClicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://www.interstatemusic.com"));
        }
    }
}