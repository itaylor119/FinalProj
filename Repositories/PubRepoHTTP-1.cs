using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

Add these NuGet packages: 
System.Net.Http
Microsoft.AspNet.WebApi.Client

Sources:
https://www.pragimtech.com/blog/blazor/delete-in-asp.net-core-rest-api/

 */

using System.Net.Http;
using System.Net.Http.Headers;

namespace Repositories
{
    public class PubRepoHTTP : IRepository<Model.Publisher>
    {
        string _uriBase;

        public PubRepoHTTP(string uriBase)
        {
            // Example: "https://localhost:44300/api/pubs/"

            // make sure client included the ending slash/
            if (uriBase.Last() != '/') uriBase += '/';

            _uriBase = uriBase;
        }

        public IList<Publisher> FindAll()
        {
            throw new NotImplementedException();
        }

        public Publisher Find(string id)
        {
            Publisher pb = null;

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_uriBase);

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json")
                );

                string path = $"publishers/{id}";

                HttpResponseMessage response = client.GetAsync(path).Result;

                if (response.IsSuccessStatusCode)
                {
                    pb = response.Content.ReadAsAsync<Publisher>().Result;
                }

            }// end using 

            return pb;
        }

        public bool Create(Publisher x)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_uriBase);

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json")
                );

                HttpResponseMessage response =
                    client.PostAsJsonAsync<Publisher>("publishers", x).Result;

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }

            }// end using 

            return false;
        }

        public bool Update(Publisher x)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_uriBase);

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json")
                );

                string id = x.pb_id;

                HttpResponseMessage response =
                    client.PutAsJsonAsync<Publisher>($"publishers/{id}", x).Result;

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }

            }// end using 

            return false;
        }

        public bool Delete(Publisher x)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_uriBase);

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json")
                );

                string path = $"publishers/{x.pb_id}";

                HttpResponseMessage response =
                    client.DeleteAsync(path).Result;

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }

            }// end using 

            return false;
        }
    }
}

