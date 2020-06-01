using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _202023202최준혁_실습예제_3번
{
    public partial class Form1 : Form
    {
        int iGData01 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                int iMaxNum = int.Parse(textBox1.Text);
                if(iMaxNum <= 50000 && iMaxNum >= 2)
                {
                    int Sum = 0;
                    for(int i = 1; i <= iMaxNum; i++)
                    {
                        Sum += i;
                    }
                    label2.Text = "합 :" + Sum;
                    iGData01++;
                    label3.Text = "프로그램 실행 횟수 " + iGData01 + " 회";
                }
                else
                {
                    label3.Text = "2 ~ 50000 사이의 값을 입력하세요";
                }
            }
            catch
            {
                label2.Text = "결과에 이상이 있습니다.";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
