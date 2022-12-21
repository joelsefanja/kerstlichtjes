using System;
using System.Collections.Generic;
using TestAppVoorProject.ViewModels;
using TestAppVoorProject.Views;
using Xamarin.Forms;

namespace TestAppVoorProject
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(RGBPage), typeof(RGBPage));
            Routing.RegisterRoute(nameof(LichtEffecten), typeof(LichtEffecten));
            Routing.RegisterRoute(nameof(Settings), typeof(Settings));


        }

    }
}
