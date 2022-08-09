using System;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;
using System.Collections.Generic;
using MySpectrumApp.Constants;
using MySpectrumApp.Models;
using Newtonsoft.Json;

namespace MySpectrumApp.Services
{
    public class RestService: IRestService
    {
        HttpClient client;
        JsonSerializerOptions serializerOptions;

        public Data Items { get; private set; }

        public RestService()
        {
            client = new HttpClient();
            serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }

        public async Task<Data> BitcoinLimitsAsynczz()
        {
            Items = new Data();
            Uri uri = new Uri(RestURI.RestUrl_GetCurrencyLimits);

            try
            {
                HttpResponseMessage response = await client.GetAsync(uri).ConfigureAwait(false);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    dynamic data = JsonConvert.DeserializeObject(content);
                    //dynamic data = JsonSerializer.Deserialize<List<BitcoinInfo>>(content); 
                    //Items = output;
                    //string dd = JsonSerializer.Deserialize<string>(content, serializerOptions);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return Items;
        }

        public async Task<Data> BitcoinLimitsAsync()
        {
            Root rt = new Root();
            Data  _data = new Data();
            Uri uri = new Uri(RestURI.RestUrl_GetCurrencyLimits);
            try
            {
                HttpResponseMessage response = await client.GetAsync(uri).ConfigureAwait(false);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    dynamic data = JsonConvert.DeserializeObject(content);
                    rt = JsonConvert.DeserializeObject<Root>(content);
                    _data = rt.data;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return _data;
        }

        public async Task<string>BitcoinLimitsAsync2()
        {
            Root rt = new Root();
            Data _data = new Data();
            string content = string.Empty;
            Uri uri = new Uri(RestURI.RestUrl_GetCurrencyLimits);
            try
            {
                HttpResponseMessage response = await client.GetAsync(uri).ConfigureAwait(false);
                if (response.IsSuccessStatusCode)
                {
                    content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    dynamic data = JsonConvert.DeserializeObject(content);
                    rt = JsonConvert.DeserializeObject<Root>(content);
                    _data = rt.data;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return content;
        }
    }
}
