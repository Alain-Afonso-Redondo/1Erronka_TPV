using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;


namespace TPV_OSIS.Eskariak
{
    internal class FakturakController
    {
        private readonly string _baseUrl = "http://localhost:5000/";

        
        // API-tik faktura guztiak lortzea
        public List<Fakturak> LortuFakturak()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);

                
                var response = client.GetAsync("api/Fakturak").Result;

                if (!response.IsSuccessStatusCode)
                    return new List<Fakturak>();

                var json = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<List<Fakturak>>(json);
            }
        }

        
        // Faktura lortze Id-aren arabera
        public Fakturak LortuFaktura(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);

                var response = client.GetAsync($"api/Fakturak/{id}").Result;

                if (!response.IsSuccessStatusCode)
                    return null;

                var json = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<Fakturak>(json);
            }
        }

       // Faktura berria sortzea
        public bool SortuFaktura(Fakturak faktura)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);

                var json = JsonConvert.SerializeObject(faktura);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var response = client.PostAsync("api/Fakturak", content).Result;

                return response.IsSuccessStatusCode;
            }
        }

        
        // Faktura ezabatzea Id-aren arabera
        public bool EzabatuFaktura(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);

                var response = client.DeleteAsync($"api/Fakturak/{id}").Result;

                return response.IsSuccessStatusCode;
            }
        }
        // Eguneratu Faktura Id-aren arabera
        public bool EguneratuTotala(int fakturaId, double gehikuntza)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);

                var body = new
                {
                    FakturaId = fakturaId,
                    Gehikuntza = gehikuntza
                };

                var json = JsonConvert.SerializeObject(body);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                
                var response = client.PostAsync("api/Fakturak/eguneratu-totala", content).Result;

                return response.IsSuccessStatusCode;
            }
        }

    }
}
