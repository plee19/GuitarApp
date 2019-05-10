using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GuitarApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ChordsPage : ContentPage
	{
		public ChordsPage ()
		{
			InitializeComponent ();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            chordList.ItemsSource = await App.Database.GetChordsAsync();
        }

        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e == null) return; // has been set to null, do not 'process' tapped event
            ChordDataService service = new ChordDataService();
            await Navigation.PushAsync(new ChordPage((e.SelectedItem as Chord).ChordName));
        }
    }
}