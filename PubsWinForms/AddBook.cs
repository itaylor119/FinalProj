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
using Model;
using ViewModels;

/* Sources:
https://stackoverflow.com/questions/7423911/how-to-populate-c-sharp-windows-forms-combobox 
https://docs.microsoft.com/en-us/dotnet/api/system.convert.todecimal?view=net-6.0
 */

namespace PubsWinForms
{
    public partial class addABook : Form
    {
        private AuthorBooks _master;
        ServiceBus _service;
        public ListViewItem item;

        public addABook(AuthorBooks master, ServiceBus service)
        {
            InitializeComponent();

            _service = service;
            _master = master;

            updateComboBox();
        }

        public void updateComboBox()
        {
            publishComboBox.DataSource = _service.findAllPubs();
            publishComboBox.DisplayMember = "Name"; // Column Name
            publishComboBox.ValueMember = "ID";  // Column Name
        }

        private void publishComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void publishLabel_Click(object sender, EventArgs e)
        {

        }

        private void idBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {

            Book add = new Book();
            add.bk_title_id = idBox.Text;
            add.bk_title = titleBox.Text;
            add.bk_pub_id = publishComboBox.SelectedValue.ToString();
            add.bk_price = Convert.ToDecimal(costBox.Text);
            add.bk_type = typeBox.Text;
            add.bk_ytd_sales = Convert.ToInt32(salesBox.Text);
            add.bk_pubdate = pubDate.Value;

            _service.addBook(add);

            _master.UpdateListAll();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
