using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Butica_Andrei_Lab12v1.Data;

namespace Butica_Andrei_Lab12v1
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }

        public App()
        {
            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
