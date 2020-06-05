using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203202_최준혁_문제3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num01 = int.Parse(textBox1.Text) / 10;
            int num02 = int.Parse(textBox1.Text);
            if (num02 > -1)
            {
                switch (num01)
                {
                    case 0:
                        label3.Text = num02 + "→" + "0이상 9이하의 수";
                        break;
                    case 1:
                        label3.Text = num02 + "→" + "10이상 19이하의 수";
                        break;
                    case 2:
                        label3.Text = num02 + "→" + "20이상 29이하의 수";
                        break;
                    case 3:
                        label3.Text = num02 + "→" + "30이상 39이하의 수";
                        break;
                    case 4:
                        label3.Text = num02 + "→" + "40이상 49이하의 수";
                        break;
                    case 5:
                        label3.Text = num02 + "→" + "50이상 59이하의 수";
                        break;
                    case 6:
                        label3.Text = num02 + "→" + "60이상 69이하의 수";
                        break;
                    case 7:
                        label3.Text = num02 + "→" + "70이상 79이하의 수";
                        break;
                    case 8:
                        label3.Text = num02 + "→" + "80이상 89이하의 수";
                        break;
                    case 9:
                        label3.Text = num02 + "→" + "90이상 99이하의 수";
                        break;
                    default:
                        label3.Text = "음수와 100이상의 수는" +  "알수없는 수 " + "로처리한다";
                        break;
                }
            }

            else label3.Text = "음수와 100이상의 수는 알수는 수로 처리한다";

        }
    }
}

