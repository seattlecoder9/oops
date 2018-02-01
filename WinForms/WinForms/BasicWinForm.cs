﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class BasicWinForm : Form
    {
        public BasicWinForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;   // Set the 'ReadOnly' property to true.
            textBox1.Text = "Click on Crandall's Face to start the program.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "This field will be updated with the program's output.";
        }
    }
}
