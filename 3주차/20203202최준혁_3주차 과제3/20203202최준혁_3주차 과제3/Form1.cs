﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203202최준혁_3주차_과제3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double dData01 = double.Parse(textBox1.Text) * 10;
                double dData02 = double.Parse(textBox2.Text) * 10;
                double dData03 = double.Parse(textBox3.Text) * 10;
                double dData04 = dData01 * dData02 * dData03;

                string sData01 = "직육면체 가로:" + dData01 + "mm 세로: " + dData02 + "mm 높이" + dData03 + "mm 의부피는 " + dData04 + "입니다";
                label7.Text = sData01;
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double dData01 = double.Parse(textBox1.Text);
                double dData02 = double.Parse(textBox2.Text);
                double dData03 = double.Parse(textBox3.Text);
                double dData04 = dData01 * dData02 * dData03;

                string sData01 = "직육면체 가로:" + dData01 + "cm 세로: " + dData02 + "cm 높이" + dData03 + "cm 의부피는 " + dData04 + "입니다";
                label7.Text = sData01;
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double dData01 = double.Parse(textBox1.Text)/ 100;
                double dData02 = double.Parse(textBox2.Text)/ 100;
                double dData03 = double.Parse(textBox3.Text)/ 100;
                double dData04 = dData01 * dData02 * dData03;

                string sData01 = "직육면체 가로:" + dData01 + "m 세로: " + dData02 + "m 높이" + dData03 + "m 의부피는 " + dData04 + "입니다";
                label7.Text = sData01;
            }
            catch
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label7.Text = "결과가 표시 되는 곳입니다";
        }
    }
}
