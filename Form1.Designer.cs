namespace Math_Quiz
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.NUPDnumberOfRounds = new System.Windows.Forms.NumericUpDown();
            this.cbQuizLevel = new System.Windows.Forms.ComboBox();
            this.rbAddition = new System.Windows.Forms.RadioButton();
            this.rbSubtraction = new System.Windows.Forms.RadioButton();
            this.rbMultiplication = new System.Windows.Forms.RadioButton();
            this.rbDivision = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMix = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.NUPDTimeDuration = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NUPDnumberOfRounds)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUPDTimeDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(171, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "MATH QUIZ";
            // 
            // NUPDnumberOfRounds
            // 
            this.NUPDnumberOfRounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUPDnumberOfRounds.Location = new System.Drawing.Point(12, 46);
            this.NUPDnumberOfRounds.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUPDnumberOfRounds.Name = "NUPDnumberOfRounds";
            this.NUPDnumberOfRounds.ReadOnly = true;
            this.NUPDnumberOfRounds.Size = new System.Drawing.Size(190, 29);
            this.NUPDnumberOfRounds.TabIndex = 2;
            this.NUPDnumberOfRounds.ValueChanged += new System.EventHandler(this.NUPnumberOfRounds_ValueChanged);
            // 
            // cbQuizLevel
            // 
            this.cbQuizLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuizLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuizLevel.FormattingEnabled = true;
            this.cbQuizLevel.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard",
            "Mix"});
            this.cbQuizLevel.Location = new System.Drawing.Point(24, 30);
            this.cbQuizLevel.Name = "cbQuizLevel";
            this.cbQuizLevel.Size = new System.Drawing.Size(178, 32);
            this.cbQuizLevel.TabIndex = 3;
            this.cbQuizLevel.SelectedIndexChanged += new System.EventHandler(this.cbQuizLevel_SelectedIndexChanged);
            // 
            // rbAddition
            // 
            this.rbAddition.AutoSize = true;
            this.rbAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAddition.ForeColor = System.Drawing.Color.White;
            this.rbAddition.Location = new System.Drawing.Point(36, 31);
            this.rbAddition.Name = "rbAddition";
            this.rbAddition.Size = new System.Drawing.Size(39, 28);
            this.rbAddition.TabIndex = 4;
            this.rbAddition.Tag = "+";
            this.rbAddition.Text = "+";
            this.rbAddition.UseVisualStyleBackColor = true;
            this.rbAddition.CheckedChanged += new System.EventHandler(this.OparetionTypeRadioButtons_CheckedChanged);
            // 
            // rbSubtraction
            // 
            this.rbSubtraction.AutoSize = true;
            this.rbSubtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSubtraction.ForeColor = System.Drawing.Color.White;
            this.rbSubtraction.Location = new System.Drawing.Point(36, 76);
            this.rbSubtraction.Name = "rbSubtraction";
            this.rbSubtraction.Size = new System.Drawing.Size(39, 33);
            this.rbSubtraction.TabIndex = 5;
            this.rbSubtraction.Tag = "-";
            this.rbSubtraction.Text = "-";
            this.rbSubtraction.UseVisualStyleBackColor = true;
            this.rbSubtraction.CheckedChanged += new System.EventHandler(this.OparetionTypeRadioButtons_CheckedChanged);
            // 
            // rbMultiplication
            // 
            this.rbMultiplication.AutoSize = true;
            this.rbMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMultiplication.ForeColor = System.Drawing.Color.White;
            this.rbMultiplication.Location = new System.Drawing.Point(36, 125);
            this.rbMultiplication.Name = "rbMultiplication";
            this.rbMultiplication.Size = new System.Drawing.Size(35, 28);
            this.rbMultiplication.TabIndex = 6;
            this.rbMultiplication.Tag = "*";
            this.rbMultiplication.Text = "*";
            this.rbMultiplication.UseVisualStyleBackColor = true;
            this.rbMultiplication.CheckedChanged += new System.EventHandler(this.OparetionTypeRadioButtons_CheckedChanged);
            // 
            // rbDivision
            // 
            this.rbDivision.AutoSize = true;
            this.rbDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDivision.ForeColor = System.Drawing.Color.White;
            this.rbDivision.Location = new System.Drawing.Point(36, 169);
            this.rbDivision.Name = "rbDivision";
            this.rbDivision.Size = new System.Drawing.Size(36, 29);
            this.rbDivision.TabIndex = 7;
            this.rbDivision.Tag = "/";
            this.rbDivision.Text = "/";
            this.rbDivision.UseVisualStyleBackColor = true;
            this.rbDivision.CheckedChanged += new System.EventHandler(this.OparetionTypeRadioButtons_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMix);
            this.groupBox1.Controls.Add(this.rbAddition);
            this.groupBox1.Controls.Add(this.rbDivision);
            this.groupBox1.Controls.Add(this.rbSubtraction);
            this.groupBox1.Controls.Add(this.rbMultiplication);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(262, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 208);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPARETION TYPE";
            // 
            // rbMix
            // 
            this.rbMix.AutoSize = true;
            this.rbMix.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMix.ForeColor = System.Drawing.Color.White;
            this.rbMix.Location = new System.Drawing.Point(106, 100);
            this.rbMix.Name = "rbMix";
            this.rbMix.Size = new System.Drawing.Size(64, 29);
            this.rbMix.TabIndex = 8;
            this.rbMix.Tag = "Mix";
            this.rbMix.Text = "Mix";
            this.rbMix.UseVisualStyleBackColor = true;
            this.rbMix.CheckedChanged += new System.EventHandler(this.OparetionTypeRadioButtons_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbQuizLevel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox2.Location = new System.Drawing.Point(31, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 208);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "QUIZ LEVEL";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(169, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 39);
            this.button1.TabIndex = 10;
            this.button1.Text = "Continue";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.NUPDnumberOfRounds);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox3.Location = new System.Drawing.Point(31, 269);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(225, 109);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Number Of Rounds";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.NUPDTimeDuration);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox4.Location = new System.Drawing.Point(262, 269);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 109);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Time Duration";
            // 
            // NUPDTimeDuration
            // 
            this.NUPDTimeDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUPDTimeDuration.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.NUPDTimeDuration.Location = new System.Drawing.Point(12, 46);
            this.NUPDTimeDuration.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.NUPDTimeDuration.Name = "NUPDTimeDuration";
            this.NUPDTimeDuration.ReadOnly = true;
            this.NUPDTimeDuration.Size = new System.Drawing.Size(173, 29);
            this.NUPDTimeDuration.TabIndex = 2;
            this.NUPDTimeDuration.ValueChanged += new System.EventHandler(this.NUPDTimeDuration_ValueChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(499, 453);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "MATH QUIZ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUPDnumberOfRounds)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUPDTimeDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUPDnumberOfRounds;
        private System.Windows.Forms.ComboBox cbQuizLevel;
        private System.Windows.Forms.RadioButton rbAddition;
        private System.Windows.Forms.RadioButton rbSubtraction;
        private System.Windows.Forms.RadioButton rbMultiplication;
        private System.Windows.Forms.RadioButton rbDivision;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbMix;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown NUPDTimeDuration;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

