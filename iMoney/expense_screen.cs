using System;
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
    public partial class expense_screen : iMoney.BaseForm
    {
        string UN;
        public expense_screen(string username)
        {
            UN = username;
            InitializeComponent();
        }

        private void expense_screen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'monthly_reportDBDataSet.monthlyDB_Ex' table. You can move, or remove it, as needed.
            this.monthlyDB_ExTableAdapter.Fill(this.monthly_reportDBDataSet.monthlyDB_Ex);

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            //back to Menu
            Confirm_Box new_Confirm_Box = new Confirm_Box();
            DialogResult result = new_Confirm_Box.Show("Are you sure?");
            if (result == DialogResult.OK)
            {
                this.monthlyDB_ExTableAdapter.Insert(UN, "Expense", amount_picker.Value, save_date.Value.ToShortDateString());
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
                    frm.Show();
                    return;
                }
            }
        }

    }
}
