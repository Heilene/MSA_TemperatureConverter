using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace MSA_TemperatureConverter
{
    class TempCalculation
    {
        //==============Fields==================

        private double _dblFah;
        private double _dblCel;
       

        //==============Properties==============
        public double DblInput { get; set; }
        public ImageBrush MyBackGroundImage { get; set; }

        public double DblCel
        {
            get
            {
              //calculate celsius conversion returns celsius value
                _dblCel = (DblInput - 32) * 5 / 9;
                return _dblCel;

            } 
        }

        public double DblFah
        {
            get
            {
                //calculate fahrenheit conversion returns fahrenheit conversion
                _dblFah = DblInput*9/5 + 32;
                return _dblFah;
            }
        }



    }
}
