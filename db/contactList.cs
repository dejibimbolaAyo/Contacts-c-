using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db
{
    public partial class contactList : Form
    {
        public contactList()
        {
            InitializeComponent();
        }

        private void contactList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phonebookDataSet.contacts' table. You can move, or remove it, as needed.
            this.contactsTableAdapter.Fill(this.phonebookDataSet.contacts);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormCreatecontact form = new FormCreatecontact();
            form.Show();

        }
    }
}
