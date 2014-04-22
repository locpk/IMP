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
    public partial class report_screen : iMoney.BaseForm
    {
        string UN;
        public report_screen(string username)
        {
            UN = username;
            InitializeComponent();
        }

        private void report_screen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'monthly_reportDBDataSet.monthlyDB_Ex' table. You can move, or remove it, as needed.
            this.monthlyDB_ExTableAdapter.Fill(this.monthly_reportDBDataSet.monthlyDB_Ex,UN);
            // TODO: This line of code loads data into the 'monthly_reportDBDataSet.monthlyDB_In' table. You can move, or remove it, as needed.
            this.monthlyDB_InTableAdapter.Fill(this.monthly_reportDBDataSet.monthlyDB_In,UN);

            this.reportViewer1.RefreshReport();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Menu)
                {
                    frm.Show();

                    this.Activate();
                    return;
                }
            }
        }

        
    }
}
