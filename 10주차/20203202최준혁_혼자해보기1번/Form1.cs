using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203202최준혁_혼자해보기1번
{
    public partial class Form1 : Form
    {
        int Win = 0;
        int Draw = 0;
        int Lose = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "가위";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "바위";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "보";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string user_input = textBox1.Text;
                if (user_input == "가위" || user_input == "바위" || user_input == "보")
                {
                    string ResultStr = "";
                    System.Random ranNum = new System.Random();
                    int system_num = ranNum.Next(1, 4);
                    string system_input = "";
                    if (system_num == 1)
                        system_input = "가위";
                    else if (system_num == 2)
                        system_input = "바위";
                    else if (system_num == 3)
                        system_input = "보";

                    if (user_input == "가위" && system_input == "가위")
                    {
                        Draw++;
                        ResultStr = "무승부";
                    }
                    else if (user_input == "바위" && system_input == "바위")
                    {
                        Draw++;
                        ResultStr = "무승부";
                    }
                    else if (user_input == "보" && system_input == "보")
                    {
                        Draw++;
                        ResultStr = "무승부";
                    }
                    else if (user_input == "가위" && system_input == "보")
                    {
                        Win++;
                        ResultStr = "User 승";
                    }
                    else if (user_input == "바위" && system_input == "가위")
                    {
                        Win++;
                        ResultStr = "User 승";
                    }
                    else if (user_input == "보" && system_input == "바위")
                    {
                        Win++;
                        ResultStr = "User 승";
                    }
                    else if (user_input == "가위" && system_input == "바위")
                    {
                        Lose++;
                        ResultStr = "User 패";
                    }
                    else if (user_input == "바위" && system_input == "보")
                    {
                        Lose++;
                        ResultStr = "User 패";
                    }
                    else if (user_input == "보" && system_input == "가위")
                    {
                        Lose++;
                        ResultStr = "User 패";
                    }
                    label2.Text = "User는 -> " + user_input + "\n\nSystem은 -> " + system_input + "\n\n결과는 -> " + ResultStr;
                    textBox1.Text = "";
                    textBox1.Focus();
                }
                else
                {
                    label2.Text = "입력값이 '가위, 바위, 보'\n중 하나가 아니라서 패 처리합니다.";
                }
                label3.Text = "총 전적 : " + Win + "승 " + Draw + "무 " + Lose + "패";
            
            }
            catch
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
