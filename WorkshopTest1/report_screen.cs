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
    public partial class report_screen : WorkshopTest1.BaseForm
    {
        string UN;
        public report_screen(string username)
        {
            UN = username;
            InitializeComponent();
        }

        private void report_screen_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'monthly_DS.Table' table. You can move, or remove it, as needed.
            
            this.TableTableAdapter.FillBy(this.monthly_DS.Table,UN);
           
            this.reportViewer1.RefreshReport();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Menu)
                {
                    frm.Show();
                    this.monthly_DS.Clear();
                    this.Close();
                    return;
                }
            }
        }

        
    }
}
