﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Login
{
    public partial class Form1 : Form
    {
        public static string userName = "mquigs";
        public static string passwordString = "hello";
        public static bool passwordRight = false;
        public static bool usernameRight = false;

        public Form1()
        {
            InitializeComponent();
            mainScreen ms = new mainScreen();
            ms.Location = new Point(this.Width - ms.Width / 2, (this.Height - ms.Height) / 2);
            this.Controls.Add(ms);
        }

    }
}
