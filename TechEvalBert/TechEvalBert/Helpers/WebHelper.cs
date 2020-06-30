using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace TechEvalBert.Helpers
{
    public class WebHelper
    {
        private string apiURL = "";
        static readonly HttpClient cliente = new HttpClient();
        public WebHelper(string apiURL)
        {
            this.apiURL = apiURL;
        }

        public async Task<string> GetResponse()
        {
            try
            {
                HttpResponseMessage response = await cliente.GetAsync(apiURL);
                response.EnsureSuccessStatusCode();
                string respuesta = await response.Content.ReadAsStringAsync();
                return respuesta;
            }
            catch (HttpRequestException e)
            {                
                throw new Exception($"Fallo en la llamada a {apiURL}");
            }
        }
    }
}
