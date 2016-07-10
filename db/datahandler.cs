using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace db
{
    public class datahandler
    {
        public string fname;
        public string lname;
        public string email;
        public string phoneNo;

        public static string connStr = "Server=localhost;Port=8080;Uid=root;Pwd=root;Database=phonebook";

        MySqlConnection conn = new MySqlConnection(connStr);

        private void connInit()
        {
            
            try
            {
                conn.Open();
            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        //these fuctions sets the variables fname, lname, email, phone
        public void setFname(string f_name)
        {
            this.fname = f_name;
        }

        public void setLname(string l_name)
        {
            this.lname = l_name;
        }

        public void setEmail(string e_mail)
        {
            this.email = e_mail;
        }

        public void setPhoneNo(string p_hone)
        {
            this.phoneNo = p_hone;
        }

        //this function queries the database inserting new phone numbers into the contacts table
        public bool createContact()
        {
            
            string qry = "INSERT INTO contacts(f_name,l_name,email,phone)VALUES(@fname,@lname,@email,@phone)";

            //creates instance of mysqlCommand class; cmd object of class mysqlCommand
            MySqlCommand cmd = new MySqlCommand();

            //set the connection attribute of the mysqlcommand object cmd
            cmd.Connection = conn;
            //set the commandText attribute of the mysqlcommand object cmd
            cmd.CommandText = qry;

            connInit();

            cmd.Parameters.AddWithValue("@fname", fname );
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@phone", phoneNo);

            cmd.ExecuteNonQuery();

            closeConn();

            return true;
            
        }

        public void closeConn()
        {
            conn.Close();
        }

        public datahandler()
        {
            // TODO: Complete member initialization
        }

    }
}
