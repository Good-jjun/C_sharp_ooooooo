using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203202최준혁_과제1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ulong start = ulong.Parse(textBox1.Text);
                ulong finish = ulong.Parse(textBox2.Text);
                string result = "";
                ulong sumAdd = 0;
                ulong sumMulti = 1;
                if (start >= 1)
                    if (finish <= 20)
                        if (start < finish)
                        {
                            for (ulong i = start; i <= finish; i++)
                            {
                                sumAdd = sumAdd + i;
                                sumMulti = sumMulti + i;
                            }
                            {
                                result = start + "부터" + finish + "까지의 합은" + sumAdd
                                     + "\n 곱은" + sumMulti + "입니다";
                                label4.Text = result;
                            }
                        }
                        else
                        {
                            label4.Text = "시작값은 마지막 값보다 작은값 이어야합니다";
                        }

                    else
                    {
                        label4.Text = "마지막 값은 20 이상이어야 합니다";
                    }
            
            else
            {
                label3.Text = "시작 값은 0보다 큰수 여야합니다";
            }
        }

            catch
            {
                label4.Text = "시작값을 입력하세요";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
