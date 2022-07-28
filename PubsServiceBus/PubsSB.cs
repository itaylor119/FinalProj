using System;
using Repositories;
using Model;
using ViewModels;
using System.Collections.Generic;

namespace PubsServiceBus
{
    public class ServiceBus
    {
        private IRepository<Author> _auRepo;

        private IRepository<Publisher> _pbRepo;

        private IItemsForRepository<Book, string> _bkRepo;

        public ServiceBus(IRepository<Author> auRepo,
            IItemsForRepository<Book, string> bkRepo,
            IRepository<Publisher> pbRepo)
        {
            _auRepo = auRepo;
            _bkRepo = bkRepo;
            _pbRepo = pbRepo;
        }

        public List<AuthorViewModel> findAllAuthors()
        {
            List<AuthorViewModel> authors = new List<AuthorViewModel>();
            List<Author> auList;

            auList = (List<Author>)_auRepo.FindAll();

            foreach(Author au in auList)
            {
                AuthorViewModel avm = new AuthorViewModel(au.au_id, au.au_fname, au.au_lname, au.au_phone, au.au_address, au.au_city, au.au_zip, au.au_contract); // Update with every category?

                authors.Add(avm);
            }    

            return authors;
        }
        public List<BookViewModel> findAuthorBooks(string id)
        {
            List<BookViewModel> books = new List<BookViewModel>();
            IList<Book> bkList;

            bkList = _bkRepo.FindFor(id); // it does not like something to do with the ID here

            foreach (Book bk in bkList) //bkList is null. FindFor probably isn't working correctly
            {
                BookViewModel avm = new BookViewModel(bk.bk_title_id, bk.bk_title, bk.bk_type, bk.bk_pub_id, bk.bk_price, bk.bk_ytd_sales, bk.bk_pubdate); // Update with every category?

                books.Add(avm);
            }

            return books;
        }

        public Book FindBook(string id)
        {
            return _bkRepo.Find(id);
        }

        public bool addToAuthor(Book bk, string id)
        {
            bool result = _bkRepo.AddFor(bk, id);

            return result;
        }

        public List<PublisherViewModel> findAllPubs()
        {
            List<PublisherViewModel> pubs = new List<PublisherViewModel>();
            List<Publisher> pbList;

            pbList = (List<Publisher>)_pbRepo.FindAll();

            foreach (Publisher pb in pbList)
            {
                PublisherViewModel avm = new PublisherViewModel(pb.pb_id, pb.pb_name); // Update with every category?

                pubs.Add(avm);
            }

            return pubs;
        }

        public bool deleteAllAuthorBooks(string id)
        {
            bool result = _bkRepo.auDelete(id);

            return result;
        }

        public bool deleteFromAuthor(Book bk, string id)
        {
            bool result = _bkRepo.DeleteFor(bk, id);

            return result;
        }

        public bool addBook(Book bk)
        {
            bool result = _bkRepo.Add(bk);

            return result;
        }

        public List<BookViewModel> findAllBooks()
        {
            List<BookViewModel> books = new List<BookViewModel>();
            List<Book> bkList;

            bkList = (List<Book>)_bkRepo.FindAll();

            foreach (Book bk in bkList)
            {
                BookViewModel avm = new BookViewModel(bk.bk_title_id, bk.bk_title, bk.bk_type, bk.bk_pub_id, bk.bk_price, bk.bk_ytd_sales, bk.bk_pubdate); // Update with every category?

                books.Add(avm);
            }

            return books;
        }

        public AuthorViewModel findByID(string id)
        {
            Author au = _auRepo.Find(id);

            AuthorViewModel avm = new AuthorViewModel(au.au_id, au.au_fname, au.au_lname, au.au_phone, au.au_address, au.au_city, au.au_zip, au.au_contract);

            return avm;
        }

        public string findBkPub(string id)
        {
            string pub = _bkRepo.FindPub(id);

            return pub;
        }

        public bool createAuthor(Author au)
        {
            bool result = _auRepo.Create(au);

            return result;
        }

        public bool updateAuthor(Author au)
        {
            bool result = _auRepo.Update(au);

            return result;
        }
    }
}
