using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203202_최준혁_과제4번
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int iData01 = int.Parse(textBox1.Text);
                int iData02 = iData01 % 2;
                if (iData02 == 0)
                    label3.Text = "입력한 수" + iData01 + "은 짝수입니다";
                else
                    label3.Text = "입력한 수" + iData01 + "은 홀수입니다";
            }
            catch
            {
                label3.Text = "입력 문자열의 형식이 잘못되었습니다.";
            }
        }
    }
}
