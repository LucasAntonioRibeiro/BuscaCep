using BuscaCep.Models;
using Newtonsoft.Json;
namespace BuscaCep.Services
{
    public class DataServices
    {
        public static async Task<Endereco> GetEnderecoAsync (string cep)
        {
            Endereco end;

            using (HttpClient client = new HttpClient())
            {
                string url = "Http://cep.metoda.com.br/endereco/by-cep?cep=" + cep;
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                }
            }
        }
    }
}
