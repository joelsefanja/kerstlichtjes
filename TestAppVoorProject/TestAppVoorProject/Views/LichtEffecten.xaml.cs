using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestAppVoorProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LichtEffecten : ContentPage
    {
        public bool strobe_stand = false;
        public bool fade_stand = false;
        public bool disco_stand = false;

        

        const string green = "#02b305";
        
        public LichtEffecten()
        {
            InitializeComponent();
            
        }

        async void Strobe_Clicked(object sender, EventArgs e)
        {
            bool antwoord = await DisplayAlert("Alert", "Wil je het licht effect veranderen?", "Ja", "Nee");

            if (antwoord == true)
            {
                Strobe.BackgroundColor = Color.FromHex("#B7E4C7");
                Fade.BackgroundColor = Color.FromHex("#40916C");
                Disco.BackgroundColor = Color.FromHex("#40916C");

                strobe_stand = true;
                fade_stand = false;
                disco_stand = false;
            }
        }
        async void Fade_Clicked(object sender, EventArgs e)
        {
            bool antwoord = await DisplayAlert("Alert", "Wil je het licht effect veranderen?", "Ja", "Nee");

            if (antwoord == true)
            {
                Fade.BackgroundColor = Color.FromHex("#B7E4C7");
                Strobe.BackgroundColor = Color.FromHex("#40916C");
                Disco.BackgroundColor = Color.FromHex("#40916C");

                strobe_stand = false;
                fade_stand = true;
                disco_stand = false;
            }
        }
        async void Disco_Clicked(object sender, EventArgs e)
        {
            bool antwoord = await DisplayAlert("Alert", "Wil je het licht effect veranderen?", "Ja", "Nee");

            if (antwoord == true)
            {
                Disco.BackgroundColor = Color.FromHex("#B7E4C7");
                Strobe.BackgroundColor = Color.FromHex("#40916C");
                Fade.BackgroundColor = Color.FromHex("#40916C");

                strobe_stand = false;
                fade_stand = false;
                disco_stand = true;
            }
        }


    }
}