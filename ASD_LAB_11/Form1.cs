﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASD_LAB_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void start_Click(object sender, EventArgs e)
        {
            //string[] param = Task14.search(text1.Text);
            //text1.Text = param[0];
            logOut.Text += $"{KMP_L.search(text1.Text, text2.Text)}";
            //logOut.Text += KMP.KMPSearch(text1.Text, text2.Text);
        }
    }
}
