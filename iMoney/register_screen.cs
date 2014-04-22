//Tom Chan
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Security.Cryptography;
//XML
using System.Xml;
using System.Xml.XPath;
using System.IO;
using System.Collections;

namespace iMoney
{
    public partial class register_screen : Form
    {
        Confirm_Box messagebox = new Confirm_Box();
        public register_screen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = cancel_button;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            RadioButton[] radioButtons = new RadioButton[] { malebutton, femalebutton };

            if (string.IsNullOrEmpty(this.Password.Text))
            {
                this.errorProvider1.SetError(this.Password, "Must have an Uppercase letter");
                return;
            }

            if (!radioButtons.Any(rb => rb.Checked))
                // No radio buttons are checked
            {

                messagebox.Show("You need to choose gender!");
                errorProvider1.SetError(this.femalebutton,"You need to choose gender!");
                return;
            }

            //file name
            string filename = "info.xml";
            // if the file exists, we'll add the product into the xml
            if (File.Exists(filename))
            {

               

                //create new instance of XmlDocument
                XmlDocument doc = new XmlDocument();

                // Load an XML file into the XmlDocument object. 
                    doc.Load(filename);
               

                //create node and add value
                XmlNode node = doc.CreateNode(XmlNodeType.Element, "Account", null);
                //node.InnerText = "this is new node";

                XmlNode nodeUName = doc.CreateElement("Username");
                nodeUName.InnerText = usernamebox.Text;

                XmlNode nodeFName = doc.CreateElement("First_Name");
                nodeFName.InnerText = First_name.Text;
               
                XmlNode nodeLName = doc.CreateElement("Last_Name");
                nodeLName.InnerText = Last_name.Text;

                XmlNode nodePh = doc.CreateElement("Phone_Number");
                nodePh.InnerText = phone_selector.Text + Phone_number.Text;

                
                XmlAttribute pwd = doc.CreateAttribute("Password");
                pwd.Value = GetHashString(Password.Text + "440");
                nodeUName.Attributes.Append(pwd);

                
                XmlNode nodeEmail = doc.CreateElement("Email");
                nodeEmail.InnerText = Email.Text;

                XmlNode nodeBirday = doc.CreateElement("Birthday");
                nodeBirday.InnerText = birthday.SelectionEnd.ToShortDateString();

                //gender
                XmlNode nodeGender = doc.CreateElement("Gender");
                bool isChecked = malebutton.Checked;
                if (isChecked)
                    nodeGender.InnerText = malebutton.Text;
                else
                    nodeGender.InnerText = femalebutton.Text;
                

                //add to parent node
                node.AppendChild(nodeUName);
                node.AppendChild(nodeFName);
                node.AppendChild(nodeLName);
                node.AppendChild(nodePh);
                node.AppendChild(nodeEmail);
                node.AppendChild(nodeBirday);
                node.AppendChild(nodeGender);

                

                //add to elements collection
                doc.DocumentElement.AppendChild(node);

                //save back
                doc.Save(filename);

                
                messagebox.Show("Saved successfully!");

                //clear input fields
                usernamebox.Text = null;
                First_name.Text = null;
                Last_name.Text = null;
                Phone_number.Text = null;
                Email.Text = null;
                Password.Text = null;
                malebutton.Checked = false;
                femalebutton.Checked = false;

            }
            else //The file does not exist, we'll create it
            {
                XmlTextWriter writer = new XmlTextWriter("info.xml", System.Text.Encoding.UTF8);
                writer.WriteStartDocument(true);
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 2;
                writer.WriteStartElement("Table");
                string gender = "";
                bool isChecked = malebutton.Checked;
                if(isChecked)
                  gender=malebutton.Text;
                else
                  gender=femalebutton.Text;
                createNode(usernamebox.Text, First_name.Text, Last_name.Text, phone_selector.Text + Phone_number.Text, GetHashString(Password.Text + "440"), Email.Text, birthday.SelectionEnd.ToShortDateString(), gender, writer);
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();

                messagebox.Show("Saved successfully!");
                //clear input fields
                usernamebox.Text = null;
                First_name.Text = null;
                Last_name.Text = null;
                Phone_number.Text = null;
                Email.Text = null;
                Password.Text = null;
                malebutton.Checked = false;
                femalebutton.Checked = false;
                
            }
        }

        private void createNode(string un, string fn, string ln, string ph, string pw,string em, string bir,string gen, XmlTextWriter writer)
        {
            writer.WriteStartElement("Account");
            writer.WriteStartElement("Username");
            writer.WriteAttributeString("Password", pw);
            writer.WriteString(un);
            writer.WriteEndElement();
            writer.WriteStartElement("First_Name");
            writer.WriteString(fn);
            writer.WriteEndElement();
            writer.WriteStartElement("Last_Name");
            writer.WriteString(ln);
            writer.WriteEndElement();
            writer.WriteStartElement("Phone_Number");
            writer.WriteString(ph);
            writer.WriteEndElement();
            writer.WriteStartElement("Email");
            writer.WriteString(em);
            writer.WriteEndElement();
            writer.WriteStartElement("Birthday");
            writer.WriteString(bir);
            writer.WriteEndElement();
            writer.WriteStartElement("Gender");
            writer.WriteString(gen);
            writer.WriteEndElement();
            writer.WriteEndElement();
        }

        //hashing a password without salt
        public static byte[] GetHash(string inputString)
        {
            HashAlgorithm algorithm = SHA1.Create();  
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        public static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }

        //end of hash functions



        private void Phone_number_Leave(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(this.Phone_number.Text))
            {
                
                this.errorProvider1.SetError(this.Phone_number, "You must provide your phone number!");
            }
            else if (!Regex.IsMatch(Phone_number.Text, @"^[0-9]"))
            {
                
                this.errorProvider1.SetError(this.Phone_number, "Phone number can only be numbers");
                messagebox.Show("Phone number can only be numbers");
            }
            
        }


        private void usernamebox_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;

            //create new instance of XmlDocument
            XmlDocument doc = new XmlDocument();
            if (File.Exists("info.xml"))
            {
                // Load an XML file into the XmlDocument object. 
                doc.Load("info.xml");
                XmlElement root = doc.DocumentElement;
                XmlNodeList nodeList = root.GetElementsByTagName("Username");
                IEnumerator ienum = nodeList.GetEnumerator();
                while (ienum.MoveNext())
                {
                    XmlNode username = (XmlNode)ienum.Current;

                    if (username.InnerText.Equals(usernamebox.Text))
                    {
                        this.errorProvider1.SetError(this.usernamebox, "The user is existed!");
                        cancel = true;
                    }
                }
            }
            // validate the username it can only consist of letters and numbers
            if (string.IsNullOrEmpty(this.usernamebox.Text))
            {
                //This control fails validation: Name cannot be empty.
                cancel = true;
                this.errorProvider1.SetError(this.usernamebox, "You must provide a Username!");
            }
            else if (string.IsNullOrWhiteSpace(usernamebox.Text))
            {
                cancel = true;
                this.errorProvider1.SetError(this.usernamebox, "You must provide your first name!");
            }
            else if (!Regex.IsMatch(usernamebox.Text, @"^[a-zA-Z0-9]"))
            {
                cancel = true;
                this.errorProvider1.SetError(this.usernamebox, "Username can only combined by letters and numbers");
            }
            e.Cancel = cancel;
        }

        private void usernamebox_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(this.usernamebox, string.Empty);
        }

        private void First_name_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;
            if (string.IsNullOrEmpty(this.First_name.Text))
            {
                //This control fails validation: Name cannot be empty.
                cancel = true;
                this.errorProvider1.SetError(this.First_name, "You must provide your first name!");
            }
            else if (string.IsNullOrWhiteSpace(First_name.Text))
            {
                cancel = true;
                this.errorProvider1.SetError(this.First_name, "You must provide your first name!");
            }
            else if (!Regex.IsMatch(First_name.Text, @"^[a-zA-Z]"))
            {
                cancel = true;
                this.errorProvider1.SetError(this.First_name, "Name can only be letters");
            }
            e.Cancel = cancel;

        }

        private void First_name_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(this.First_name, string.Empty);
        }

        private void Last_name_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;
            if (string.IsNullOrEmpty(this.Last_name.Text))
            {
                //This control fails validation: Name cannot be empty.
                cancel = true;
                this.errorProvider1.SetError(this.Last_name, "You must provide your Last name!");
            }
            else if (string.IsNullOrWhiteSpace(Last_name.Text))
            {
                cancel = true;
                this.errorProvider1.SetError(this.Last_name, "You must provide your Last name!");
            }
            else if (!Regex.IsMatch(Last_name.Text, @"^[a-zA-Z]"))
            {
                cancel = true;
                this.errorProvider1.SetError(this.Last_name, "Name can only be letters");
            }
            e.Cancel = cancel;
        }

        private void Last_name_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(this.Last_name, string.Empty);
        }

        //Email validation
        private void Email_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;
            try
            {
                MailAddress m = new MailAddress(Email.Text);
                
            }
            catch (FormatException)
            {
                cancel = true;
                this.errorProvider1.SetError(this.Email, "Email Address invalided");
            }
            e.Cancel = cancel;
        }

        private void Email_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(this.Email, string.Empty);
        }

        private void Password_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;
            if (!Regex.IsMatch(Password.Text, @"[A-Z]"))
            {
                cancel = true;
                this.errorProvider1.SetError(this.Password, "Must have an Uppercase letter");
            }
            e.Cancel = cancel;
        }

        private void Password_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(this.Email, string.Empty);
        }


        private void usernamebox_TextChanged(object sender, EventArgs e)
        {
            First_name.Text = null;
            Last_name.Text = null;
            Phone_number.Text = null;
            Email.Text = null;
            Password.Text = null;
            malebutton.Checked = false;
            femalebutton.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();

            foreach (Form frm in Application.OpenForms)
            {
                if (frm is welcome_screen)
                {
                    frm.Activate();
                    return;
                }
            }
        }

        private void confirmPW_Validating(object sender, CancelEventArgs e)
        {

             bool cancel = false;
            if (confirmPW.Text != Password.Text)
            {
                cancel = true;
                this.errorProvider1.SetError(this.confirmPW, "Passwords don't match!");
            }
            
            e.Cancel = cancel;
        }

        private void confirmPW_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(this.confirmPW, string.Empty);
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        



        
    }
}
