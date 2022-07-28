using System;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using PubsServiceBus;
using ViewModels;
using Model;
using Repositories;

namespace TestApp
{
    class Program
    {
        static string GetConnection()
        {
            IConfiguration Configuration;

            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional:
                false, reloadOnChange: false);

            Configuration = builder.Build();

            string con = Configuration["Configuration:pubsDBConnectionString"];

            return con;
        }
        static void Main(string[] args)
        {

            string connection = GetConnection();

            authorDBRepo auRepo = new authorDBRepo(connection);

            bookDBRepo bkRepo = new bookDBRepo(connection);

            pubDBRepo pbRepo = new pubDBRepo(connection);

            ServiceBus service = new ServiceBus(auRepo, bkRepo, pbRepo);

            List<AuthorViewModel> authors = service.findAllAuthors();
           
            foreach (AuthorViewModel au in authors)
            {
                Console.WriteLine(
                    String.Format(
                        "{0} - {1} {2}", au.ID, au.FirstName, au.LastName
                        )
                    );
            }
            //Console.WriteLine(Author.au_fname);
        }
    }
}
