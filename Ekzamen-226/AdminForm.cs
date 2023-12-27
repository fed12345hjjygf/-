using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekzamen_226
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();

            this.textPassword.AutoSize=false;
            this.textPassword.Size = new Size(this.textPassword.Size.Width, 31);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();

        }

        private void adminOpen_Click(object sender, EventArgs e)
        {
            this.Hide();
            redactForm redactForm = new redactForm();
            redactForm.Show();
        }
    }
}
