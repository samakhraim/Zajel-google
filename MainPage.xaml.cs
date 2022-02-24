using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var Url = "https://www.najah.edu/ar/";
            Browser.Source = Url;
        }



        private void google_Clicked(object sender, EventArgs e)
        {
            var Url = "http://www.google.com/";
            Browser.Source = Url;
        }

        private void zajel_Clicked(object sender, EventArgs e)
        {
            var Url = "https://zajel.najah.edu/";
            Browser.Source = Url;
        }
    }



}
