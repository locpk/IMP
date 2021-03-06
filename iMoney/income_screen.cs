﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace iMoney
{
    public partial class income_screen : iMoney.BaseForm
    {
        string UN;
        public income_screen(string username)
        {
            UN = username;
            InitializeComponent();
        }

        private void income_screen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'monthly_reportDBDataSet.monthlyDB_In' table. You can move, or remove it, as needed.
            this.monthlyDB_InTableAdapter.Fill(this.monthly_reportDBDataSet.monthlyDB_In,UN);

           

            

           
        }

        private void save_button_Click(object sender, EventArgs e)
        {

            //back to Menu
            Confirm_Box new_Confirm_Box = new Confirm_Box();
            DialogResult result = new_Confirm_Box.Show("Are you sure?");
            if (result == DialogResult.OK)
            {
                this.monthlyDB_InTableAdapter.Insert1(UN, "Income", amount_picker.Value, save_date.Value.ToString(),remark_box.Text);
                //clear all boxes
                remark_box.Text = null;
                amount_picker.Value = 0;
            }
        }



        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Menu)
                {
                    frm.Activate();
                    return;
                }
            }
        }




      
    }
}
