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
    public class BookRepoHTTP : IItemsForRepository<Model.Book, string>
    {
        string _uriBase; 

        public BookRepoHTTP(string uriBase)
        {
            // Example: "https://localhost:44300/api/pubs/"

            // make sure client included the ending slash/
            if(uriBase.Last() != '/') uriBase += '/'; 

            _uriBase = uriBase; 
        }

        public bool Add(Book x)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_uriBase);

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json")
                );

                HttpResponseMessage response =
                    client.PostAsJsonAsync<Book>("titles", x).Result;

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }

            }// end using 

            return false;
        }

        public bool Delete(Book x)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_uriBase);

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json")
                );

                string path = $"titles/{x.bk_title_id}";

                HttpResponseMessage response =
                    client.DeleteAsync(path).Result;

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }

            }// end using 

            return false;
        }


        public bool Update(Book x)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_uriBase);

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json")
                );

                string id = x.bk_title_id;

                HttpResponseMessage response =
                    client.PutAsJsonAsync<Book>($"titles/{id}", x).Result;

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }

            }// end using 

            return false;
        }

        public bool AddFor(Book x, string id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_uriBase);

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json")
                );

                HttpResponseMessage response =
                    client.PostAsJsonAsync<Book>($"titles/{x.bk_title_id}/authors/{id}", x).Result;

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }

            }// end using 

            return false;
        }

        public IList<Book> FindFor(string id)
        {
            IList<Book> bk = null;

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_uriBase);

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json")
                );

                string path = $"titles/authors/{id}";

                HttpResponseMessage response = client.GetAsync(path).Result;

                if (response.IsSuccessStatusCode)
                {
                    bk = response.Content.ReadAsAsync<IList<Book>>().Result;
                }

            }// end using 

            return bk;
        }

        public bool auDelete(string id) // deletes all au books
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_uriBase);

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json")
                );

                string path = $"titles/authors/{id}";

                HttpResponseMessage response =
                    client.DeleteAsync(path).Result;

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }

            }// end using 

            return false;
        }

        public bool Create(Book x)
        {
            throw new NotImplementedException();
        }

        public bool DeleteFor(Book a, string b)
        {
            throw new NotImplementedException();
        }

        public IList<Book> FindAll()
        {
            IList<Book> bk = null;

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_uriBase);

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json")
                );

                string path = $"titles";

                HttpResponseMessage response = client.GetAsync(path).Result;

                if (response.IsSuccessStatusCode)
                {
                    bk = response.Content.ReadAsAsync<IList<Book>>().Result;
                }

            }// end using 

            return bk;
        }

        public Book Find(string id)
        {
            Book bk = null;

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_uriBase);

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json")
                );

                string path = $"titles/{id}";

                HttpResponseMessage response = client.GetAsync(path).Result;

                if (response.IsSuccessStatusCode)
                {
                    bk = response.Content.ReadAsAsync<Book>().Result;
                }

            }// end using 

            return bk;
        }

        public string FindPub(string id)
        {
            string bk = null;

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_uriBase);

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json")
                );

                string path = $"titles/{id}";

                HttpResponseMessage response = client.GetAsync(path).Result;

                if (response.IsSuccessStatusCode)
                {
                    bk = response.Content.ReadAsAsync<string>().Result;
                }

            }// end using 

            return bk;
        }
    }
}

