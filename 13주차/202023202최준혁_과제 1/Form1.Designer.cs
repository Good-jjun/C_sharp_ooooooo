namespace _202023202최준혁_과제_1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기OCtrlOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장SCtrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.끝내기XCtrlXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.잘라내기TCtrlTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.잘라내기TCtrlTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.붙여놓ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.모두선택AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.서식UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.글ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.색깔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.편집ToolStripMenuItem,
            this.서식UToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(571, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새파일ToolStripMenuItem,
            this.열기OCtrlOToolStripMenuItem,
            this.저장SCtrlSToolStripMenuItem,
            this.toolStripMenuItem1,
            this.끝내기XCtrlXToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.파일ToolStripMenuItem.Text = "파일(F)";
            // 
            // 새파일ToolStripMenuItem
            // 
            this.새파일ToolStripMenuItem.Name = "새파일ToolStripMenuItem";
            this.새파일ToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.새파일ToolStripMenuItem.Text = "새로 만들기(N) Ctrl+N";
            this.새파일ToolStripMenuItem.Click += new System.EventHandler(this.새파일ToolStripMenuItem_Click);
            // 
            // 열기OCtrlOToolStripMenuItem
            // 
            this.열기OCtrlOToolStripMenuItem.Name = "열기OCtrlOToolStripMenuItem";
            this.열기OCtrlOToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.열기OCtrlOToolStripMenuItem.Text = "열기(O)           Ctrl+O";
            this.열기OCtrlOToolStripMenuItem.Click += new System.EventHandler(this.열기OCtrlOToolStripMenuItem_Click);
            // 
            // 저장SCtrlSToolStripMenuItem
            // 
            this.저장SCtrlSToolStripMenuItem.Name = "저장SCtrlSToolStripMenuItem";
            this.저장SCtrlSToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.저장SCtrlSToolStripMenuItem.Text = "저장(S)           Ctrl+S";
            this.저장SCtrlSToolStripMenuItem.Click += new System.EventHandler(this.저장SCtrlSToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(192, 6);
            // 
            // 끝내기XCtrlXToolStripMenuItem
            // 
            this.끝내기XCtrlXToolStripMenuItem.Name = "끝내기XCtrlXToolStripMenuItem";
            this.끝내기XCtrlXToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.끝내기XCtrlXToolStripMenuItem.Text = "끝내기(X)        Ctrl+X";
            this.끝내기XCtrlXToolStripMenuItem.Click += new System.EventHandler(this.끝내기XCtrlXToolStripMenuItem_Click);
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.잘라내기TCtrlTToolStripMenuItem,
            this.잘라내기TCtrlTToolStripMenuItem1,
            this.붙여놓ToolStripMenuItem,
            this.삭제DToolStripMenuItem,
            this.toolStripMenuItem2,
            this.모두선택AToolStripMenuItem});
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.편집ToolStripMenuItem.Text = "편집(E)";
            // 
            // 잘라내기TCtrlTToolStripMenuItem
            // 
            this.잘라내기TCtrlTToolStripMenuItem.Name = "잘라내기TCtrlTToolStripMenuItem";
            this.잘라내기TCtrlTToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.잘라내기TCtrlTToolStripMenuItem.Text = "잘라내기(T)      Ctrl+T";
            // 
            // 잘라내기TCtrlTToolStripMenuItem1
            // 
            this.잘라내기TCtrlTToolStripMenuItem1.Name = "잘라내기TCtrlTToolStripMenuItem1";
            this.잘라내기TCtrlTToolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
            this.잘라내기TCtrlTToolStripMenuItem1.Text = "복사(C)           Ctrl+C";
            this.잘라내기TCtrlTToolStripMenuItem1.Click += new System.EventHandler(this.잘라내기TCtrlTToolStripMenuItem1_Click);
            // 
            // 붙여놓ToolStripMenuItem
            // 
            this.붙여놓ToolStripMenuItem.Name = "붙여놓ToolStripMenuItem";
            this.붙여놓ToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.붙여놓ToolStripMenuItem.Text = "붙여넣기(P)     Ctrl+P";
            // 
            // 삭제DToolStripMenuItem
            // 
            this.삭제DToolStripMenuItem.Name = "삭제DToolStripMenuItem";
            this.삭제DToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.삭제DToolStripMenuItem.Text = "삭제(D)           Ctrl+ D";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(196, 6);
            // 
            // 모두선택AToolStripMenuItem
            // 
            this.모두선택AToolStripMenuItem.Name = "모두선택AToolStripMenuItem";
            this.모두선택AToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.모두선택AToolStripMenuItem.Text = "모두선택(A)     Ctrl+ A";
            this.모두선택AToolStripMenuItem.Click += new System.EventHandler(this.모두선택AToolStripMenuItem_Click);
            // 
            // 서식UToolStripMenuItem
            // 
            this.서식UToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.글ToolStripMenuItem,
            this.toolStripMenuItem3,
            this.색깔ToolStripMenuItem});
            this.서식UToolStripMenuItem.Name = "서식UToolStripMenuItem";
            this.서식UToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.서식UToolStripMenuItem.Text = "서식(U)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(571, 505);
            this.textBox1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "텍스트파일(*.txt)|*.txt|모든파일(*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "텍스트파일(*.txt)|*.txt|모든파일(*.*)|*.*";
            // 
            // 글ToolStripMenuItem
            // 
            this.글ToolStripMenuItem.Name = "글ToolStripMenuItem";
            this.글ToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.글ToolStripMenuItem.Text = "글꼴(F)         Ctrl+F";
            this.글ToolStripMenuItem.Click += new System.EventHandler(this.글ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(183, 6);
            // 
            // 색깔ToolStripMenuItem
            // 
            this.색깔ToolStripMenuItem.Name = "색깔ToolStripMenuItem";
            this.색깔ToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.색깔ToolStripMenuItem.Text = "색깔(C)  Ctrl+Shit+C";
            this.색깔ToolStripMenuItem.Click += new System.EventHandler(this.색깔ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 535);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기OCtrlOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장SCtrlSToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 끝내기XCtrlXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 잘라내기TCtrlTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 잘라내기TCtrlTToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 붙여놓ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 삭제DToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 모두선택AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 서식UToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem 글ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 색깔ToolStripMenuItem;
    }
}

