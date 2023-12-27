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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminform = new AdminForm();
            adminform.Show(); 
        }

        private void buttonPasseng_Click(object sender, EventArgs e)
        {
            this.Hide();
            ticketForm ticketform = new ticketForm();
            ticketform.Show();
        }
    }
}
