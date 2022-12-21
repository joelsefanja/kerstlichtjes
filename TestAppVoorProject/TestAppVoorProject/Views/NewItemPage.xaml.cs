using System;
using System.Collections.Generic;
using System.ComponentModel;
using TestAppVoorProject.Models;
using TestAppVoorProject.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestAppVoorProject.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}