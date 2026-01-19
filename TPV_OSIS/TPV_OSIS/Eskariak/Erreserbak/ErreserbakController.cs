using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;

namespace TPV_OSIS.Eskariak
{
    internal class ErreserbakController
    {
        private readonly string _baseUrl = "http://localhost:5000/";

        
        // API-tik erreserba guztiak lortzea
        public List<Erreserbak> LortuErreserbak()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);

                
                var response = client.GetAsync("api/Erreserbak").Result;

                if (!response.IsSuccessStatusCode)
                    return new List<Erreserbak>();

                var json = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<List<Erreserbak>>(json);
            }
        }

        
        // API bidez Erreserbak sortzea
        public bool SortuErreserba(Erreserbak erreserba)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);

                var json = JsonConvert.SerializeObject(erreserba);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var response = client.PostAsync("api/Erreserbak", content).Result;

                return response.IsSuccessStatusCode;
            }
        }

       
        // Erreserba ezabatu Id-aren arabera
        public bool EzabatuErreserba(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);

                var response = client.DeleteAsync($"api/Erreserbak/{id}").Result;

                return response.IsSuccessStatusCode;
            }
        }
    }
}
