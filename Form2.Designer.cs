namespace Math_Quiz
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && ( components != null ))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblWrongAnswers = new System.Windows.Forms.Label();
            this.lblCorrectAnswer = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lblOparetionType = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbResult4 = new System.Windows.Forms.RadioButton();
            this.rbResult2 = new System.Windows.Forms.RadioButton();
            this.rbResult3 = new System.Windows.Forms.RadioButton();
            this.rbResult1 = new System.Windows.Forms.RadioButton();
            this.btnCheckAnsewr = new System.Windows.Forms.Button();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIrestartGame = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbQuestionScreen = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblWrongAnswers);
            this.groupBox1.Controls.Add(this.lblCorrectAnswer);
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Controls.Add(this.lbl5);
            this.groupBox1.Controls.Add(this.lbl4);
            this.groupBox1.Controls.Add(this.lblOparetionType);
            this.groupBox1.Controls.Add(this.lblLevel);
            this.groupBox1.Controls.Add(this.lblRound);
            this.groupBox1.Controls.Add(this.lbl3);
            this.groupBox1.Controls.Add(this.lbl2);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(307, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 229);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lblWrongAnswers
            // 
            this.lblWrongAnswers.AutoSize = true;
            this.lblWrongAnswers.ForeColor = System.Drawing.Color.Lime;
            this.lblWrongAnswers.Location = new System.Drawing.Point(181, 137);
            this.lblWrongAnswers.Name = "lblWrongAnswers";
            this.lblWrongAnswers.Size = new System.Drawing.Size(24, 25);
            this.lblWrongAnswers.TabIndex = 13;
            this.lblWrongAnswers.Text = "0";
            // 
            // lblCorrectAnswer
            // 
            this.lblCorrectAnswer.AutoSize = true;
            this.lblCorrectAnswer.ForeColor = System.Drawing.Color.Lime;
            this.lblCorrectAnswer.Location = new System.Drawing.Point(192, 112);
            this.lblCorrectAnswer.Name = "lblCorrectAnswer";
            this.lblCorrectAnswer.Size = new System.Drawing.Size(24, 25);
            this.lblCorrectAnswer.TabIndex = 12;
            this.lblCorrectAnswer.Text = "0";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Lime;
            this.lblTime.Location = new System.Drawing.Point(86, 162);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(191, 24);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "NO TIME REQUIRED";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lbl5.Location = new System.Drawing.Point(6, 137);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(192, 25);
            this.lbl5.TabIndex = 9;
            this.lbl5.Text = "Wrong Answer :  ";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lbl4.Location = new System.Drawing.Point(6, 112);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(195, 25);
            this.lbl4.TabIndex = 8;
            this.lbl4.Text = "Corrent Answer : ";
            // 
            // lblOparetionType
            // 
            this.lblOparetionType.AutoSize = true;
            this.lblOparetionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOparetionType.ForeColor = System.Drawing.Color.Lime;
            this.lblOparetionType.Location = new System.Drawing.Point(194, 96);
            this.lblOparetionType.Name = "lblOparetionType";
            this.lblOparetionType.Size = new System.Drawing.Size(55, 16);
            this.lblOparetionType.TabIndex = 6;
            this.lblOparetionType.Text = "Inknown";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.ForeColor = System.Drawing.Color.Lime;
            this.lblLevel.Location = new System.Drawing.Point(86, 64);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(91, 25);
            this.lblLevel.TabIndex = 5;
            this.lblLevel.Text = "Inknown";
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.ForeColor = System.Drawing.Color.Lime;
            this.lblRound.Location = new System.Drawing.Point(104, 39);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(24, 25);
            this.lblRound.TabIndex = 4;
            this.lblRound.Text = "0";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lbl3.Location = new System.Drawing.Point(5, 89);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(188, 25);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Oparetion Type :";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lbl2.Location = new System.Drawing.Point(6, 64);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(83, 25);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Level :";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lbl1.Location = new System.Drawing.Point(6, 39);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(113, 25);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Rounds : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbResult4);
            this.groupBox4.Controls.Add(this.rbResult2);
            this.groupBox4.Controls.Add(this.rbResult3);
            this.groupBox4.Controls.Add(this.rbResult1);
            this.groupBox4.Controls.Add(this.btnCheckAnsewr);
            this.groupBox4.Controls.Add(this.btnNextQuestion);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox4.Location = new System.Drawing.Point(12, 160);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(289, 229);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Your Answer";
            // 
            // rbResult4
            // 
            this.rbResult4.AutoSize = true;
            this.rbResult4.Location = new System.Drawing.Point(163, 98);
            this.rbResult4.Name = "rbResult4";
            this.rbResult4.Size = new System.Drawing.Size(91, 29);
            this.rbResult4.TabIndex = 16;
            this.rbResult4.TabStop = true;
            this.rbResult4.Tag = "4";
            this.rbResult4.Text = "Result";
            this.rbResult4.UseVisualStyleBackColor = true;
            this.rbResult4.CheckedChanged += new System.EventHandler(this.RadioButons_CheckedChanged);
            // 
            // rbResult2
            // 
            this.rbResult2.AutoSize = true;
            this.rbResult2.Location = new System.Drawing.Point(163, 50);
            this.rbResult2.Name = "rbResult2";
            this.rbResult2.Size = new System.Drawing.Size(91, 29);
            this.rbResult2.TabIndex = 15;
            this.rbResult2.TabStop = true;
            this.rbResult2.Tag = "2";
            this.rbResult2.Text = "Result";
            this.rbResult2.UseVisualStyleBackColor = true;
            this.rbResult2.CheckedChanged += new System.EventHandler(this.RadioButons_CheckedChanged);
            // 
            // rbResult3
            // 
            this.rbResult3.AutoSize = true;
            this.rbResult3.Location = new System.Drawing.Point(22, 98);
            this.rbResult3.Name = "rbResult3";
            this.rbResult3.Size = new System.Drawing.Size(91, 29);
            this.rbResult3.TabIndex = 14;
            this.rbResult3.TabStop = true;
            this.rbResult3.Tag = "3";
            this.rbResult3.Text = "Result";
            this.rbResult3.UseVisualStyleBackColor = true;
            this.rbResult3.CheckedChanged += new System.EventHandler(this.RadioButons_CheckedChanged);
            // 
            // rbResult1
            // 
            this.rbResult1.AutoSize = true;
            this.rbResult1.Location = new System.Drawing.Point(22, 48);
            this.rbResult1.Name = "rbResult1";
            this.rbResult1.Size = new System.Drawing.Size(91, 29);
            this.rbResult1.TabIndex = 13;
            this.rbResult1.TabStop = true;
            this.rbResult1.Tag = "1";
            this.rbResult1.Text = "Result";
            this.rbResult1.UseVisualStyleBackColor = true;
            this.rbResult1.CheckedChanged += new System.EventHandler(this.RadioButons_CheckedChanged);
            // 
            // btnCheckAnsewr
            // 
            this.btnCheckAnsewr.BackColor = System.Drawing.Color.Yellow;
            this.btnCheckAnsewr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckAnsewr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckAnsewr.ForeColor = System.Drawing.Color.Black;
            this.btnCheckAnsewr.Location = new System.Drawing.Point(22, 164);
            this.btnCheckAnsewr.Name = "btnCheckAnsewr";
            this.btnCheckAnsewr.Size = new System.Drawing.Size(106, 38);
            this.btnCheckAnsewr.TabIndex = 9;
            this.btnCheckAnsewr.Text = "CHECK";
            this.btnCheckAnsewr.UseVisualStyleBackColor = false;
            this.btnCheckAnsewr.Click += new System.EventHandler(this.btnCheckAnsewr_Click);
            this.btnCheckAnsewr.MouseEnter += new System.EventHandler(this.btnCheckAnsewr_MouseEnter);
            this.btnCheckAnsewr.MouseLeave += new System.EventHandler(this.btnCheckAnsewr_MouseLeave);
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNextQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextQuestion.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextQuestion.ForeColor = System.Drawing.Color.Black;
            this.btnNextQuestion.Location = new System.Drawing.Point(148, 164);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(106, 38);
            this.btnNextQuestion.TabIndex = 12;
            this.btnNextQuestion.Text = "SKIP";
            this.btnNextQuestion.UseVisualStyleBackColor = false;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            this.btnNextQuestion.MouseEnter += new System.EventHandler(this.btnNextQuestion_MouseEnter);
            this.btnNextQuestion.MouseLeave += new System.EventHandler(this.btnNextQuestion_MouseLeave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Tan;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOptions});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(598, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiOptions
            // 
            this.tsmiOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIrestartGame,
            this.exitToolStripMenuItem});
            this.tsmiOptions.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiOptions.ForeColor = System.Drawing.Color.Yellow;
            this.tsmiOptions.Name = "tsmiOptions";
            this.tsmiOptions.Size = new System.Drawing.Size(61, 20);
            this.tsmiOptions.Text = "Options";
            // 
            // TSMIrestartGame
            // 
            this.TSMIrestartGame.Name = "TSMIrestartGame";
            this.TSMIrestartGame.Size = new System.Drawing.Size(180, 22);
            this.TSMIrestartGame.Text = "Restart Game";
            this.TSMIrestartGame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TSMIrestartGame.Click += new System.EventHandler(this.TSMIrestartGame_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbQuestionScreen);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox2.Location = new System.Drawing.Point(34, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(530, 114);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Question";
            // 
            // tbQuestionScreen
            // 
            this.tbQuestionScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tbQuestionScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuestionScreen.Location = new System.Drawing.Point(21, 30);
            this.tbQuestionScreen.Name = "tbQuestionScreen";
            this.tbQuestionScreen.ReadOnly = true;
            this.tbQuestionScreen.Size = new System.Drawing.Size(489, 62);
            this.tbQuestionScreen.TabIndex = 13;
            this.tbQuestionScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label1.Location = new System.Drawing.Point(9, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Time :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(598, 403);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCheckAnsewr;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiOptions;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Label lblOparetionType;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox tbQuestionScreen;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblWrongAnswers;
        private System.Windows.Forms.Label lblCorrectAnswer;
        private System.Windows.Forms.RadioButton rbResult4;
        private System.Windows.Forms.RadioButton rbResult2;
        private System.Windows.Forms.RadioButton rbResult3;
        private System.Windows.Forms.RadioButton rbResult1;
        private System.Windows.Forms.ToolStripMenuItem TSMIrestartGame;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}