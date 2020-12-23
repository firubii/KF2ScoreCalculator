namespace KF2ScoreCalculator
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
            if (disposing && (components != null))
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
            this.difficulty = new System.Windows.Forms.ComboBox();
            this.result = new System.Windows.Forms.Label();
            this.seconds = new System.Windows.Forms.NumericUpDown();
            this.minTimeText = new System.Windows.Forms.Label();
            this.maxTimeText = new System.Windows.Forms.Label();
            this.minScoreText = new System.Windows.Forms.Label();
            this.maxScoreText = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.unrounded = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.seconds)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // difficulty
            // 
            this.difficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficulty.FormattingEnabled = true;
            this.difficulty.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.difficulty.Items.AddRange(new object[] {
            "Easy",
            "Normal",
            "Hard",
            "Very Hard"});
            this.difficulty.Location = new System.Drawing.Point(12, 12);
            this.difficulty.Name = "difficulty";
            this.difficulty.Size = new System.Drawing.Size(216, 21);
            this.difficulty.TabIndex = 0;
            this.difficulty.SelectedIndexChanged += new System.EventHandler(this.difficulty_SelectedIndexChanged);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(8, 62);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(66, 20);
            this.result.TabIndex = 1;
            this.result.Text = "Result:";
            // 
            // seconds
            // 
            this.seconds.Location = new System.Drawing.Point(12, 39);
            this.seconds.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.seconds.Name = "seconds";
            this.seconds.Size = new System.Drawing.Size(216, 20);
            this.seconds.TabIndex = 2;
            this.seconds.ValueChanged += new System.EventHandler(this.seconds_ValueChanged);
            // 
            // minTimeText
            // 
            this.minTimeText.AutoSize = true;
            this.minTimeText.Location = new System.Drawing.Point(6, 16);
            this.minTimeText.Name = "minTimeText";
            this.minTimeText.Size = new System.Drawing.Size(77, 13);
            this.minTimeText.TabIndex = 3;
            this.minTimeText.Text = "Minimum Time:";
            // 
            // maxTimeText
            // 
            this.maxTimeText.AutoSize = true;
            this.maxTimeText.Location = new System.Drawing.Point(6, 33);
            this.maxTimeText.Name = "maxTimeText";
            this.maxTimeText.Size = new System.Drawing.Size(80, 13);
            this.maxTimeText.TabIndex = 4;
            this.maxTimeText.Text = "Maximum Time:";
            // 
            // minScoreText
            // 
            this.minScoreText.AutoSize = true;
            this.minScoreText.Location = new System.Drawing.Point(6, 50);
            this.minScoreText.Name = "minScoreText";
            this.minScoreText.Size = new System.Drawing.Size(82, 13);
            this.minScoreText.TabIndex = 5;
            this.minScoreText.Text = "Minimum Score:";
            // 
            // maxScoreText
            // 
            this.maxScoreText.AutoSize = true;
            this.maxScoreText.Location = new System.Drawing.Point(6, 67);
            this.maxScoreText.Name = "maxScoreText";
            this.maxScoreText.Size = new System.Drawing.Size(85, 13);
            this.maxScoreText.TabIndex = 6;
            this.maxScoreText.Text = "Maximum Score:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.minTimeText);
            this.groupBox1.Controls.Add(this.maxScoreText);
            this.groupBox1.Controls.Add(this.maxTimeText);
            this.groupBox1.Controls.Add(this.minScoreText);
            this.groupBox1.Location = new System.Drawing.Point(234, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 86);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Difficulty Stats";
            // 
            // unrounded
            // 
            this.unrounded.AutoSize = true;
            this.unrounded.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unrounded.Location = new System.Drawing.Point(9, 82);
            this.unrounded.Name = "unrounded";
            this.unrounded.Size = new System.Drawing.Size(104, 15);
            this.unrounded.TabIndex = 8;
            this.unrounded.Text = "Exact Calculation:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 109);
            this.Controls.Add(this.unrounded);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.seconds);
            this.Controls.Add(this.result);
            this.Controls.Add(this.difficulty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KF2 Score Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.seconds)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox difficulty;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.NumericUpDown seconds;
        private System.Windows.Forms.Label minTimeText;
        private System.Windows.Forms.Label maxTimeText;
        private System.Windows.Forms.Label minScoreText;
        private System.Windows.Forms.Label maxScoreText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label unrounded;
    }
}

