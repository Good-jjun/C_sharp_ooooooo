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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool prime = false;
                uint num = uint.Parse(textBox1.Text);

                for (int i = 2; i <= num / 2; i++)
                    if ((num % i) == 0)
                        prime = true;
                if (prime)
                    label3.Text = num.ToString() + "은 소수가 아닙니다!";
                else
                    label3.Text = num.ToString() + "은 소수 입니다 !";


            }
            catch (Exception ex)
            {
                label3.Text = ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
