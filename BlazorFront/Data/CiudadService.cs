using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace BlazorFront.Data
{
    public class CiudadService
    {
        public async Task<List<CiudadModelo>> CrudCiudad(CiudadModelo c)
        {
            List<CiudadModelo> result = new List<CiudadModelo>();
            HttpClient _httpClient = new HttpClient();
            string responseData = "";
            try
            {
                var myContent = JsonConvert.SerializeObject(c);
                var stringContent = new StringContent(myContent, System.Text.Encoding.UTF8, "application/json");
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", c.Token);
                HttpResponseMessage apiResponse = await _httpClient.PostAsync("https://localhost:44317/api/Ciudad/lista", stringContent);
                if (apiResponse.Content != null)
                {
                    responseData = await apiResponse.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<List<CiudadModelo>>(responseData);
                }
            }
            catch (Exception e) { throw e; }
            return result;
        }

        public async Task<TokenSession> Autenticacion()
        {
            TokenSession result = new TokenSession();
            HttpClient _httpClient = new HttpClient();
            string responseData = "";
            try
            {
                HttpResponseMessage apiResponse = await _httpClient.GetAsync("https://localhost:44317/api/Authentication/token");
                if (apiResponse.Content != null)
                {
                    responseData = await apiResponse.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<TokenSession>(responseData);
                }
            }
            catch (Exception e) { throw e; }
            return result;
        }
    }
}
