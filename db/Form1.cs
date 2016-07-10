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


    public partial class FormCreatecontact : Form
    {

        public FormCreatecontact()
        {
            InitializeComponent();
        }

        public void resetData()
        {
            textBoxFirstname.ResetText();
            textBoxLastname.ResetText();
            textBoxPhone.ResetText();
            textBoxEmail.ResetText();
        }

        private void buttonCreatcontact_Click(object sender, EventArgs e)
        {

            datahandler dt = new datahandler();

            dt.setFname(Convert.ToString(textBoxFirstname.Text));
            dt.setLname(Convert.ToString(textBoxLastname.Text));
            dt.setEmail(Convert.ToString(textBoxEmail.Text));
            dt.setPhoneNo(Convert.ToString(textBoxPhone.Text));

            if (dt.createContact())
            {
                labelDbStatus.Text = "Congrats " + Convert.ToString(textBoxLastname.Text) + ", Contact Saved";
                resetData();
            }
            else
                labelDbStatus.Text = "Contact was not saved; Please contact the Admin";
        }

        private void buttonContacts_Click(object sender, EventArgs e)
        {
            this.Hide();
            contactList contacts = new contactList();
            contacts.ShowDialog();
        }

        private void viewContactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            contactList contacts = new contactList();
            contacts.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createContactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
            labelDbStatus.Text = "";
            resetData();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This app helps manage your Contacts");
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("V 1.0.0");
        }
    }
}
            
                


