﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swiat_alkoholi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int data = int.Parse(dateTimePicker1.Value.ToString("yyyyMMdd"));
            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int wiek = ((now - data) / 10000);
            if (wiek >= 18)
            {
                panel1.Visible = true;
                button2.Visible = true;
            }
            else
            {
                panel1.Visible = false;
                button2.Visible = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Length != 0)
            {
                richTextBox1.Text += comboBox1.Text;
                richTextBox1.Text += ", ";
            }
        }
    }
}
