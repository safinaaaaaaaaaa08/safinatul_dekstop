﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace safinatul_dekstop
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form14 form = new Form14();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form13 form = new Form13();
            form.ShowDialog();
        }
    }
}
