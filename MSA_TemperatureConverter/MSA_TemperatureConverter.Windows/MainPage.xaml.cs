using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MSA_TemperatureConverter
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        TempCalculation Temp = new TempCalculation();
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void GetTempConversion(object sender, RoutedEventArgs e)
        {
            //Pass Textbox value to the input value for my calculation class
            Temp.DblInput = Convert.ToDouble(TxtInput.Text);

            if (CbFahToCel.IsChecked.HasValue && CbFahToCel.IsChecked.Value )
            {
                //Output conversion result for Celsius rounding up to 2 decimal points
               TextBlockOutput.Text = String.Format("{0} Fahrenheit is equal to {1} Celsius", Temp.DblInput, Temp.DblCel.ToString("F1"));

               //Display text colour of output according to temperature 
               if (Temp.DblCel < 20)
               {
                   TextBlockOutput.Foreground = new SolidColorBrush(Colors.Blue);
               }
               else
               {
                   TextBlockOutput.Foreground = new SolidColorBrush(Colors.Red);
               }
                
               
            }
            else if (CbCelToFah.IsChecked.HasValue && CbCelToFah.IsChecked.Value)
            {
                //Output conversion result for Farenheit rounding up to 2 decimal points
                TextBlockOutput.Text = String.Format("{0} Celsius is equal to {1} Fahrenheit", Temp.DblInput, Temp.DblFah.ToString("F1"));

                //Display text colour of output according to temperature 
                if (Temp.DblFah < 68)
                {
                    TextBlockOutput.Foreground = new SolidColorBrush(Colors.Blue);
                }
                else
                {
                    TextBlockOutput.Foreground = new SolidColorBrush(Colors.Red);
                }
               
            }
            
        }

        private void UncheckCelCb(object sender, RoutedEventArgs e)
        {
            //sets Celsius checkbox value to unchecked
            CbCelToFah.IsChecked = false;
        }

        private void UncheckedFahCb(object sender, RoutedEventArgs e)
        {
            //Sets Farhenheit checkbox value to unchecked
            CbFahToCel.IsChecked = false;
        }
    }
}
