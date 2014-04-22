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
    public partial class Change_Password : BaseForm
    {
        Confirm_Box new_Confirm_Box = new Confirm_Box();
        public Change_Password()
        {
            InitializeComponent();
        }

        private void Change_Password_Load(object sender, EventArgs e)
        {
            this.ActiveControl = username_box;
        }

        private void exit_button_Click(object sender, EventArgs e)
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

        private void save_button_Click(object sender, EventArgs e)
        {
            //create new instance of XmlDocument
            XmlDocument doc = new XmlDocument();
            string filename = "info.xml";
            // Load an XML file into the XmlDocument object. 
            if (File.Exists(filename))
            {
                doc.Load(filename);
                XmlElement root = doc.DocumentElement;
                XmlNodeList nameList = root.GetElementsByTagName("Username");
                IEnumerator Nenum = nameList.GetEnumerator();
                while (Nenum.MoveNext())
                {
                    XmlNode username = (XmlNode)Nenum.Current;

                    if (username.InnerText.Equals(username_box.Text))
                    {
                        if (username.SelectSingleNode("@Password").Value == GetHashString(oldPW.Text + "440"))
                        {
                            username.SelectSingleNode("@Password").Value = GetHashString(newPW.Text + "440");
                            doc.Save("info.xml");
                            DialogResult result = new_Confirm_Box.Show("Changed Sucessfully!");
                            if (result == DialogResult.OK)
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
                        }
                    }
                }
                new_Confirm_Box.Show("Username or Password is wrong!");
                username_box.Clear();
                oldPW.Clear();
                newPW.Clear();

            }
            else
            {
                new_Confirm_Box.Show("XML is not found!");

            }

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
        private void newPW_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;
            if (!Regex.IsMatch(newPW.Text, @"[A-Z]"))
            {
                cancel = true;
                this.errorProvider1.SetError(this.newPW, "Must have an Uppercase letter");
            }
            e.Cancel = cancel;
        }

        private void newPW_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(this.newPW, string.Empty);
        }
      
    }

}
