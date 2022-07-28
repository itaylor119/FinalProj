using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repositories;
using ViewModels;
using Model;
using PubsServiceBus;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace PubsWinForms
{
    public partial class Warning : Form
    {
        private Authors _master;
        ServiceBus _service;
        public Warning(Authors master, ServiceBus service)
        {
            InitializeComponent();
            _master = master;
            _service = service;
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

        private void no_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void yes_Click(object sender, EventArgs e)
        {
            string connec = GetConnection();

            authorDBRepo repo
                = new authorDBRepo(connec);

            Control idbox = this.Owner.Controls.Find("txtTempID", true).First();

            Author add = new Author();
            add.au_id = idbox.Text;
            _service.deleteAllAuthorBooks(add.au_id);
            repo.Delete(add);
            _master.UpdateList();
            Close();
        }

        private void Warning_Load(object sender, EventArgs e)
        {

        }
    }
}
