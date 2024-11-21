using System;
using Microsoft.Maui.Controls;

namespace ShareStreamApp
{
    public partial class NewPage1 : ContentPage
    {
        private int netflixCount = 0;
        private decimal totalPrice = 0m;

        public NewPage1()
        {
            InitializeComponent();
        }

        private void IncreaseNetflix(object sender, EventArgs e)
        {
            netflixCount++;
            UpdateNetflixPrice();
        }

        private void DecreaseNetflix(object sender, EventArgs e)
        {
            if (netflixCount > 0)
                netflixCount--;
            UpdateNetflixPrice();
        }

        private void UpdateNetflixPrice()
        {
            decimal pricePerUnit = 10.99m; // Ejemplo: precio por cuenta
            decimal total = netflixCount * pricePerUnit;
            NetflixQuantity.Text = netflixCount.ToString();
            NetflixPrice.Text = $"${total:F2}";
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            totalPrice = netflixCount * 10.99m; // Ajusta si hay más servicios
            TotalPriceLabel.Text = $"Total: ${totalPrice:F2}";
        }

        


        private async void OnPayButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewPage2());
        }
    }
}