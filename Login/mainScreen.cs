using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class mainScreen : UserControl
    {

        public mainScreen()
        {
            InitializeComponent();
            passwordBox.Text = "";
            usernameBox.Text = "";
            Form1.passwordRight = false;
            Form1.usernameRight = false;
            passwordBox.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text == Form1.userName)
            {
                Form1.usernameRight = true;
            }
            if (passwordBox.Text == Form1.passwordString)
            {
                Form1.passwordRight = true;
            }

            Form f = this.FindForm();
            f.Controls.Remove(this);

            loadingForm lf = new loadingForm();
            lf.Location = new Point((f.Width - lf.Width) / 2, (f.Height - lf.Height) / 2);
            f.Controls.Add(lf);
        }
    }
}
