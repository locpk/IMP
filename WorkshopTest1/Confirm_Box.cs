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
    public partial class Confirm_Box : WorkshopTest1.BaseForm
    {
        public Confirm_Box()
        {
            InitializeComponent();
        }

        private void Confirm_Box_Load(object sender, EventArgs e)
        {

        }

        public DialogResult Show(string text)
        {
            message.Text = text;
            return this.ShowDialog();
        }

        private void no_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
