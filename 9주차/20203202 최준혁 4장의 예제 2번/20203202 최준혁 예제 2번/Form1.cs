using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203202_최준혁_예제_2번
{
    public partial class Form1 : Form
    {
        int iKimTH_account = 0; // 김태희 계좌잔고
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int iReceive = int.Parse(textBox1.Text);
                if(iReceive <=0 || iReceive >=1000)
                {
                    label5.Text = "정상적인 금액을 입급 해주세요" + "\n" +
                        "김태희 계좌 잔고 :" + iKimTH_account + "원";
                }
                else
                {
                    iKimTH_account = iKimTH_account + iReceive;
                    label5.Text = "김태희 계좌잔고 :" + iKimTH_account + "원";
                }
            }
            catch
            {
                label5.Text = "결과에 이상이 있습니다." + "\n" +
                    "김태희 계좌 잔고 :" + iKimTH_account + "원";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int iPay = int.Parse(textBox2.Text);
                if(iPay <=0 || iPay > iKimTH_account)
                {
                    label5.Text = label5.Text = "정상적인 금액을 출금 해주세요" + "\n" +
                        "김태희 계좌 잔고 :" + iKimTH_account + "원";
                }
                else
                {
                    iKimTH_account = iKimTH_account - iPay;
                    label5.Text = "김태희 계좌잔고 :" + iKimTH_account + "원";
                }
            }
            catch
            {
                label5.Text = "결과에 이상이 있습니다." + "\n" +
                   "김태희 계좌 잔고 :" + iKimTH_account + "원";
            }
        }
    }
}
