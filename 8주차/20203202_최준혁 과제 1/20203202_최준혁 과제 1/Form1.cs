using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203202_최준혁_과제_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                uint iData01 = uint.Parse(textBox1.Text);
                uint iData02 = uint.Parse(textBox2.Text);
                if (iData01 >= iData02)
                {
                    uint iData_Sum = 0;
                    double iData_Sum2 = 1;
                    for (uint i = 1; i <= iData01; i = i + iData02)
                    {
                        iData_Sum = iData_Sum + i;   //합
                        iData_Sum2 = iData_Sum2 * i; //곱

                    }
                    label4.Text = " i 부터 입력된 최대값 : " + iData01
                    + "까지 증가 값 : " + iData02 + " 로 반복한 결과 \n\n"
                    + "<< i 의 더하기 합계 값 :" + iData_Sum + ">>\n\n"
                     + "<< i 의 곱하기 결과 값 :" + iData_Sum2 + ">>";



                }
                else
                {
                    label4.Text = "증가값은 최대값보다 작은 수를 입력하세요";
                }
            }
            catch
            {
                label4.Text = "입력된 문자열의 형식이 잘못 되었습니다 \n 다시입력하세요!";
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label4.Text = "결과가 나오는 곳입니다";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
