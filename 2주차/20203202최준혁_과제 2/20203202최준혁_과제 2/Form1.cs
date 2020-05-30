using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203202최준혁_과제_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sData03 = "유선 : 055-321-0897";
            string sData04 = "무선 : 010-3671-3392";

            label4.Text = sData03;
            label3.Text = sData04;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sData01 = "성명 : 최준혁";
            string sData02 = "학번 :20203202";

            label1.Text = sData01;
            label2.Text = sData02;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
        }
    }
}
