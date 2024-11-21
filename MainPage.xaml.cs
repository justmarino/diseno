using System;
using Microsoft.Maui.Controls;

namespace ShareStreamApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            // Validación básica
            await Navigation.PushAsync(new NewPage1());
        }
    }
}