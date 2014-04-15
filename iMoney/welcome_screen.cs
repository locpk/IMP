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
    public partial class welcome_screen : iMoney.BaseForm
    {
        public welcome_screen()
        {
            InitializeComponent();
        }

        private void welcome_screen_Load(object sender, EventArgs e)
        {
            this.ActiveControl = usernamebox;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Confirm_Box new_Confirm_Box = new Confirm_Box();
            DialogResult result = new_Confirm_Box.Show("Are you sure to exit?");
            if (result == DialogResult.OK)
            {
                this.Close();
            }
            
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            
            register_screen new_register_screen = new register_screen();
            new_register_screen.Show();
        }

        private void login_button_Click(object sender, EventArgs e)
        {

            //test for empty input
            if(usernamebox.TextLength == 0)
            {
                Confirm_Box new_Confirm_Box = new Confirm_Box();
                DialogResult result = new_Confirm_Box.Show("Please enter your username!");
            }
            else if (Password.TextLength == 0)
            {
                Confirm_Box new_Confirm_Box = new Confirm_Box();
                DialogResult result = new_Confirm_Box.Show("Please enter your passcode!");
            }
            else
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

                        if (username.InnerText.Equals(usernamebox.Text))
                        {
                            if (username.SelectSingleNode("@Password").Value == GetHashString(Password.Text + "440"))
                            {
                                this.Hide();
                                Form menu = new Menu(usernamebox.Text);
                                usernamebox.Clear();
                                Password.Clear();
                                menu.Show();
                                return;
                            }
                        }

                    }
                    Confirm_Box new_Confirm_Box = new Confirm_Box();
                    DialogResult result = new_Confirm_Box.Show("Username or Password is wrong!");
                    usernamebox.Clear();
                    Password.Clear();
                }
                else
                {
                    Confirm_Box new_Confirm_Box = new Confirm_Box();
                    DialogResult result = new_Confirm_Box.Show("Username or Password is wrong!");
                    usernamebox.Clear();
                    Password.Clear();
                }
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

        private void usernamebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Confirm_Box new_Confirm_Box = new Confirm_Box();
            DialogResult result = new_Confirm_Box.Show("So sad that making the final project \n without Benny and Roy! \n 不是说好做彼此的天使吗 :)");
        }

        //end of hash functions
    }
}
