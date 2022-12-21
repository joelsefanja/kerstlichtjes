using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.GTKSpecific;
using Xamarin.Forms.Xaml;

namespace TestAppVoorProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RGBPage : ContentPage
    {
        public RGBPage()
        {
            InitializeComponent();
            double redValue = RedSlider.Value;
            double greenValue = GreenSlider.Value;
            double blueValue = BlueSlider.Value;

            RedLabel.Text = String.Format("Red = 00");
            GreenLabel.Text = String.Format("Green = 00");
            BlueLabel.Text = String.Format("Blue = 00");


            const string redSlider = "#d10202";
            const string redThumb = "#c23a3a";

            RedSlider.MaximumTrackColor = Color.FromHex(redSlider);
            RedSlider.MinimumTrackColor = Color.FromHex(redSlider);
            RedSlider.ThumbColor = Color.FromHex(redThumb);

            const string greenSlider = "#02b305";
            const string greenThumb = "#c23a3a";

            GreenSlider.MaximumTrackColor = Color.FromHex(greenSlider);
            GreenSlider.MinimumTrackColor = Color.FromHex(greenSlider);
            GreenSlider.ThumbColor = Color.FromHex(greenThumb);

            const string blueSlider = "#020ae3";
            const string blueThumb = "#c23a3a";

            BlueSlider.MaximumTrackColor = Color.FromHex(blueSlider);
            BlueSlider.MinimumTrackColor = Color.FromHex(blueSlider);
            BlueSlider.ThumbColor = Color.FromHex(blueThumb);
            

        }

        private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (sender == RedSlider)
            {
                RedLabel.Text = String.Format("Red = {0:X2}", (int)e.NewValue);
            }
            else if (sender == GreenSlider)
            {
                GreenLabel.Text = String.Format("Green = {0:X2}", (int)e.NewValue);
            }
            else if (sender == BlueSlider)
            {
                BlueLabel.Text = String.Format("Blue = {0:X2}", (int)e.NewValue);
            }

            boxView.Color = Color.FromRgb((int)RedSlider.Value,
                                          (int)GreenSlider.Value,
                                          (int)BlueSlider.Value);
            
        }
    }
}