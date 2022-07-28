using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Text.RegularExpressions;

using Repositories;
using Model;
using ViewModels;
using PubsServiceBus;

/*
Credit: https://docs.microsoft.com/en-us/dotnet/api/system.string.tolower?view=net-5.0
https://www.geeksforgeeks.org/how-to-set-read-only-content-in-maskedtextbox-in-c-sharp/
https://www.c-sharpcorner.com/UploadFile/87b416/validating-user-input-with-regular-expressions/
*/

namespace PubsWinForms
{
    public partial class Add_Edit : Form
    {
        private Authors _master;
        ServiceBus _service;

        public Add_Edit(Authors master, ServiceBus service)
        {
            InitializeComponent();
            _master = master;
            _service = service;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void save_Click(object sender, EventArgs e)
        {


            if (Text == "Add Author")
            {
                bool con = false;

                if (contractBox.Text.ToLower() == "yes")
                {
                    con = true;
                }
                else if (contractBox.Text.ToLower() == "no")
                {
                    con = false;
                }
                else
                {
                    //IMPLEMENT EXCEPTIONS, TRY's, OR SOME KIND OF ERROR FOR BAD INPUT
                    return;
                }

                Author add = new Author();
                add.au_id = idBox.Text;
                add.au_fname = fnameBox.Text;
                add.au_lname = lnameBox.Text;
                add.au_phone = phoneBox.Text;
                add.au_address = addressBox.Text;
                add.au_city = cityBox.Text;
                add.au_zip = zipBox.Text;
                add.au_contract = con;

                _service.createAuthor(add); // FINISH THIS METHOD
                _master.UpdateList();
            }

            else if (Text == "Edit Author")
            {
                bool con = false;

                if (contractBox.Text.ToLower() == "yes")
                {
                    con = true;
                }
                else if (contractBox.Text.ToLower() == "no")
                {
                    con = false;
                }
                else
                {
                    //IMPLEMENT EXCEPTIONS, TRY's, OR SOME KIND OF ERROR FOR BAD INPUT
                    return;
                }
                //Authors own = (Authors)Owner;
                //ListViewItem id = own.lvAuthors.SelectedItems[0];
                //Control oldid = this.Owner.Controls.Find("txtTempID", true)[0];
                

                Author add = new Author();
                add.au_id = idBox.Text;
                add.au_fname = fnameBox.Text;
                add.au_lname = lnameBox.Text;
                add.au_phone = phoneBox.Text;
                // MAKE OPEN ERROR WHEN ONE IS MADE vvvvvv
                //if (!Regex.Match(phoneBox.Text, @"^[1-9]\d{3}\s?[1-9]\d{3}-\d{4}$").Success) {  }
                add.au_address = addressBox.Text;
                add.au_city = cityBox.Text;
                add.au_zip = zipBox.Text;
                add.au_contract = con;

                _service.updateAuthor(add);
                _master.UpdateList();
            }

            else { }
        }

        private void Add_Edit_Load(object sender, EventArgs e)
        {
            if (Text == "Edit Author")
            {
                idBox.ReadOnly = true;
            }
            else if (Text == "Add Author")
            {
                idBox.ReadOnly = false;
            }
        }
    }
}
