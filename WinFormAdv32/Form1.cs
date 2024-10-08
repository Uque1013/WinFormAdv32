﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAdv32
{
    public partial class Form1 : Form
    {
        public int PROGRESS_BAR_STEP { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void 파일ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 편집ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 인쇄ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 서식ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 도움말ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "새로만들기 메뉴를 선택하셨습니다.";
        }

        private void 도움말보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://support.microsoft.com/ko-kr/windows/windows%EC%97%90%EC%84%9C-%EB%8F%84%EC%9B%80%EB%A7%90%EC%9D%84-%EB%B3%B4%EB%8A%94-%EB%B0%A9%EB%B2%95-711b6492-0435-0038-8706-7c6b0feb200a");
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "텍스트 파일(*.txt) | *.txt | 모든 파일(*.*) | *.*";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = System.IO.File.ReadAllText(ofd.FileName);
            }
        }

        private void 확대하기축소하기기본값복원ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 50;
        }

        private void 확대ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripProgressBar1.Value + PROGRESS_BAR_STEP >= 100)
            {
                toolStripProgressBar1.Value = 100;
            }
            else
            {
                toolStripProgressBar1.Value += PROGRESS_BAR_STEP;
            }
        }

        private void 축소ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(toolStripProgressBar1.Value < PROGRESS_BAR_STEP)
            {
                toolStripProgressBar1.Value = 0;
            }
            else
            {
                toolStripProgressBar1.Value -= PROGRESS_BAR_STEP;
            }
        }
    }
}
