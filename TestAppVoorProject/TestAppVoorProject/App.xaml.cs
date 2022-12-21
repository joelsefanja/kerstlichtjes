using System;
using TestAppVoorProject.Services;
using TestAppVoorProject.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestAppVoorProject
{
    public partial class App : Application
    {
        public static bool automatisch = true;
        public static bool wastrue = true;

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            //MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            base.OnStart();
            MainPage = new ConnectPage();
            
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
