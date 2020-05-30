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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int iData01 = int.Parse(textBox1.Text);
                if (iData01 < 0)
                    textBox2.Text = "0보다 작은수를 입력했습니다!";
                else if (iData01 < 10)
                    textBox2.Text = "0과 10사이 수를 입력했습니다!";
                else if (iData01 < 50)
                    textBox2.Text = "10과 50사이 수를 입력했습니다!";
                else if (iData01 < 100)
                    textBox2.Text = "50과 100사이 수를 입력했습니다!";
                else
                    textBox2.Text = "100보다 큰수를 입력했습니다!";
            }
            catch
            {
                textBox2.Text = "결과에 이상이 있습니다.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
