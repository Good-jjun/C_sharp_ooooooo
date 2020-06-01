﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203202_최준혁_과제_4
{
    public partial class Form1 : Form
    {
        int count = 0;
        double dResult = 0;
        bool bFirsttime = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                double dPlus = double.Parse(textBox1.Text);
                count++;
                if(bFirsttime)
                {
                    label1.Text = "수행단계 :" + "0 +" +  dPlus;
                    bFirsttime = false;
                }
                else
                {
                    label1.Text = label1.Text + " + " + dPlus;
                }
                dResult += dPlus;
                label2.Text = " 계산결과: " + dResult.ToString();
                textBox1.Text = "";
                textBox1.Focus();
                label3.Text = "계산 수행 횟수 " + count;
            }
            catch
            {

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                double dMinus = double.Parse(textBox1.Text);
                count++;
                if (bFirsttime)
                {
                    label1.Text = "수행단계 :" + "0 +" + dMinus;
                    bFirsttime = false;
                }
                else
                {
                    label1.Text = label1.Text + " - " + dMinus;
                }
                dResult -= dMinus;
                label2.Text = "계산결과: " + dResult.ToString();
                textBox1.Text = "";
                textBox1.Focus();
                label3.Text = "계산 수행 횟수 " + count;
            }
            catch
            {
                label2.Text = "입력된 문자열 형식이 잘못되었습니다";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                double dPlus = double.Parse(textBox1.Text);
                count++;
                if (bFirsttime)
                {
                    label1.Text = "수행단계 :" + "0 *" + dPlus;
                    bFirsttime = false;
                }
                else
                {
                    label1.Text = label1.Text + " * " + dPlus;
                }
                dResult *= dPlus;
                label2.Text = "계산결과: " + dResult.ToString();
                textBox1.Text = "";
                textBox1.Focus();
                label3.Text = "계산 수행 횟수 " + count;
            }
            catch
            {
                label2.Text = "입력된 문자열 형식이 잘못되었습니다";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label1.Text = "수행단계:";
            label2.Text = "계산결과: " + "결과가 나오는 곳입니다!";
            label3.Text = "계산 수행 횟수";
            textBox1.Focus();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            try
            {
                double dDivInput = double.Parse(textBox1.Text);
                count++;
                if (bFirsttime == true)
                {
                    label1.Text = "수행단계: 0 / " + dDivInput;
                    bFirsttime = false;
                }
                else
                {
                    label1.Text = label1.Text + " / " + dDivInput;
                }
                dResult /= dDivInput;
                label2.Text = "계산결과: " + dResult.ToString();
                label3.Text = "계산 수행 횟수 " + count;
                textBox1.Text = "";
                textBox1.Focus();
            }
            catch
            {
                label2.Text = "입력된 문자열 형식이 잘못 되었습니다";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
