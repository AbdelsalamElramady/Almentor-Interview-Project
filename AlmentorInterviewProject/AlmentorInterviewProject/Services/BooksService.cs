using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AlmentorInterviewProject
{
    public class BooksService
    {
        HttpClient _client;

        public BooksService()
        {
            _client = new HttpClient();
        }

        public List<Book> GetBooks(string uri)
        {
            List<Book> books = null;

            // Here I Assumed that I can use localhost uri to debug the full stack like blazor 
            // but I couldn't do that because the emulator have different local ip address 

            //try
            //{
            //    HttpResponseMessage response = await _client.GetAsync(uri);
            //    if (response.IsSuccessStatusCode)
            //    {
            //        string content = await response.Content.ReadAsStringAsync();
            //        books = JsonConvert.DeserializeObject<List<Book>>(content);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Debug.WriteLine("\tERROR {0}", ex.Message);
            //}

            books = new List<Book>()
            {
                new Book{ Name = "The End", Price = 10 },
                new Book{ Name = "One Hundred Years of Solitude", Price = 20 },
                new Book{ Name = "The Great Gatsby", Price = 15 },
            };

            return books;
        }
    }
}
