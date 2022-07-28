using System;
using System.Collections.Generic;
using Model;
using System.Data.SqlClient;
using System.Data;

/*
Credit: https://www.w3schools.com/sql/sql_insert.asp
https://stackoverflow.com/questions/21709305/how-to-directly-execute-sql-query-in-c/21709663
https://stackoverflow.com/questions/23301582/how-do-i-to-insert-data-into-an-sql-table-using-c-sharp-as-well-as-implement-an/23301661
https://stackoverflow.com/questions/14001040/inserting-new-row-in-sql-database-table
https://blogs.msmvps.com/jcoehoorn/blog/2014/05/12/can-we-stop-using-addwithvalue-already/
https://stackoverflow.com/questions/1496048/sql-server-error-the-insert-statement-conflicted-with-the-check-constraint
https://www.sqltutorial.org/sql-update/
https://stackoverflow.com/questions/15246182/sql-update-statement-in-c-sharp
https://www.w3schools.com/sql/sql_delete.asp
*/

namespace Repositories
{
    public interface IRepository<T>
    {
        IList<T> FindAll();
        T Find(string id);

        //bool Add(T x);
        bool Create(T x);
        bool Update(T x);
        bool Delete(T x);

    }

    public interface IItemsForRepository<I, J> : IRepository<I>
    {
        IList<I> FindFor(J i);
        bool AddFor(I a, J b); // add author, book to titleauthor
        bool DeleteFor(I a, J b); // remove author, book from titleauthor
        bool auDelete(string id); // remove all books of an author

        IList<I> FindAll();
        I Find(string id);

        string FindPub(string id);

        bool Add(I x);
        bool Create(I x);
        bool Update(I x);
        bool Delete(I x);
    }

    public class pubDBRepo : IRepository<Publisher>
    {
        private string _connectionString;

        public pubDBRepo(string connection)
        {
            _connectionString = connection;
        }

        public IList<Publisher> FindAll()
        {
            List<Publisher> pubs = new List<Publisher>();

            //string connection = "Integrated Security=true;Initial Catalog=pubs;Data Source=(local);";

            string sql = "SELECT * FROM publishers";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Publisher pb = new Publisher()
                            {
                                pb_id = reader[@"pub_id"].ToString(),
                                pb_name = reader[@"pub_name"].ToString()
                            };

                            pubs.Add(pb);
                        }
                    }//end reader
                }//end cmd
            }//end connection
            return pubs;
        }

        public Publisher Find(string id)
        {
            throw new NotImplementedException();
        }

        public bool Create(Publisher x)
        {
            throw new NotImplementedException();
        }

        public bool Update(Publisher x)
        {
            throw new NotImplementedException();
        }
        public bool Delete(Publisher x)
        {
            throw new NotImplementedException();
        }
    }

    public class bookDBRepo : IItemsForRepository<Book, string>
    {
        private string _connectionString;

        public bookDBRepo(string connection)
        {
            _connectionString = connection;
        }

        private decimal? GetSafeDecimal(SqlDataReader reader, string column)
        {
            int o = reader.GetOrdinal(column);
            if (reader.IsDBNull(o) == true)
            {
                return null;
            }

            return reader.GetDecimal(o);
        }

        private int? GetSafeInt(SqlDataReader reader, string column)
        {
            int o = reader.GetOrdinal(column);
            if (reader.IsDBNull(o) == true)
            {
                return null;
            }

            return reader.GetInt32(o);
        }

        public bool AddFor(Book x, string id)
        {
            string sql = "INSERT INTO titleauthor (au_id, title_id)"
            + " VALUES (@auid, @titleid)";

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@auid", id);
                        command.Parameters.AddWithValue("@titleid", x.bk_title_id);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("oops {0}", ex.ToString());
                return false;
            }
            return true;
            //throw new NotImplementedException();
        }

        public bool DeleteFor(Book x, string id)
        {
            string sql = "DELETE FROM titleauthor WHERE title_id = @title_id AND au_id = @au_id";

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@title_id", x.bk_title_id);
                        command.Parameters.AddWithValue("@au_id", id);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("oops {0}", ex.ToString());
                return false;
            }
            return true;
            //throw new NotImplementedException();
        }

        public bool Add(Book x)
        {
            string sql = "INSERT INTO titles " +
                "(title_id, title, type, pub_id, price, ytd_sales, pubdate)" +
                " VALUES(@title_id, @title, @type, @pub_id, @price, @ytd_sales, @pubdate)";

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@title_id", x.bk_title_id);
                        command.Parameters.AddWithValue("@title", x.bk_title);
                        command.Parameters.AddWithValue("@type", x.bk_type);
                        command.Parameters.AddWithValue("@pubdate", x.bk_pubdate);
                        command.Parameters.AddWithValue("@pub_id", x.bk_pub_id);

                        command.Parameters.AddWithValue("@ytd_sales", x.bk_ytd_sales.HasValue ? x.bk_ytd_sales.Value
                            : DBNull.Value);

                        command.Parameters.AddWithValue("@price", x.bk_price.HasValue ? x.bk_price.Value
                            : DBNull.Value);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("oops {0}", ex.ToString());
                return false;
            }
            return true;
        }

        public bool Create(Book x) // does the same thing as add?
        {
            string query = "INSERT INTO titles (title_id, title, type, pub_id, price, ytd_sales, pubdate)";
            query += " VALUES (@title_id, @title, @type, @pub_id, @price, @ytd_sales, @pubdate)";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add("@title_id", SqlDbType.VarChar).Value = x.bk_title_id;
                command.Parameters.Add("@title", SqlDbType.VarChar).Value = x.bk_title;
                command.Parameters.Add("@type", SqlDbType.VarChar).Value = x.bk_type;
                command.Parameters.Add("@pub_id", SqlDbType.VarChar).Value = x.bk_pub_id;
                command.Parameters.Add("@price", SqlDbType.Char).Value = x.bk_price;
                command.Parameters.Add("@ytd_sales", SqlDbType.VarChar).Value = x.bk_ytd_sales;
                command.Parameters.Add("@pubdate", SqlDbType.VarChar).Value = x.bk_pubdate;

                conn.Open();
                command.ExecuteNonQuery();

                return true;
                //throw new NotImplementedException();
            }
            //throw new NotImplementedException();
        }

        public string FindPub(string id) // uses PUB ID to find PUB NAME
        {
            string sql = "SELECT pub_name FROM publishers WHERE pub_id = @pub_id";

            string x = "";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.Add("@pub_id", SqlDbType.VarChar).Value = id;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        x = reader["pub_name"].ToString();

                    };
                }//end reader
                //command.ExecuteNonQuery();

                return x;
                //throw new NotImplementedException();
            }

        }

        public Book Find(string id)
        {
            string sql = "SELECT * FROM titles WHERE title_id = @title_id";

            Book x = default(Book);

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.Add("@title_id", SqlDbType.VarChar).Value = id;

                conn.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        x = new Book()
                        {
                            bk_title_id = reader["title_id"].ToString(),
                            bk_title = reader["title"].ToString(),  // ADD SOME FOR EVERY CATEGORY OF DATA NEEDED
                            bk_type = reader["type"].ToString(),
                            bk_pub_id = reader["pub_id"].ToString(),
                            bk_price = GetSafeDecimal(reader, "price"),
                            bk_ytd_sales = GetSafeInt(reader, "ytd_sales"),
                            bk_pubdate = reader.GetDateTime(reader.GetOrdinal("pubdate"))
                        };
                    }
                }//end reader
            }
            //throw new NotImplementedException();
            return x;
        }

        public bool Delete(Book bk)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("DELETE FROM titles WHERE title_id = @bk_id", conn);

                command.Parameters.Add("@bk_id", SqlDbType.VarChar).Value = bk.bk_title_id;

                conn.Open();
                command.ExecuteNonQuery();

                return true;
            }
            //throw new NotImplementedException();
        }

        public bool auDelete(string id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("DELETE FROM titleauthor WHERE au_id = @au_id", conn);

                command.Parameters.Add("@au_id", SqlDbType.VarChar).Value = id;

                conn.Open();
                command.ExecuteNonQuery();

                return true;
            }
            //throw new NotImplementedException();
        }

        public bool Update(Book x)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("UPDATE titles SET title_id = @title_id, title = @title, type = @type, pub_id = @pub_id, price = @price, ytd_sales = @ytd_sales, pubdate = @pubdate, WHERE title_id = @title_id", conn);

                command.Parameters.Add("@title_id", SqlDbType.VarChar).Value = x.bk_title_id;
                command.Parameters.Add("@title", SqlDbType.VarChar).Value = x.bk_title;
                command.Parameters.Add("@type", SqlDbType.VarChar).Value = x.bk_type;
                command.Parameters.Add("@pub_id", SqlDbType.Char).Value = x.bk_pub_id;
                command.Parameters.Add("@price", SqlDbType.VarChar).Value = x.bk_price;
                command.Parameters.Add("@ytd_sales", SqlDbType.VarChar).Value = x.bk_ytd_sales;
                command.Parameters.Add("@pubdate", SqlDbType.VarChar).Value = x.bk_pubdate;

                conn.Open();
                command.ExecuteNonQuery();

                return true;
            }
            //throw new NotImplementedException();
        }

        public IList<Book> FindFor(string id) // when complete, this finds by AUTHOR
        {
            string sql = "SELECT T.title_id, title, type, P.pub_id, price, ytd_sales, pubdate FROM titles T";
            sql += " JOIN publishers P";
            sql += " ON P.pub_id = T.pub_id";
            sql += " JOIN titleauthor TA";
            sql += " ON TA.title_id = T.title_id";
            sql += " WHERE TA.au_id = @au_id";

            List<Book> books = new List<Book>();

            Book book = default(Book);

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@au_id", SqlDbType.VarChar).Value = id;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                book = new Book()
                                {
                                    bk_title_id = reader["title_id"].ToString(),
                                    bk_title = reader["title"].ToString(),  // ADD SOME FOR EVERY CATEGORY OF DATA NEEDED
                                    bk_type = reader["type"].ToString(),
                                    bk_pub_id = reader["pub_id"].ToString(),
                                    bk_price = GetSafeDecimal(reader, "price"),
                                    bk_ytd_sales = GetSafeInt(reader, "ytd_sales"),
                                    bk_pubdate = reader.GetDateTime(reader.GetOrdinal("pubdate"))
                                };

                                books.Add(book);
                            };
                        }//end reader
                    }//end cmd
                }
            }//end connection
            catch (SqlException ex)
            {
                return default(IList<Book>);
            }

            return books;
            //throw new NotImplementedException();
        }

        public IList<Book> FindAll()
        {
            List<Book> books = new List<Book>();

            //string connection = "Integrated Security=true;Initial Catalog=pubs;Data Source=(local);";

            string sql = "SELECT * FROM titles";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Book bk = new Book()
                            {
                                bk_title_id = reader[@"title_id"].ToString(),
                                bk_title = reader[@"title"].ToString(),  // ADD SOME FOR EVERY CATEGORY OF DATA NEEDED
                                bk_type = reader[@"type"].ToString(),
                                bk_pub_id = reader[@"pub_id"].ToString(),
                                bk_price = GetSafeDecimal(reader, @"price"),
                                bk_ytd_sales = GetSafeInt(reader, @"ytd_sales"),
                                bk_pubdate = reader.GetDateTime(reader.GetOrdinal(@"pubdate"))
                            };

                            books.Add(bk);
                        }
                    }//end reader
                }//end cmd
            }//end connection
            return books;
        }

    }

        public class authorDBRepo : IRepository<Author>
    {
        private string _connectionString;

        public authorDBRepo(string connection)
        {
            _connectionString = connection;
        }

        public bool Create(Author x)
        {
            string query = "INSERT INTO authors (au_id, au_lname, au_fname, phone, address, city, zip, contract)";
            query += " VALUES (@au_id, @au_lname, @au_fname, @phone, @address, @city, @zip, @contract)";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add("@au_id", SqlDbType.VarChar).Value = x.au_id;
                command.Parameters.Add("@au_lname", SqlDbType.VarChar).Value = x.au_lname;
                command.Parameters.Add("@au_fname", SqlDbType.VarChar).Value = x.au_fname;
                command.Parameters.Add("@phone", SqlDbType.Char).Value = x.au_phone;
                command.Parameters.Add("@address", SqlDbType.VarChar).Value = x.au_address;
                command.Parameters.Add("@city", SqlDbType.VarChar).Value = x.au_city;
                command.Parameters.Add("@zip", SqlDbType.VarChar).Value = x.au_zip;
                command.Parameters.Add("@contract", SqlDbType.Bit).Value = x.au_contract;

                conn.Open();
                command.ExecuteNonQuery();  // IT WORKS!!!!! WOW

                return true;
                //throw new NotImplementedException();
            }
        }

        public bool Delete(Author x)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("DELETE FROM authors WHERE au_id = @au_id", conn);

                command.Parameters.Add("@au_id", SqlDbType.VarChar).Value = x.au_id;

                conn.Open();
                command.ExecuteNonQuery();

                //throw new NotImplementedException();

                return true;
            }
        }

        public Author Find(string id)
        {
            string sql = "SELECT * FROM authors WHERE au_id = @auid";

            Author author = default(Author);

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@auid", id);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                author = new Author()
                                {
                                    au_id = reader["au_id"].ToString(),
                                    au_fname = reader["au_fname"].ToString(),  // ADD SOME FOR EVERY CATEGORY OF DATA NEEDED
                                    au_lname = reader["au_lname"].ToString(),
                                    au_phone = reader["phone"].ToString(),
                                    au_address = reader["address"].ToString(),
                                    au_city = reader["city"].ToString(),
                                    au_zip = reader["zip"].ToString(),
                                    au_contract = (bool)reader["contract"]
                                };
                            }
                        }//end reader
                    }//end cmd
                }
            }//end connection
            catch (SqlException ex)
            {
                return default(Author);
            }

            return author;
        }

    public IList<Author> FindAll()
        {
            List<Author> authors = new List<Author>();

            //string connection = "Integrated Security=true;Initial Catalog=pubs;Data Source=(local);";

            string sql = "SELECT * FROM authors";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Author au = new Author()
                            {
                                au_id = reader[@"au_id"].ToString(),
                                au_fname = reader[@"au_fname"].ToString(),  // ADD SOME FOR EVERY CATEGORY OF DATA NEEDED
                                au_lname = reader[@"au_lname"].ToString(),
                                au_phone = reader[@"phone"].ToString(),
                                au_address = reader[@"address"].ToString(),
                                au_city = reader[@"city"].ToString(),
                                au_zip = reader[@"zip"].ToString(),
                                au_contract = (bool)reader[@"contract"]
                            };

                            authors.Add(au);
                        }
                    }//end reader
                }//end cmd
            }//end connection
            return authors;
        }
        public bool Update(Author x)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("UPDATE authors SET au_id = @au_id, au_lname = @au_lname, au_fname = @au_fname, phone = @phone, address = @address, city = @city, zip = @zip, contract = @contract WHERE au_id = @au_id", conn);

                command.Parameters.Add("@au_id", SqlDbType.VarChar).Value = x.au_id;
                command.Parameters.Add("@au_lname", SqlDbType.VarChar).Value = x.au_lname;
                command.Parameters.Add("@au_fname", SqlDbType.VarChar).Value = x.au_fname;
                command.Parameters.Add("@phone", SqlDbType.Char).Value = x.au_phone;
                command.Parameters.Add("@address", SqlDbType.VarChar).Value = x.au_address;
                command.Parameters.Add("@city", SqlDbType.VarChar).Value = x.au_city;
                command.Parameters.Add("@zip", SqlDbType.VarChar).Value = x.au_zip;
                command.Parameters.Add("@contract", SqlDbType.Bit).Value = x.au_contract;

                conn.Open();
                command.ExecuteNonQuery();  // IT WORKS!!!!! WOW

                return true;
                //throw new NotImplementedException();
            }
            //throw new NotImplementedException();
        }
    }
}
