using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ContactBook
{
    public partial class Form1 : Form
    {
        class Contact
        {
            public string name
            {
                get;
                set;
            }

            public string surname
            {
                get;
                set;
            }

            public string number
            {
                get;
                set;
            }

            public string mail
            {
                get;
                set;
            }

            public string address
            {
                get;
                set;
            }

            public DateTime birthday
            {
                get;
                set;

            }
            
            public string details
            {
                get;
                set;
            }
        }
        
       
        public Form1()
        {
            InitializeComponent();
            this.readContactsFromFile();
           
        }

        List<Contact> contacts = new List<Contact>();


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Shown(object sender, EventArgs e) //after app loads, shows who has birthday
        {
            foreach (var c in this.contacts)
            {
                if (c.birthday.Day == DateTime.Today.Day && c.birthday.Month == DateTime.Today.Month)
                {
                    MessageBox.Show("Ο/Η " + c.name + " έχει γενέθλια σήμερα!");
                }
            }
        }
        
      
        private void readContactsFromFile()
        {
            using (StreamReader reader = new StreamReader("contacts.txt"))
            {
                string line;
                string[] words;

                while ((line = reader.ReadLine()) != null)
                {
                    Contact c = new Contact();
                    words = line.Split(',');
                    c.name = words[0];
                    c.surname = words[1];
                    c.number = words[2];
                    c.mail = words[3];
                    c.address = words[4];
                    c.birthday = Convert.ToDateTime(words[5]);
                    c.details = words[6];
                    contacts.Add(c);
                    contactslist.Items.Add(c.name);
                    
                     
                }

                
            }
        }



        private void writeContactsToFile()
        {
            using (StreamWriter write = new StreamWriter("contacts.txt"))
            {
                foreach (var c in this.contacts)
                {
            
                    write.Write(c.name);
                    write.Write(",");
                    write.Write(c.surname);
                    write.Write(",");
                    write.Write(c.number);
                    write.Write(",");
                    write.Write(c.mail);
                    write.Write(",");
                    write.Write(c.address);
                    write.Write(",");
                    write.Write(c.birthday);
                    write.Write(",");
                    write.Write(c.details);
                    write.WriteLine();
                }
            }
        }
        
       
        public void Renew()
        {
            nametxt.Text = "";
            surnametxt.Text = "";
            numbertxt.Text = "";
            mailtxt.Text = "";
            addresstxt.Text = "";
            detailstxt.Text = "";
            birthdaytxt.Value = DateTime.Now;
        }
        public void Remove()
        {


                contacts.RemoveAt(contactslist.SelectedItems[0].Index);
                contactslist.Items.Remove(contactslist.SelectedItems[0]);
                this.writeContactsToFile(); 
           
        }

        private void addc_Click(object sender, EventArgs e)
        {
            if (!this.formIsValid())
            {
                return;
            }

            Contact c = new Contact();
            c.name = nametxt.Text;
            c.surname = surnametxt.Text;
            c.number = numbertxt.Text;
            c.mail = mailtxt.Text;
            c.address = addresstxt.Text;
            c.birthday = birthdaytxt.Value;
            c.details = detailstxt.Text;
            contacts.Add(c);
            contactslist.Items.Add(c.name);

            this.writeContactsToFile();
            Renew();
        }    
         
        private void contactslist_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (contactslist.SelectedItems.Count == 0)
            {
                return;
            }

            nametxt.Text = contacts[contactslist.SelectedItems[0].Index].name;
            surnametxt.Text = contacts[contactslist.SelectedItems[0].Index].surname;
            numbertxt.Text = contacts[contactslist.SelectedItems[0].Index].number;
            mailtxt.Text = contacts[contactslist.SelectedItems[0].Index].mail;
            addresstxt.Text = contacts[contactslist.SelectedItems[0].Index].address;
            detailstxt.Text = contacts[contactslist.SelectedItems[0].Index].details;
            birthdaytxt.Value = contacts[contactslist.SelectedItems[0].Index].birthday;
        }


        private void removec_Click(object sender, EventArgs e)
        {
            Remove();
            Renew();
        }


        private bool formIsValid()
        {

            if (this.nametxt.Text == (""))
            {
                MessageBox.Show("Εισάγετε Όνομα!");
                return false;
            }
            if (this.surnametxt.Text == (""))
            {
                MessageBox.Show("Εισάγετε Επώνυμο!");
                return false;
            }
            if (this.numbertxt.Text == (""))
            {
                MessageBox.Show("Εισάγετε Τηλέφωνο!");
                return false;
            }
            if (this.mailtxt.Text == (""))
            {
                MessageBox.Show("Εισάγετε Email!");
                return false;
            }

            if (!this.mailtxt.Text.Contains('@') || !this.mailtxt.Text.Contains('.'))
            {
                MessageBox.Show("Εισάγετε έγκυρη διεύθυνση email!");
                return false;

            }
            if (this.addresstxt.Text == (""))
            {
                MessageBox.Show("Εισάγετε Διεύθυνση!");
                return false;
            }
            if (this.birthdaytxt.Text == (""))
            {
                MessageBox.Show("Εισάγετε Ημερομηνία Γέννησης!");
                return false;

            }
            if (this.detailstxt.Text == (""))
            {
                MessageBox.Show("Εισάγετε Λεπτομέρειες!");
                return false;

            }
            return true;
        }

        private void savec_Click(object sender, EventArgs e)
        {
            if (!this.formIsValid())
            {
                return;
            }

            contacts[contactslist.SelectedItems[0].Index].name = nametxt.Text;
            contacts[contactslist.SelectedItems[0].Index].surname = surnametxt.Text;
            contacts[contactslist.SelectedItems[0].Index].number = numbertxt.Text;
            contacts[contactslist.SelectedItems[0].Index].address = addresstxt.Text;
            contacts[contactslist.SelectedItems[0].Index].details = detailstxt.Text;
            contacts[contactslist.SelectedItems[0].Index].mail = mailtxt.Text;
            contacts[contactslist.SelectedItems[0].Index].birthday = birthdaytxt.Value;
            contactslist.SelectedItems[0].Text = nametxt.Text;

            contactslist.SelectedItems[0].Text = nametxt.Text;
            this.writeContactsToFile();
            Renew();
        }

        private void numbertxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Εισάγετε μόνο αριθμούς!");
            }
        }

        

    }
        

        
        

   
}
