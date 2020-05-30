using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20203202최준혁_과제3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sData01 = textBox1.Text;
                if (textBox1.Text != "")
                {
                    switch (sData01)
                    {
                        case "int":
                            int iData01 = int.MaxValue;
                            int iData02 = int.MinValue;
                            label4.Text = "\"" + sData01 + "\"" + " 의 허용값은 " + iData02 + "~" + iData01;
                            break;
                        case "uint":
                            uint uData01 = uint.MaxValue;
                            uint uData02 = uint.MinValue;
                            label4.Text = "\"" + sData01 + "\"" + " 의 허용값은 " + uData02 + "~" + uData01;
                            break;
                        case "float":
                            float fData01 = float.MaxValue;
                            float fData02 = float.MinValue;
                            label4.Text = "\"" + sData01 + "\"" + " 의 허용값은 " + fData02 + "~" + fData01;
                            break;
                        case "double":
                            double dData01 = double.MaxValue;
                            double dData02 = double.MinValue;
                            label4.Text = "\"" + sData01 + "\"" + " 의 허용값은 " + dData02 + "~" + dData01;
                            break;
                        case "long":
                            long lData01 = long.MaxValue;
                            long lData02 = long.MinValue;
                            label4.Text = "\"" + sData01 + "\"" + " 의 허용값은 " + lData02 + "~" + lData01;
                            break;
                        case "ulong":
                            ulong ulData01 = ulong.MaxValue;
                            ulong ulData02 = ulong.MinValue;
                            label4.Text = "\"" + sData01 + "\"" + " 의 허용값은 " + ulData02 + "~" + ulData01;
                            break;
                        case "byte":
                            byte bData01 = byte.MaxValue;
                            byte bData02 = byte.MinValue;
                            label4.Text = "\"" + sData01 + "\"" + " 의 허용값은 " + bData02 + "~" + bData01;
                            break;
                        case "sbyte":
                            sbyte sbData01 = sbyte.MaxValue;
                            sbyte sbData02 = sbyte.MinValue;
                            label4.Text = "\"" + sData01 + "\"" + " 의 허용값은 " + sbData02 + "~" + sbData01;
                            break;
                        case "short":
                            short shData01 = short.MaxValue;
                            short shData02 = short.MinValue;
                            label4.Text = "\"" + sData01 + "\"" + " 의 허용값은 " + shData02 + "~" + shData01;
                            break;
                        case "ushort":
                            ushort usData01 = ushort.MaxValue;
                            ushort usData02 = ushort.MinValue;
                            label4.Text = "\"" + sData01 + "\"" + " 의 허용값은 " + usData02 + "~" + usData01;
                            break;
                        default:
                            label4.Text ="\""+ textBox1.Text +"\""+ "는 알 수 없는 데이터 입니다";
                          break;
                    }
                }
                else
                {
                    label4.Text = "10가지 Data Type 중 하나를 입력하세요 !";
                }
                textBox1.Text = "";
            }
            catch 
            {
               
            }
               
            {

            }
        }
    }
}
