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
    public class AuthorRepoHTTP : IRepository<Model.Author>
    {
        string _uriBase; 

        public AuthorRepoHTTP(string uriBase)
        {
            // Example: "https://localhost:44300/api/pubs/"

            // make sure client included the ending slash/
            if(uriBase.Last() != '/') uriBase += '/'; 

            _uriBase = uriBase; 
        }

        public bool Create(Author x)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_uriBase);

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json")
                );

                HttpResponseMessage response =
                    client.PostAsJsonAsync<Author>("authors", x).Result;

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }

            }// end using 

            return false;
        }

        public bool Delete(Author x) // MUST run method to delete all au books first!!!
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_uriBase);

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json")
                );

                string path = $"authors/{x.au_id}";

                HttpResponseMessage response =
                    client.DeleteAsync(path).Result;

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }

            }// end using 

            return false;
        }

        public Author Find(string id)
        {
            Author au = null;

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_uriBase);

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json")
                );

                string path = $"authors/{id}";

                HttpResponseMessage response = client.GetAsync(path).Result;

                if (response.IsSuccessStatusCode)
                {
                    au = response.Content.ReadAsAsync<Author>().Result;
                }

            }// end using 

            return au; 
        }

        public IList<Author> FindAll()
        {
            IList<Author> au = null;

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_uriBase);

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json")
                );

                string path = "authors";

                HttpResponseMessage response = client.GetAsync(path).Result;

                if (response.IsSuccessStatusCode)
                {
                    au = response.Content.ReadAsAsync<IList<Author>>().Result;
                }

            }// end using 

            return au;
        }

        public bool Update(Author x)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_uriBase);

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json")
                );

                string id = x.au_id;

                HttpResponseMessage response =
                    client.PutAsJsonAsync<Author>($"authors/{id}", x).Result;

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }

            }// end using 

            return false;
        }


    }
}

