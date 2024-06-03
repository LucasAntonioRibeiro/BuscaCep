using Busca_Cep.Services;
using BuscaCep.Models;

namespace BuscaCep
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try { 
                List<Bairro> arr_bairro = await DataServices.GetBairrosAsyncByIdCidaded(4874);
        }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }
        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                Endereco dados_endereco = await DataServices.GetEnderecoByCep(txt_cep.Text);
                BindingContext = dados_endereco;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }

}
