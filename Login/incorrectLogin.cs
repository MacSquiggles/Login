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
    public partial class incorrectLogin : UserControl
    {
        public incorrectLogin()
        {
            InitializeComponent();
        }

        private void tryAgainButton_Click(object sender, EventArgs e)
        {
            //Form i = this.FindForm();
            //i.Controls.Remove(i);
            mainScreen ms = new mainScreen();
            ms.Location = new Point(this.Width - ms.Width / 2, (this.Height - ms.Height) / 2);
            this.Controls.Add(ms);
        }
    }
}
