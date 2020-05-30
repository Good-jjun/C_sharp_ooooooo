using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203202최준혁_과제4
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
                int num = int.Parse(textBox1.Text);
                if (textBox1.Text !="")
                {
                    switch (num)
                    {
                        case 1:
                            label3.Text = " 입력값 " + num + "→" + "January";
                            break;
                        case 2:
                            label3.Text = " 입력값 " + num + "→" + "February";
                            break;
                        case 3:
                            label3.Text = " 입력값 " + num + "→" + "March";
                            break;
                        case 4:
                            label3.Text = " 입력값 " + num + "→" + "April";
                            break;
                        case 5:
                            label3.Text = " 입력값 " + num + "→" + "May";
                            break;
                        case 6:
                            label3.Text = " 입력값 " + num + "→" + "June";
                            break;
                        case 7:
                            label3.Text = " 입력값 " + num + "→" + "July";
                            break;
                        case 8:
                            label3.Text = " 입력값 " + num + "→" + "Agust";
                            break;
                        case 9:
                            label3.Text = " 입력값 " + num + "→" + "September";
                            break;
                        case 10:
                            label3.Text = " 입력값 " + num + "→" + "October";
                            break;
                        case 11:
                            label3.Text = " 입력값 " + num + "→" + "November";
                            break;
                        case 12:
                            label3.Text = " 입력값 " + num + "→" + "December";
                            break;
                        default:
                            label3.Text = "해당하는 Month가 없으니" + "\n" + "1~ 12 사이의 숫자를 입력하세요";
                            break;
                    }
                }
                else
                {
                    textBox1.Text = "숫자를 입력하세요!";
                }
              
            }

            catch
            {
                textBox1.Text = "입력문자 형식이 잘못되었습니다";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
