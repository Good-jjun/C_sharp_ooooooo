using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203202최준혁_예졔
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sData01 = "최준혁";
            label1.Text = "결과는"  + sData01 +  "입니다";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iData01 = 3;
            label1.Text = "결과는" + iData01 + "입니다";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double dData01 = -27.51;
            dData01 = 3.5;
            label1.Text = "결과는" + dData01 + "입니다";
        }
    }
}
