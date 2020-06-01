using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203202최준혁__과제_2
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
                string spell = "";
                if (num > 0 && num <= 20)
                {
                    for(int i = 1; i <= num; i++)
                    {
                        spell += i + ".";
                    }
                    label3.Text = "수행된 i 값 : " + spell;
                }
                else
                {
                    label3.Text = "1과 20사이의 수를 입력하세요";
                }
                
            }
            catch
            {

            }
        }
    }
}
