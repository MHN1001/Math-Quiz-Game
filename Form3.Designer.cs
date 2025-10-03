namespace Math_Quiz
{
    partial class Form3
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
            this.Title = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lblRounds = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblOP = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblGameLevel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSkippedQuestions = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWrongAnswers = new System.Windows.Forms.Label();
            this.lblCorrectAnswers = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblRoundsPassed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Yellow;
            this.Title.Location = new System.Drawing.Point(214, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(271, 39);
            this.Title.TabIndex = 0;
            this.Title.Text = "FINAL RESULT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Controls.Add(this.lbl7);
            this.groupBox1.Controls.Add(this.lblRounds);
            this.groupBox1.Controls.Add(this.lbl3);
            this.groupBox1.Controls.Add(this.lbl2);
            this.groupBox1.Controls.Add(this.lblOP);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.lblGameLevel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(11, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 263);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Javanese Text", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Lime;
            this.lblTime.Location = new System.Drawing.Point(106, 198);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(49, 47);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "0 s";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Font = new System.Drawing.Font("Javanese Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lbl7.Location = new System.Drawing.Point(1, 190);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(133, 62);
            this.lbl7.TabIndex = 10;
            this.lbl7.Text = "Time  :  ";
            // 
            // lblRounds
            // 
            this.lblRounds.AutoSize = true;
            this.lblRounds.Font = new System.Drawing.Font("Javanese Text", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRounds.ForeColor = System.Drawing.Color.Lime;
            this.lblRounds.Location = new System.Drawing.Point(130, 35);
            this.lblRounds.Name = "lblRounds";
            this.lblRounds.Size = new System.Drawing.Size(33, 47);
            this.lblRounds.TabIndex = 4;
            this.lblRounds.Text = "0";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Javanese Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lbl3.Location = new System.Drawing.Point(1, 136);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(154, 62);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "OP Type :";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Javanese Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lbl2.Location = new System.Drawing.Point(1, 86);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(113, 62);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Level :";
            // 
            // lblOP
            // 
            this.lblOP.AutoSize = true;
            this.lblOP.Font = new System.Drawing.Font("Javanese Text", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOP.ForeColor = System.Drawing.Color.Lime;
            this.lblOP.Location = new System.Drawing.Point(152, 144);
            this.lblOP.Name = "lblOP";
            this.lblOP.Size = new System.Drawing.Size(108, 47);
            this.lblOP.TabIndex = 6;
            this.lblOP.Text = "Inknown";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Javanese Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lbl1.Location = new System.Drawing.Point(9, 27);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(146, 62);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Rounds : ";
            // 
            // lblGameLevel
            // 
            this.lblGameLevel.AutoSize = true;
            this.lblGameLevel.Font = new System.Drawing.Font("Javanese Text", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameLevel.ForeColor = System.Drawing.Color.Lime;
            this.lblGameLevel.Location = new System.Drawing.Point(103, 94);
            this.lblGameLevel.Name = "lblGameLevel";
            this.lblGameLevel.Size = new System.Drawing.Size(108, 47);
            this.lblGameLevel.TabIndex = 5;
            this.lblGameLevel.Text = "Inknown";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblInTime);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblRoundsPassed);
            this.groupBox2.Controls.Add(this.lblSkippedQuestions);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblWrongAnswers);
            this.groupBox2.Controls.Add(this.lblCorrectAnswers);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox2.Location = new System.Drawing.Point(383, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 263);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // lblSkippedQuestions
            // 
            this.lblSkippedQuestions.AutoSize = true;
            this.lblSkippedQuestions.Font = new System.Drawing.Font("Javanese Text", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkippedQuestions.ForeColor = System.Drawing.Color.Lime;
            this.lblSkippedQuestions.Location = new System.Drawing.Point(268, 157);
            this.lblSkippedQuestions.Name = "lblSkippedQuestions";
            this.lblSkippedQuestions.Size = new System.Drawing.Size(33, 47);
            this.lblSkippedQuestions.TabIndex = 15;
            this.lblSkippedQuestions.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Javanese Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label5.Location = new System.Drawing.Point(7, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(294, 62);
            this.label5.TabIndex = 14;
            this.label5.Text = "skipped Questions :  ";
            // 
            // lblWrongAnswers
            // 
            this.lblWrongAnswers.AutoSize = true;
            this.lblWrongAnswers.Font = new System.Drawing.Font("Javanese Text", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongAnswers.ForeColor = System.Drawing.Color.Lime;
            this.lblWrongAnswers.Location = new System.Drawing.Point(230, 119);
            this.lblWrongAnswers.Name = "lblWrongAnswers";
            this.lblWrongAnswers.Size = new System.Drawing.Size(33, 47);
            this.lblWrongAnswers.TabIndex = 13;
            this.lblWrongAnswers.Text = "0";
            // 
            // lblCorrectAnswers
            // 
            this.lblCorrectAnswers.AutoSize = true;
            this.lblCorrectAnswers.Font = new System.Drawing.Font("Javanese Text", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectAnswers.ForeColor = System.Drawing.Color.Lime;
            this.lblCorrectAnswers.Location = new System.Drawing.Point(250, 77);
            this.lblCorrectAnswers.Name = "lblCorrectAnswers";
            this.lblCorrectAnswers.Size = new System.Drawing.Size(33, 47);
            this.lblCorrectAnswers.TabIndex = 12;
            this.lblCorrectAnswers.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Javanese Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label6.Location = new System.Drawing.Point(6, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 62);
            this.label6.TabIndex = 9;
            this.label6.Text = "Wrong Answers :  ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Javanese Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label7.Location = new System.Drawing.Point(6, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 62);
            this.label7.TabIndex = 8;
            this.label7.Text = "corrent Answers : ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Yellow;
            this.label15.Location = new System.Drawing.Point(5, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(207, 31);
            this.label15.TabIndex = 15;
            this.label15.Text = "YOUR CHOICE";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Yellow;
            this.label16.Location = new System.Drawing.Point(377, 92);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(208, 31);
            this.label16.TabIndex = 16;
            this.label16.Text = "GAME STATUS";
            // 
            // timer1
            // 
            this.timer1.Interval = 600;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 600;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblRoundsPassed
            // 
            this.lblRoundsPassed.AutoSize = true;
            this.lblRoundsPassed.Font = new System.Drawing.Font("Javanese Text", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundsPassed.ForeColor = System.Drawing.Color.Lime;
            this.lblRoundsPassed.Location = new System.Drawing.Point(221, 34);
            this.lblRoundsPassed.Name = "lblRoundsPassed";
            this.lblRoundsPassed.Size = new System.Drawing.Size(33, 47);
            this.lblRoundsPassed.TabIndex = 13;
            this.lblRoundsPassed.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 62);
            this.label2.TabIndex = 12;
            this.label2.Text = "Rounds Passed :";
            // 
            // lblInTime
            // 
            this.lblInTime.AutoSize = true;
            this.lblInTime.Font = new System.Drawing.Font("Javanese Text", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInTime.ForeColor = System.Drawing.Color.Lime;
            this.lblInTime.Location = new System.Drawing.Point(149, 198);
            this.lblInTime.Name = "lblInTime";
            this.lblInTime.Size = new System.Drawing.Size(33, 47);
            this.lblInTime.TabIndex = 17;
            this.lblInTime.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Javanese Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label4.Location = new System.Drawing.Point(13, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 62);
            this.label4.TabIndex = 16;
            this.label4.Text = "In Time :  ";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(703, 385);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Title);
            this.Name = "Form3";
            this.Text = "RESULTS SELTS";
            this.Load += new System.EventHandler(this.Form3_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblWrongAnswers;
        private System.Windows.Forms.Label lblCorrectAnswers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblOP;
        private System.Windows.Forms.Label lblGameLevel;
        private System.Windows.Forms.Label lblRounds;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblSkippedQuestions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblRoundsPassed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInTime;
        private System.Windows.Forms.Label label4;
    }
}