using System;

namespace Model
{
    public class Author
    {
        public string au_id { get; set; }
        public string au_fname { get; set; }
        public string au_lname { get; set; }
        public string au_phone { get; set; }
        public string au_address { get; set; }
        public string au_city { get; set; }
        public string au_zip { get; set; }
        public bool au_contract { get; set; }
    }

    public class Book
    {
        public string bk_title_id { get; set; }
        public string bk_title { get; set; }
        public string bk_type { get; set; }
        public string bk_pub_id { get; set; }
        public decimal? bk_price { get; set; }
        public int? bk_ytd_sales { get; set; }
        public DateTime bk_pubdate { get; set; }
    }

    public class Publisher
    {
        public string pb_id { get; set; }
        public string pb_name { get; set; }
    }
}
