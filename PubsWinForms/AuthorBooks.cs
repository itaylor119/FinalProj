using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PubsServiceBus;
using ViewModels;

namespace PubsWinForms
{
    public partial class AuthorBooks: Form
    {
        ServiceBus _service;
        string _id;
        public ListViewItem item;

        public AuthorBooks(Authors master, string au_id, ServiceBus service)
        {
            InitializeComponent();

            _service = service;

            _id = au_id;

            AuthorLabel.Text = "Author: " + service.findByID(au_id).Name;

            allBooksList.View = View.List;
            allBooksList.FullRowSelect = true;
            allBooksList.MultiSelect = false;
            allBooksList.GridLines = true;

            auBooksList.View = View.List;
            auBooksList.FullRowSelect = true;
            auBooksList.MultiSelect = false;
            auBooksList.GridLines = true;

            UpdateListAuth();
            UpdateListAll();
        }

        public void UpdateListAll()
        {
            List<BookViewModel> books =
                _service.findAllBooks();

            allBooksList.Items.Clear();

            foreach (BookViewModel bk in books)
            {
                string pub =
                _service.findBkPub(bk.PubID);

                item = new ListViewItem(bk.Title);
                item.Tag = bk.TitleID;         // THIS IS HOW TO AUTO UPDATE LIST FROM REPO. DO IT
                item.SubItems.Add(bk.Type);
                item.SubItems.Add(pub);
                item.SubItems.Add(bk.PubID);
                item.SubItems.Add(bk.Price);
                item.SubItems.Add(bk.YTDSales);
                item.SubItems.Add(bk.PubDate);

                allBooksList.Items.Add(item);
            }

            foreach (ColumnHeader col in allBooksList.Columns) col.Width = -2;
        }

        public void UpdateListAuth() // MOST RECENT CHANGES NEED TO HAPPEN HERE
        {
            List<BookViewModel> books =
                _service.findAuthorBooks(_id);

            auBooksList.Items.Clear();

            foreach (BookViewModel bk in books)
            {
                string pub =
                _service.findBkPub(bk.PubID);

                item = new ListViewItem(bk.Title);
                item.Tag = bk.TitleID;         // THIS IS HOW TO AUTO UPDATE LIST FROM REPO. DO IT
                item.SubItems.Add(bk.Type);
                item.SubItems.Add(pub);
                item.SubItems.Add(bk.PubID);
                item.SubItems.Add(bk.Price);
                item.SubItems.Add(bk.YTDSales);
                item.SubItems.Add(bk.PubDate);

                auBooksList.Items.Add(item);
            }

            foreach (ColumnHeader col in auBooksList.Columns) col.Width = -2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AuthorBooks_Load(object sender, EventArgs e)
        {

        }

        private void booksToAu_Click(object sender, EventArgs e)  // need book object from list
        {
            if (allBooksList.SelectedItems.Count <= 0) return;

            string id = allBooksList.SelectedItems[0].Tag.ToString();

            if (id != null)
            {
                _service.addToAuthor(_service.FindBook(id), _id);

                UpdateListAuth();
                UpdateListAll();
            }
        }

        private void auToBooks_Click(object sender, EventArgs e)
        {
            if (auBooksList.SelectedItems.Count <= 0) return;

            string id = auBooksList.SelectedItems[0].Tag.ToString();

            if (id != null)
            {
                _service.deleteFromAuthor(_service.FindBook(id), _id);

                UpdateListAuth();
                UpdateListAll();
            }
        }

        private void auBooksList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //check for unselect
            if (auBooksList.SelectedItems.Count <= 0) return;

            ListViewItem item = auBooksList.SelectedItems[0];
        }

        private void allBooksList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //check for unselect
            if (allBooksList.SelectedItems.Count <= 0) return;

            ListViewItem item = allBooksList.SelectedItems[0];

        }

        private void addBook_Click(object sender, EventArgs e)
        {
            addABook popup = new addABook(this, _service);
            popup.ShowDialog(this);
        }
    }
}
