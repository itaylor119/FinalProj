using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Extensions.Configuration;

using Repositories;
using Model;
using ViewModels;
using PubsServiceBus;

/*
Credit: https://stackoverflow.com/questions/5134518/listview-getting-subitem-text
https://stackoverflow.com/questions/20286176/how-to-call-function-from-another-form
https://stackoverflow.com/questions/435379/c-sharp-clear-all-items-in-listview/435528
*/

namespace PubsWinForms
{

    public partial class Authors : Form
    {

        public ListViewItem item;

        ServiceBus _service;
        public Authors()
        {
            InitializeComponent();

            string con = GetConnection();

            con = "https://localhost:44359/api/pubs"; 

            AuthorRepoHTTP au_repo
                = new AuthorRepoHTTP(con);

            BookRepoHTTP bk_repo
                = new BookRepoHTTP(con);

            PubRepoHTTP pb_repo
                = new PubRepoHTTP(con);

            _service = new ServiceBus(au_repo, bk_repo, pb_repo);

            lvAuthors.View = View.Details;
            lvAuthors.FullRowSelect = true;
            lvAuthors.MultiSelect = false;
            lvAuthors.GridLines = true;

            //lvAuthors.Columns.Add("ID"); this will be hidden and put in its own box on select
            lvAuthors.Columns.Add("First");
            lvAuthors.Columns.Add("Last");
            lvAuthors.Columns.Add("Phone");
            lvAuthors.Columns.Add("Address");
            lvAuthors.Columns.Add("City");
            lvAuthors.Columns.Add("ZIP");
            lvAuthors.Columns.Add("Contract");

            //display all authors

            List<AuthorViewModel> authors =
                _service.findAllAuthors();

            foreach(AuthorViewModel au in authors)
            {
                item = new ListViewItem(au.FirstName);
                item.SubItems.Add(au.LastName);         // THIS IS HOW TO AUTO UPDATE LIST FROM REPO. DO IT
                item.SubItems.Add(au.Phone);
                item.SubItems.Add(au.Address);
                item.SubItems.Add(au.City);
                item.SubItems.Add(au.ZIP);
                item.SubItems.Add(au.Contract);

                item.Tag = au.ID;

                lvAuthors.Items.Add(item);
            }

            foreach (ColumnHeader col in lvAuthors.Columns) col.Width = -2; 
        }

        public void UpdateList()
        {
            List<AuthorViewModel> authors =
                _service.findAllAuthors();

            lvAuthors.Items.Clear();

            foreach (AuthorViewModel au in authors)
            {
                item = new ListViewItem(au.FirstName);
                item.SubItems.Add(au.LastName);         // THIS IS HOW TO AUTO UPDATE LIST FROM REPO. DO IT
                item.SubItems.Add(au.Phone);
                item.SubItems.Add(au.Address);
                item.SubItems.Add(au.City);
                item.SubItems.Add(au.ZIP);
                item.SubItems.Add(au.Contract);

                item.Tag = au.ID;

                lvAuthors.Items.Add(item);
            }

            foreach (ColumnHeader col in lvAuthors.Columns) col.Width = -2;
        }

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

        private void lvAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            //check for unselect
            if (lvAuthors.SelectedItems.Count <= 0) return;

            ListViewItem item = lvAuthors.SelectedItems[0];

            txtTempID.Text = (String)item.Tag;
        }

        private void Authors_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Add_Edit popup = new Add_Edit(this, _service);
            popup.Text = "Add Author";
            popup.ShowDialog(this);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            //check for unselect
            if (lvAuthors.SelectedItems.Count <= 0) return;

            Add_Edit popup = new Add_Edit(this, _service);
            popup.Owner = (Form)this;
            popup.Text = "Edit Author";

            ListViewItem item = lvAuthors.SelectedItems[0];
            popup.idBox.Text = (string)item.Tag;
            
            popup.fnameBox.Text = item.SubItems[0].Text;
            popup.lnameBox.Text = item.SubItems[1].Text;
            popup.phoneBox.Text = item.SubItems[2].Text;
            popup.addressBox.Text = item.SubItems[3].Text;
            popup.cityBox.Text = item.SubItems[4].Text;
            popup.zipBox.Text = item.SubItems[5].Text;
            popup.contractBox.Text = item.SubItems[6].Text;


            //Control id = popup.Controls.Find("idBox", true).First();
            //id.Text = (String)ID.Tag;


            popup.ShowDialog(this);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Warning popup = new Warning(this, _service);
            popup.ShowDialog(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTempID_TextChanged(object sender, EventArgs e)
        {

        }

        private void booksView_Click(object sender, EventArgs e)
        {
            if (lvAuthors.SelectedItems.Count <= 0) return;

            ListViewItem item = lvAuthors.SelectedItems[0];
            string id = (string)item.Tag;


            AuthorBooks popup = new AuthorBooks(this, id, _service);
            popup.ShowDialog(this);
        }
    }
}
