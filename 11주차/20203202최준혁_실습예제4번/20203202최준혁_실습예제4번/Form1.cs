﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203202최준혁_실습예제4번
{
    public partial class Form1 : Form
    {
        string[] sUnacceptableWords;
        public Form1()
        {
            InitializeComponent();
            sUnacceptableWords = new string[4];
            sUnacceptableWords[0] = "바보";
            sUnacceptableWords[1] = "메롱";
            sUnacceptableWords[2] = "님아";
            sUnacceptableWords[3] = "8억";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool bVaild = true;
            string sAllArticle = textBox1.Text;
            foreach(string sUAW in sUnacceptableWords)
            {
                if(sAllArticle.IndexOf(sUAW) >=0)
                {
                    bVaild = false;
                    string twp = sUAW + "은(는) 금지어입니다";
                    MessageBox.Show(twp,"결과");
                    break;
                }
            }
            if (bVaild == true)
                MessageBox.Show("정상적인 게시물입니다", "결과");
        }
    }
}
