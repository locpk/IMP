﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WorkshopTest1
{
    public partial class income_screen : WorkshopTest1.BaseForm
    {
        string UN;
        public income_screen(string username)
        {
            UN = username;
            InitializeComponent();
        }

        private void income_screen_Load(object sender, EventArgs e)
        {
            this.monthly_DS.Clear();
            // TODO: This line of code loads data into the 'monthly_DS.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.monthly_DS.Table);
            

           
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            
            


            //back to Menu
            Confirm_Box new_Confirm_Box = new Confirm_Box();
            DialogResult result = new_Confirm_Box.Show("Are you sure?");
            if (result == DialogResult.OK)
            {
               
                
                
               
                
                //
                this.Close();
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is Menu)
                    {
                        frm.Show();
                        return;
                    }
                }
            }
            else
            {
                this.Close();
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is Menu)
                    {
                        frm.Show();
                        return;
                    }
                }
            }

            
        }



        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Menu)
                {
                    frm.Show();
                    return;
                }
            }
        }

      
    }
}
