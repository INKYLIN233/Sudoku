using System.Threading;

namespace Sudoku
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LabelTime = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnRevoke = new System.Windows.Forms.Button();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.SudokuTime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LabelTime
            // 
            this.LabelTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelTime.Font = new System.Drawing.Font("宋体", 25F);
            this.LabelTime.ForeColor = System.Drawing.Color.Red;
            this.LabelTime.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelTime.Location = new System.Drawing.Point(20, 20);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(120, 35);
            this.LabelTime.TabIndex = 0;
            this.LabelTime.Text = "00:00";
            this.LabelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelTime.Click += new System.EventHandler(this.LabelTime_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("宋体", 10F);
            this.BtnClear.Location = new System.Drawing.Point(320, 25);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 25);
            this.BtnClear.TabIndex = 2;
            this.BtnClear.Text = "清除";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnRevoke
            // 
            this.BtnRevoke.Font = new System.Drawing.Font("宋体", 10F);
            this.BtnRevoke.Location = new System.Drawing.Point(405, 25);
            this.BtnRevoke.Name = "BtnRevoke";
            this.BtnRevoke.Size = new System.Drawing.Size(75, 25);
            this.BtnRevoke.TabIndex = 4;
            this.BtnRevoke.Text = "提交";
            this.BtnRevoke.UseVisualStyleBackColor = true;
            this.BtnRevoke.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // ComboBox
            // 
            this.ComboBox.DropDownHeight = 75;
            this.ComboBox.DropDownWidth = 60;
            this.ComboBox.Font = new System.Drawing.Font("宋体", 13F);
            this.ComboBox.IntegralHeight = false;
            this.ComboBox.ItemHeight = 17;
            this.ComboBox.Items.AddRange(new object[] {
            "简单",
            "中等",
            "困难"});
            this.ComboBox.Location = new System.Drawing.Point(150, 25);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(75, 25);
            this.ComboBox.TabIndex = 3;
            this.ComboBox.Text = "简单";
            this.ComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // Btn1
            // 
            this.Btn1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.Btn1.Location = new System.Drawing.Point(23, 525);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(46, 45);
            this.Btn1.TabIndex = 5;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn_MouseClick);
            // 
            // Btn2
            // 
            this.Btn2.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold);
            this.Btn2.Location = new System.Drawing.Point(74, 525);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(46, 45);
            this.Btn2.TabIndex = 7;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn_MouseClick);
            // 
            // Btn3
            // 
            this.Btn3.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold);
            this.Btn3.Location = new System.Drawing.Point(125, 525);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(46, 45);
            this.Btn3.TabIndex = 8;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn_MouseClick);
            // 
            // Btn4
            // 
            this.Btn4.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold);
            this.Btn4.Location = new System.Drawing.Point(176, 525);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(46, 45);
            this.Btn4.TabIndex = 9;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.Btn_MouseClick);
            // 
            // Btn5
            // 
            this.Btn5.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold);
            this.Btn5.Location = new System.Drawing.Point(227, 525);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(46, 45);
            this.Btn5.TabIndex = 10;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.Btn_MouseClick);
            // 
            // Btn6
            // 
            this.Btn6.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold);
            this.Btn6.Location = new System.Drawing.Point(278, 525);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(46, 45);
            this.Btn6.TabIndex = 11;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.Btn_MouseClick);
            // 
            // Btn7
            // 
            this.Btn7.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold);
            this.Btn7.Location = new System.Drawing.Point(329, 525);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(46, 45);
            this.Btn7.TabIndex = 13;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.Btn_MouseClick);
            // 
            // Btn8
            // 
            this.Btn8.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold);
            this.Btn8.Location = new System.Drawing.Point(380, 525);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(46, 45);
            this.Btn8.TabIndex = 14;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.Btn_MouseClick);
            // 
            // Btn9
            // 
            this.Btn9.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold);
            this.Btn9.Location = new System.Drawing.Point(431, 525);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(46, 45);
            this.Btn9.TabIndex = 15;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.Btn_MouseClick);
            // 
            // BtnNew
            // 
            this.BtnNew.Font = new System.Drawing.Font("宋体", 10F);
            this.BtnNew.Location = new System.Drawing.Point(235, 25);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 25);
            this.BtnNew.TabIndex = 16;
            this.BtnNew.Text = "开始";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // SudokuTime
            // 
            this.SudokuTime.Enabled = true;
            this.SudokuTime.Interval = 1000;
            this.SudokuTime.Tick += new System.EventHandler(this.SudokuTime_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.ComboBox);
            this.Controls.Add(this.BtnRevoke);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.LabelTime);
            this.Name = "MainForm";
            this.Text = "数独";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Click += new System.EventHandler(this.MainForm_Click);
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.Timer SudokuTimer;
        public System.Windows.Forms.Label LabelTime;
        public System.Windows.Forms.Button BtnNew;
        public System.Windows.Forms.Button BtnClear;
        public System.Windows.Forms.Button BtnRevoke;
        public System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn8;
        public System.Windows.Forms.Button Btn9;
        public System.Windows.Forms.Timer SudokuTime;
    }
}

