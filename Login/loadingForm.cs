using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Login
{
    public partial class loadingForm : UserControl
    {
        public loadingForm()
        {
            InitializeComponent();
            loadingBar.Value = 0;

        }

        private void loadingForm_Load_1(object sender, EventArgs e)
        {

            Refresh();
            Form f = this.FindForm();

            while (loadingBar.Value < loadingBar.Maximum)
            {
                loadingBar.Value = loadingBar.Value + 1;
                Thread.Sleep(10);
                Refresh();
            }

            if (loadingBar.Value >= loadingBar.Maximum)
            {
                f.Controls.Remove(this);
                if (Form1.usernameRight == true && Form1.passwordRight == true)
                {
                    correctForm cf = new correctForm();
                    cf.Location = new Point((f.Width - cf.Width) / 2, (f.Height - cf.Height) / 2);
                    f.Controls.Add(cf);
                    Refresh();
                }

                else
                {
                    incorrectLogin il = new incorrectLogin();
                    il.Location = new Point((f.Width - il.Width)/ 2, (f.Height - il.Height) / 2);
                    f.Controls.Add(il);
                    Refresh();
                }
                   
            }
        }
    }
}
