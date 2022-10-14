﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace RidiciStriktury09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pocet = 0;
            int soucet = 0;

            foreach (Control ctrl in groupBox1.Controls)
            {

                if (ctrl is TextBox)
                {
                    pocet++;
                    soucet += int.Parse(ctrl.Text);
                }
                else if (ctrl is Label)
                {
                    ctrl.Text = listBox1.SelectedItem.ToString();
                }
            }
            MessageBox.Show("Aritmetický průměr je: " + (double)soucet / pocet);
        }
    }
}
