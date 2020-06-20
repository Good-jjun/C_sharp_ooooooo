using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203202최준혁_과제_1
{
    public partial class Form1 : Form
    {
        bool isDrag = false;
        Point PreviousPoint;
        Pen MyPen = new Pen(Color.Black, 2);
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrag = true;
            PreviousPoint = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrag = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrag)
            {
                Point CurrentPoint = new Point(e.X, e.Y);
                Graphics g = pictureBox1.CreateGraphics();
                g.DrawLine(MyPen, PreviousPoint, CurrentPoint);
                PreviousPoint = CurrentPoint;
            }
        }

        private void 굵기10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyPen.Width = 10;
        }

        private void 굵기5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyPen.Width = 5;
        }

        private void 굵기3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyPen.Width = 3;
        }

        private void 굵기1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyPen.Width = 1;
        }

        private void dotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
        }

        private void dashDotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
        }

        private void solidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
        }

        private void colorCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                MyPen.Color = colorDialog1.Color;
            }
        }

        private void 종료XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
