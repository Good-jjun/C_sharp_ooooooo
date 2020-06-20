using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203202최준혁_실습예제_3번
{
    public partial class Form1 : Form
    {
        bool isDrag = false;
        Point PreviousPoint;
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrag = true;
            PreviousPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrag = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrag)
            {
                Pen MyPen;
                Point CurrentPoint = new Point(e.X, e.Y);
                if (comboBox1.SelectedIndex == 0)
                    MyPen = new Pen(Color.Black);
                else if (comboBox1.SelectedIndex == 1)
                    MyPen = new Pen(Color.Red);
                else if (comboBox1.SelectedIndex == 2)
                    MyPen = new Pen(Color.Blue);
                else
                    MyPen = new Pen(Color.Yellow);

                if (radioButton2.Checked == true)
                    MyPen.Width = 3;

                if (comboBox2.SelectedIndex == 0)
                    MyPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                else if (comboBox2.SelectedIndex == 1)
                    MyPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                else
                    MyPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;

                Graphics g = panel1.CreateGraphics();
                g.DrawLine(MyPen, PreviousPoint, CurrentPoint);
                PreviousPoint = CurrentPoint;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }
    }
}
