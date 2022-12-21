using System.ComponentModel;
using TestAppVoorProject.ViewModels;
using Xamarin.Forms;

namespace TestAppVoorProject.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}