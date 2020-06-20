using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203202최준혁_실습예제_1번
{
    public partial class Form1 : Form
    {
        bool isDrag = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrag = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrag = false;
                label1.Text = "드래그 하지 않음";
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrag)
                label1.Text = "드래그 하고있음";
        }
    }
}
