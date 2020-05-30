using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203199정주환_과제3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iData01 = int.Parse(textBox1.Text);
            int iData02 = int.Parse(textBox2.Text);
            string sData01 = textBox3.Text;
            if (sData01 == "==")
            {
                bool bData01 = iData01 == iData02;
                label1.Text = "숫자: " + iData01 + "와 숫자: " + iData02 + "관계연산자" + sData01 + "를 적용한 결과" + bData01;
            }
            else if (sData01 == "!=")
            {
                bool bData01 = iData01 != iData02;
                label1.Text = "숫자: " + iData01 + "와 숫자: " + iData02 + "관계연산자" + sData01 + "를 적용한 결과" + bData01;
            }
            else if (sData01 == ">")
            {
                bool bData01 = iData01 > iData02;
                label1.Text = "숫자: " + iData01 + "와 숫자: " + iData02 + "관계연산자" + sData01 + "를 적용한 결과" + bData01;
            }
            else if (sData01 == ">=")
            {       
                bool bData01 = iData01 >= iData02;
                label1.Text = "숫자: " + iData01 + "와 숫자: " + iData02 + "관계연산자" + sData01 + "를 적용한 결과" + bData01;
            }
            else if (sData01 == "<")
            {
                bool bData01 = iData01 < iData02;
                label1.Text = "숫자: " + iData01 + "와 숫자: " + iData02 + "관계연산자" + sData01 + "를 적용한 결과" + bData01;
            }
            else if (sData01 == "<=")
            {
                bool bData01 = iData01 <= iData02;
                label1.Text = "숫자: " + iData01 + "와 숫자: " + iData02 + "관계연산자" + sData01 + "를 적용한 결과" + bData01;
            }
            else
                label1.Text = "올바른 관계연산자를 입력하세요";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox3.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
