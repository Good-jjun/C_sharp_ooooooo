using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _202023202최준혁_과제_1
{
    public partial class Form1 : Form
    {
        bool isModified = false;
        bool hasFileName = false;
        string sFileName = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void 열기OCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (isModified == true)
                {
                    DialogResult answer = MessageBox.Show("변경된 내용을 저장하시겠습니까?"
                        , "저장", MessageBoxButtons.YesNo);
                    if (answer == DialogResult.Yes)
                    {
                        if (hasFileName == true)
                        {
                            StreamWriter fs = File.CreateText(sFileName);
                            fs.WriteLine(textBox1.Text);
                            fs.Close();
                            isModified = false;
                        }
                        else
                        {
                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                sFileName = saveFileDialog1.FileName;
                                StreamWriter fs = File.CreateText(sFileName);
                                fs.WriteLine(textBox1.Text);
                                fs.Close();
                                hasFileName = true;
                                isModified = false;
                            }
                        }
                    }
                }
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    sFileName = openFileDialog1.FileName;
                    StreamReader fs = File.OpenText(sFileName);
                    textBox1.Text = fs.ReadToEnd();
                    fs.Close();
                    hasFileName = true;
                    isModified = false;
                }
            }
            catch
            {

            }
        }

        private void 잘라내기TCtrlTToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void 새파일ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isModified == true)
            {
                DialogResult answer = MessageBox.Show("변경된 내용을 저장하시겠습니까?"
                    , "저장", MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {
                    if (hasFileName == true)
                    {
                        StreamWriter fs = File.CreateText(sFileName);
                        fs.WriteLine(textBox1.Text);
                        fs.Close();
                        isModified = false;
                    }
                    else
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            sFileName = saveFileDialog1.FileName;
                            StreamWriter fs = File.CreateText(sFileName);
                            fs.WriteLine(textBox1.Text);
                            fs.Close();
                            hasFileName = true;
                            isModified = false;
                        }
                    }
                }
            }

            textBox1.Text = "";
            isModified = false;
            hasFileName = false;
            sFileName = "";
        }

        private void 저장SCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (hasFileName == true)
                {
                    StreamWriter fs = File.CreateText(sFileName);
                    fs.WriteLine(textBox1.Text);
                    fs.Close();
                    isModified = false;
                }
                else

                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        sFileName = saveFileDialog1.FileName;
                        StreamWriter fs = File.CreateText(sFileName);
                        fs.WriteLine(textBox1.Text);
                        fs.Close();
                        hasFileName = true;
                        isModified = false;
                    }
                }
            }
            catch
            {
                MessageBox.Show("저장을 하는 도중에 이상이 생겼습니다", "에러"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 끝내기XCtrlXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isModified == true)
            {
                DialogResult answer = MessageBox.Show("변경된 내용을 저장하시겠습니까?"
                    , "저장", MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {
                    if (hasFileName == true)
                    {
                        StreamWriter fs = File.CreateText(sFileName);
                        fs.WriteLine(textBox1.Text);
                        fs.Close();
                        isModified = false;
                    }
                    else
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            sFileName = saveFileDialog1.FileName;
                            StreamWriter fs = File.CreateText(sFileName);
                            fs.WriteLine(textBox1.Text);
                            fs.Close();
                            hasFileName = true;
                            isModified = false;
                        }
                    }
                }
            }
            Application.Exit();
        }

        private void 모두선택AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void 글ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if(fontDialog.Showcolor() == DialogResult.OK)
            {
                textBox1.Font = fontDialog.Font;
            }
        }

        private void 색깔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog1.Color;
            }
        }
    }
}
