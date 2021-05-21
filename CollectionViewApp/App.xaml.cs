using System;
using CollectionViewApp.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MyHomePage());
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
