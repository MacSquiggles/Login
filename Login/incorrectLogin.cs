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
            Refresh();
            Form f = this.FindForm();
            f.Controls.Remove(this);

            mainScreen ms = new mainScreen();
            ms.Location = new Point((f.Width - ms.Width)/ 2, (f.Height - ms.Height) / 2);
            f.Controls.Add(ms);
        }
    }
}
