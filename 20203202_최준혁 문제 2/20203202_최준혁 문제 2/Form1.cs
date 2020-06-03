using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203202_최준혁_문제_2
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
                string user01 = textBox1.Text;
                string user02 = textBox2.Text;
                if (user01 == "가위")
                {
                    if(user02 == "보")
                        label6.Text = "user1 은 → 가위" + "\n" + "\n" + "user2 는 → 보 " + "\n" + "\n" + "결과는 → user1 승 ";
                   else if (user02 == "가위")
                        label6.Text = "user1 은 → 가위" + "\n" + "\n" + "user2 는 → 가위 " + "\n" + "\n" + "결과는 → 무승부";
                   else if (user02 == "바위")
                        label6.Text = "user1 은 → 가위" + "\n" + "\n" + "user2 는 → 바위 " + "\n" + "\n" + "결과는 → user1패배";
                    
                }     
                else if (user01 == "바위")
                {
                    if(user02 == "보")
                        label6.Text = "user1 은 → 바위" + "\n" + "\n" + "user2 는 → 보 " + "\n" + "\n" + "결과는 → user1 패배 ";
                   else if (user02 == "가위")
                        label6.Text = "user1 은 → 바위" + "\n" + "\n" + "user2 는 → 가위 " + "\n" + "\n" + "결과는 → user1 승리";
                    else if (user02 == "바위")
                        label6.Text = "user1 은 → 바위" + "\n" + "\n" + "user2 는 → 바위 " + "\n" + "\n" + "결과는 → 무승부";
                }
                else if (user01 == "보")
                {
                    if (user02 == "보")
                        label6.Text = "user1 은 → 보" + "\n" + "\n" + "user2 는 → 보 " + "\n" + "\n" + "결과는 → 무승부 ";
                    else if (user02 == "가위")
                        label6.Text = "user1 은 → 보" + "\n" + "\n" + "user2 는 → 가위 " + "\n" + "\n" + "결과는 → user1 패배";
                    else if (user02 == "바위")
                        label6.Text = "user1 은 → 보" + "\n" + "\n" + "user2 는 → 바위 " + "\n" + "\n" + "결과는 → user1 승리";
                }
                  else
                    label6.Text = "입력값이 '가위,바위,보' 중 하나가 아닙니다 다시입력하세요";
            }
            catch
            {
               
            }
        }
    }
}
