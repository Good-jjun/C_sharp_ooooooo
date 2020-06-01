using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203202_최준혁_혼자해보기_1번
{
    public partial class Form1 : Form
    {
        double dResult = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dPlus = double.Parse(textBox1.Text);
            dResult += dPlus;
            label1.Text = dResult.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double dMinus = double.Parse(textBox1.Text);
            dResult -= dMinus;
            label1.Text = dResult.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double dMultil = double.Parse(textBox1.Text);
            dResult *= dMultil;
            label1.Text = dResult.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double dDiv = double.Parse(textBox1.Text);
            if(dDiv != 0)
            {
                dResult = dResult / dDiv;
                label1.Text = dResult.ToString();

            }
            else
            {
                label1.Text = "0 으로 나눌수 없습니다";
                textBox1.Focus();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dResult = 0;
            textBox1.Text = "";
            label1.Text = dResult.ToString();
            label1.Text = "결과가 표시 되는 곳 입니다";
            textBox1.Focus();
        }
    }
}
