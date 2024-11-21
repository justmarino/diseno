namespace ShareStreamApp;

public partial class NewPage2 : ContentPage
{
    public NewPage2()
    {
        InitializeComponent();
    }

    private async void OnConfirmButtonClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Éxito", "Pago confirmado correctamente", "OK");
        await Navigation.PopToRootAsync(); // Vuelve a la pantalla inicial
    }
}
