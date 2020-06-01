using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203202_최준혁_과제3
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
            {   int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int sum = 0; string sOutPut = "";
                if( num1 <= num2)
                {
                    if(num1 > 1 && num1 < 10)
                    {
                        if (num2 > 1 && num2 < 10)
                        {
                            sOutPut = "구구단" + num1 + "부터" + num2 + "단 까지 입니다 \n\n";
                            for (int j = num1; j <= num2; j++)
                            {                              
                                for (int i = 2; i <= 9; i++)
                                {
                                    sum = i * j;
                                    sOutPut += j + " * " + i + " = " + sum + "\n";
                                }
                                sOutPut += "\n";
                            }
                            label4.Text = sOutPut;
                        }
                        else
                        {
                            label4.Text = "2~9사이의 수를 입력하세요";
                        }
                    }
                    else
                    {
                        label4.Text = "2~9사이의 수를 입력하세요";
                    }
                }
                else
                {
                    label4.Text = "시작 단수가 마지막 단수보다 작거나 같아야 합니다 ";
                }

            }
            catch
            {
                label4.Text = "입력 문자열 형식이 잘못되었습니다";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
