using System;
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
    public partial class Menu : WorkshopTest1.BaseForm
    {
        string UN;
        public Menu(string username)
        {
            UN = username;
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Close();

            foreach (Form frm in Application.OpenForms)
            {
                if (frm is welcome_screen)
                {
                    frm.Show();
                   
                }
            }
        }

        private void income_button_Click(object sender, EventArgs e)
        {
            
            Form income = new income_screen(UN);
            income.Show();
            this.Hide();
        }

        private void report_button_Click(object sender, EventArgs e)
        {
            
            Form report = new report_screen(UN);
            report.Show();
            this.Hide();
        }

        private void expense_button_Click(object sender, EventArgs e)
        {

        }
    }
}
