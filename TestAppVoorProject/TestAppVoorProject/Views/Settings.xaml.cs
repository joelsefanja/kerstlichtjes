using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestAppVoorProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Settings : ContentPage
    {
        
        public Settings()
        {
            InitializeComponent();

        }
        
        
        async void Beweging_Toggled(object sender, ToggledEventArgs e)
        {
            // Bewegings.IsToggled

            bool antwoord = await DisplayAlert("Alert", "Wil je de Bewegings sensor aan/uit wilt zetten?", "Ja", "Nee");
            if (antwoord == true)
            {
                /* App.automatisch = true; */

                //TODO De bewegings sensor aanzetten

            }
            if (antwoord == false)
            {
                App.automatisch = false;
                App.wastrue = false;

                

                Beweging.IsToggled = !Beweging.IsToggled;

                

            }

            //if (Beweging.IsToggled == true /* && App.automatisch == true */)
            //{
                
            //    bool antwoord = await DisplayAlert("Alert", "Wil je de Bewegings sensor aanzetten?", "Ja", "Nee");
            //    if (antwoord == true)
            //    {
            //        /* App.automatisch = true; */
                    
            //        //TODO De bewegings sensor aanzetten

            //    }
            //    if (antwoord == false)
            //    {
            //        App.automatisch = false;
            //        App.wastrue = false;
                    
            //        Beweging.IsToggled = false;
                    
                    
            //    }
            //        //Hij set istoggled eerst op false, dan gaat hij de rest van de code af waardoor de 2de niet kan en vervolgens gaan de bools weer true en gaat hij weer terug naar istoggled = false en dan doet hij het 2de stuk code.
            //}
            
            //if (App.automatisch == true && App.wastrue == true) //Hier moet iets komen waardoor de app niet andersom een error geeft
            //{
            //    if (Beweging.IsToggled == false)
            //    {
            //        bool antwoordnegatief = await DisplayAlert("Alert", "Wil je de Bewegings sensor uitzetten?", "Ja", "Nee");

            //        if (antwoordnegatief == true)
            //        {
            //            //TODO De bewegings sensor aanzetten
            //            App.automatisch = true;
                    


            //        }
            //        if (antwoordnegatief == false)
            //        {
            //            //TODO De bewegings sensor aanzetten
            //            App.automatisch = false;
                        
            //            Beweging.IsToggled = true;
            //            //Iedere keer doet hij de methode opnieuw wnr je zegt dat IsToggled true is
                    
            //        }
            //    }
            //}

            //if (App.automatisch == false)
            //{
            //    App.automatisch = true;
            //    App.wastrue = true;
                
            //}
            
        }

        async void Licht_Toggled(object sender, ToggledEventArgs e)
        {
            if (Licht.IsToggled == true)
            {
                //TODO De licht sensor aanzetten
                bool antwoord = await DisplayAlert("Alert", "Wil je de Licht sensor aanzetten?", "Ja", "Nee");
                if (antwoord == true)
                {

                }
                else
                {
                    Licht.IsToggled = false;
                }
            }
        }

        async void Audio_Toggled(object sender, ToggledEventArgs e)
        {
            if (Audio.IsToggled == true)
            {
                //TODO De audio sensor/microfoon aanzetten
                bool antwoord = await DisplayAlert("Alert", "Wil je de Audio sensor aanzetten?", "Ja", "Nee");
                if (antwoord == true)
                {

                }
                else
                {
                    Audio.IsToggled = false;
                }
            }
        }

        async void Infrarood_Toggled(object sender, ToggledEventArgs e)
        {
            if (Infrarood.IsToggled == true)
            {
                //TODO De Infrarood sensor aanzetten
                bool antwoord = await DisplayAlert("Alert", "Wil je de Infrarood sensor aanzetten?", "Ja", "Nee");
                if (antwoord == true)
                {

                }
                else
                {
                    Infrarood.IsToggled = false;
                }
            }
        }
    }
}