using Práctica_7_Triggers.Vistas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Práctica_7_Triggers
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Categoria());
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
