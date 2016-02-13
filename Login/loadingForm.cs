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
            for (int x = 0; x < 100; x = x+10)
            {
                loadingBar.Value = loadingBar.Value + 10;
                Thread.Sleep(100);
            }
            if (loadingBar.Value >= 100)
            {
               // Form l = this.FindForm();
               // l.Controls.Remove(this);

                if (Form1.usernameRight == true && Form1.passwordRight == true)
                {
                    correctForm cf = new correctForm();
                    cf.Location = new Point(this.Width - cf.Width / 2, (this.Height - cf.Height) / 2);
                    this.Controls.Add(cf);
                }
                else
                {
                    incorrectLogin il = new incorrectLogin();
                    il.Location = new Point(this.Width - il.Width / 2, (this.Height - il.Height) / 2);
                    this.Controls.Add(il);
                }
            }
        }
    }
}
