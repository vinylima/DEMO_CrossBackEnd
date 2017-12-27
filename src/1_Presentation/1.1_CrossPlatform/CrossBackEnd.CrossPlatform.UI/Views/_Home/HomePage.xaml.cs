﻿
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using CrossBackEnd.CrossPlatform.UI.Views.GeoLocation;

namespace CrossBackEnd.CrossPlatform.UI.Views._Home
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
        public HomePage()
        {
            InitializeComponent();

            txtCountries.Clicked += this.TxtCountries_Clicked;
        }

        private void TxtCountries_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new CountryPage());
            
        }
    }
}