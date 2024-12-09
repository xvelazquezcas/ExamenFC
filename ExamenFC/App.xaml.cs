
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenFC
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Vista.Menuprincipal());

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
