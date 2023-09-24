using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class MainForm : Form
    {
        private int TimeCount = 0;
        public Label[,] labelArray = new Label[9, 9];
        //public List<Label> labelList = new List<Label>();
        public static MainForm mainForm;
        public MainForm()
        {
            InitializeComponent();
            //窗口生成在屏幕正中央
            this.StartPosition = FormStartPosition.CenterScreen;
            mainForm = this;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Label label = new Label();
                    labelArray[i, j] = label;
                    labelArray[i, j].Name = i + "," + j;
                    labelArray[i, j].Text = "";
                    labelArray[i, j].Tag = 0;
                    labelArray[i, j].TextAlign = ContentAlignment.MiddleCenter;
                    labelArray[i, j].Font = new Font("宋体", 16F, FontStyle.Bold);
                    labelArray[i, j].Location = new Point(i * 50 + 25, j * 50 + 65);
                    labelArray[i, j].AutoSize = false;
                    labelArray[i, j].Size = new Size(50, 50);
                    labelArray[i, j].BorderStyle = BorderStyle.Fixed3D;
                    labelArray[i, j].BackColor = Color.White;
                    //labelList.Add(labelArray[i, j]);
                    this.Controls.Add(labelArray[i, j]);
                }
            }
            Function.PrintArray();
            Label_Click();
        }

        #region 鼠标点击事件
        private void BtnNew_Click(object sender, EventArgs e)
        {
            Function.ChangeBackColor();
            NewGame();
            Function.Clear();
            Function.PrintArray();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Function.ChangeBackColor();
            Clear();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            Function.ChangeBackColor();
            Submit();
        }
        private void Btn_MouseClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            foreach (var item in labelArray)
            {
                if ((int)item.Tag == 1 && item.BackColor.ToString().Equals("Color [Info]"))
                {
                    item.Text = button.Text;
                    return;
                }
                else if ((int)item.Tag == 0)
                    continue;
            }
        }
        private void Label_Click()
        {
            foreach (var item in labelArray)
            {
                item.MouseDown += new MouseEventHandler(LabelClick);
            }
        }
        private void MainForm_Click(object sender, EventArgs e)
        {
            Function.ChangeBackColor();
        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetTime();
            Function.Clear();
            Function.PrintArray();
        }
        private void SudokuTime_Tick(object sender, EventArgs e)
        {
            TimeCount++;
            LabelTime.Text = Function.GetTime(TimeCount);
        }
        private void LabelTime_Click(object sender, EventArgs e)
        {
            Function.ChangeBackColor();
        }
        private void LabelClick(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            foreach (var item in labelArray)
            {
                item.BackColor = SystemColors.Window;
            }
            CheckCell();
            label.BackColor = SystemColors.Info;
            label.Tag = 1;
            //MessageBox.Show(label.Name.ToString());
        }
        #endregion

        #region 鼠标点击方法
        private void NewGame()
        {
            ResetTime();
        }
        private void Clear()
        {
            foreach (var item in labelArray)
            {
                if (item.Enabled == true)
                {
                    item.Text = "";
                }
            }
        }
        private void Submit()
        {
            int CheckCount = 0;
            foreach (var item in labelArray)
            {
                if (item.ForeColor == Color.Red || item.Text == "")
                {
                    CheckCount++;
                }
            }
            if (CheckCount != 0)
            {
                MessageBox.Show("验证失败！");
            }
            else if (CheckCount == 0)
            {
                string[] time = LabelTime.Text.Split(':');
                MessageBox.Show("验证成功！耗时" + time[0] + "分" + time[1] +"秒");
                SudokuTime.Stop();
            }
        }
        /// <summary>
        /// 格校验,每格输入数字与生成的数独数组进行比对
        /// </summary>
        private void CheckCell()
        {
            int[][] array = Function.Get();
            foreach (var item in labelArray)
            {
                string[] name = item.Name.Split(',');
                int x = Convert.ToInt32(name[0]);
                int y = Convert.ToInt32(name[1]);
                item.BackColor = SystemColors.Window;
                if (item.Enabled)
                {
                    if (Convert.ToInt32(item.Tag) == 1 && item.Text != array[x][y].ToString())
                    {
                        item.ForeColor = Color.Red;
                    }
                    else
                    {
                        item.ForeColor = Color.Black;
                    }
                }
            }
        }
        private void ResetTime()
        {
            TimeCount = 0;
            //SudokuTime.Start();
        }
        #endregion
    }
}
