using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203202최준혁_과제1번
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
                int num = int.Parse(textBox1.Text);
                switch (num)
                {
                    case 1:
                        label2.Text = "one";
                        break;
                    case 2:
                        label2.Text = "two";
                        break;
                    case 3:
                        label2.Text = "three";
                        break;
                    case 4:
                        label2.Text = "four";
                        break;
                    case 5:
                        label2.Text = "five";
                        break;
                    default:
                        label2.Text = "알수없는 수입니다!";
                        break;
                }

                
                   
            }
            catch
            {

            }
        }
    }
}
