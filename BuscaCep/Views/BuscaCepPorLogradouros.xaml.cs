using Busca_Cep.Services;
using BuscaCep.Models;

namespace BuscaCep.Views;

public partial class BuscaCepPorLogradouros : ContentPage
{
	public BuscaCepPorLogradouros()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Carregando.IsRunning = true;

			List<Cep> arr_ceps = await DataServices.GetCepsByLogradouro(txt_logradouro.Text);
			lst_ceps.ItemsSource = arr_ceps;
        }
		catch (Exception ex)
		{
			await DisplayAlert("Ops", ex.Message, "OK");
        }
		finally
		{
			Carregando.IsRunning = false;
		}
    }
}