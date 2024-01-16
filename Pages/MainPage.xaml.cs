namespace IzinApp.Pages;
using Microsoft.Maui.Controls;


public partial class MainPage : ContentPage
{


	public MainPage()
	{
        InitializeComponent();

	}

    async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
    }
}


