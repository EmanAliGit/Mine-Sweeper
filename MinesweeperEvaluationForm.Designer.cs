namespace MineSweeper
{
    partial class MinesweeperForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MinesweeperForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.score1 = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SmileStart = new System.Windows.Forms.Button();
            this.Expert = new System.Windows.Forms.RadioButton();
            this.Hard = new System.Windows.Forms.RadioButton();
            this.Easy = new System.Windows.Forms.RadioButton();
            this.Board = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.score1);
            this.panel1.Controls.Add(this.score2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SmileStart);
            this.panel1.Controls.Add(this.Expert);
            this.panel1.Controls.Add(this.Hard);
            this.panel1.Controls.Add(this.Easy);
            this.panel1.Location = new System.Drawing.Point(12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 75);
            this.panel1.TabIndex = 0;
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.Location = new System.Drawing.Point(147, 31);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(16, 17);
            this.score1.TabIndex = 8;
            this.score1.Text = "0";
            // 
            // score2
            // 
            this.score2.AutoSize = true;
            this.score2.Location = new System.Drawing.Point(556, 31);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(16, 17);
            this.score2.TabIndex = 7;
            this.score2.Text = "0";
            this.score2.Click += new System.EventHandler(this.Score2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(534, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Player 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player 1";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // SmileStart
            // 
            this.SmileStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SmileStart.BackgroundImage")));
            this.SmileStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SmileStart.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SmileStart.Location = new System.Drawing.Point(327, -3);
            this.SmileStart.Name = "SmileStart";
            this.SmileStart.Size = new System.Drawing.Size(72, 75);
            this.SmileStart.TabIndex = 3;
            this.SmileStart.UseVisualStyleBackColor = true;
            this.SmileStart.Click += new System.EventHandler(this.SmileStart_Click);
            // 
            // Expert
            // 
            this.Expert.AutoSize = true;
            this.Expert.Font = new System.Drawing.Font("Ravie", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expert.Location = new System.Drawing.Point(3, 49);
            this.Expert.Name = "Expert";
            this.Expert.Size = new System.Drawing.Size(96, 23);
            this.Expert.TabIndex = 2;
            this.Expert.TabStop = true;
            this.Expert.Text = "Expert";
            this.Expert.UseVisualStyleBackColor = true;
            this.Expert.CheckedChanged += new System.EventHandler(this.Expert_CheckedChanged);
            // 
            // Hard
            // 
            this.Hard.AutoSize = true;
            this.Hard.Font = new System.Drawing.Font("Ravie", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hard.Location = new System.Drawing.Point(3, 25);
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(77, 23);
            this.Hard.TabIndex = 1;
            this.Hard.TabStop = true;
            this.Hard.Text = "Hard";
            this.Hard.UseVisualStyleBackColor = true;
            // 
            // Easy
            // 
            this.Easy.AutoSize = true;
            this.Easy.Font = new System.Drawing.Font("Ravie", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Easy.Location = new System.Drawing.Point(3, 3);
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(76, 23);
            this.Easy.TabIndex = 0;
            this.Easy.TabStop = true;
            this.Easy.Text = "Easy";
            this.Easy.UseVisualStyleBackColor = true;
            // 
            // Board
            // 
            this.Board.BackgroundImage = global::MineSweeper.Properties.Resources.smilebackground;
            this.Board.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Board.Location = new System.Drawing.Point(15, 81);
            this.Board.Name = "Board";
            this.Board.Size = new System.Drawing.Size(812, 646);
            this.Board.TabIndex = 4;
            // 
            // MinesweeperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 731);
            this.Controls.Add(this.Board);
            this.Controls.Add(this.panel1);
            this.Name = "MinesweeperForm";
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.MinesweeperForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SmileStart;
        private System.Windows.Forms.RadioButton Expert;
        private System.Windows.Forms.RadioButton Hard;
        private System.Windows.Forms.RadioButton Easy;
        private System.Windows.Forms.FlowLayoutPanel Board;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.Label score2;
    }
}

