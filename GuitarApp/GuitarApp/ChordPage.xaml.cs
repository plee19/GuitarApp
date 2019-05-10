using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GuitarApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChordPage : ContentPage
    {
        string chordName; 

        public ChordPage(string chordName)
        {
            InitializeComponent();
            this.chordName = chordName;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            ChordDataService service = new ChordDataService();
            RootObject result = await service.GetChord(chordName);
            Debug.Write(result.Objects);
            BindingContext = result.Objects[0];
        }
    }
}