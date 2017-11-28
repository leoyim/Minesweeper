﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Form_Rank : Form
    {
        public Form_Rank()
        {
            InitializeComponent();
        }

        private void Form_Rank_Load(object sender, EventArgs e)
        {
            //读取数据
            int nBeginner = Properties.Settings.Default.Beginner;
            int nIntermediate = Properties.Settings.Default.Intermediate;
            int nExpert = Properties.Settings.Default.Expert;

            //显示内容
            Label_Beginner.Text = String.Format("新手：       {0}", nBeginner);
            Label_Intermediate.Text = String.Format("中等：       {0}", nIntermediate);
            Label_Expert.Text = String.Format("专家：       {0}", nExpert);
        }

        private void Button_Reset_Click(object sender, EventArgs e)
        {
            //将标签置为默认值
            Label_Beginner.Text = String.Format("新手：       {0}", 999);
            Label_Intermediate.Text = String.Format("中等：       {0}", 999);
            Label_Expert.Text = String.Format("专家：       {0}", 999);
            //将所有记录设置为999完成初始化
            Properties.Settings.Default.Beginner = 999;
            Properties.Settings.Default.Intermediate = 999;
            Properties.Settings.Default.Expert = 999;
            Properties.Settings.Default.Save();        //保存设置
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            this.Close();         //关闭窗口
        }
    }
}
