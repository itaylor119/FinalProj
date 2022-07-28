using System;

namespace ViewModels
{
    public class AuthorViewModel
    {
        public string ID { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Phone { get; }
        public string Address { get; }
        public string City { get; }
        public string ZIP { get; }
        public string Contract { get; }
        public string Name
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public AuthorViewModel(string id, string fname, string lname, string phone, string address, string city, string zip, bool contract) // Update with full categories!!
        {
            ID = id;
            FirstName = fname;
            LastName = lname;
            Phone = phone.ToString();
            Address = address;
            City = city;
            ZIP = zip;

            if (contract) { Contract = "Yes"; }
            else { Contract = "No"; }

        }
    }

    public class BookViewModel
    {
        public string TitleID { get; }
        public string Title { get; }
        public string Type { get; }
        public string PubID { get; }
        public string Price { get; }
        public string YTDSales { get; }
        public string PubDate { get; }

        public BookViewModel(string titleid, string title, string type, string pubid, decimal ? price, int ? ytdsales, DateTime pubdate) // Update with full categories!!
        {
            TitleID = titleid;
            Title = title;
            Type = type;
            PubID = pubid;

            if (price.HasValue)
                Price = String.Format("{0:C}", price.Value);
            else
                Price = "NULL";

            //YTDSales = ytdsales;
            if (ytdsales.HasValue)
                YTDSales = ytdsales.Value.ToString();
            else
                YTDSales = "NULL";

            PubDate = pubdate.ToShortDateString();
        }
    }

    public class PublisherViewModel
    {
        public string ID { get; }
        public string Name { get; }

        public PublisherViewModel(string id, string name) // Update with full categories!!
        {
            ID = id;
            Name = name;
        }
    }
}
