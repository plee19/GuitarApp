using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace GuitarApp
{
    public partial class App : Application
    {
        public static ChordDatabase database;

        public App()
        {
            
            InitializeComponent();

            MainPage = new MainPage();
        }

        public static ChordDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new ChordDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TodoSQLite.db3"));
                }
                return database;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
