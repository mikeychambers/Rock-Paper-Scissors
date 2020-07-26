namespace RockPaperScissors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PlayerPaper = new System.Windows.Forms.Button();
            this.PlayerRock = new System.Windows.Forms.Button();
            this.PlayerScissors = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PlayerScore = new System.Windows.Forms.Label();
            this.PCScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerPaper
            // 
            this.PlayerPaper.BackColor = System.Drawing.Color.White;
            this.PlayerPaper.BackgroundImage = global::RockPaperScissors.Properties.Resources.Paper;
            this.PlayerPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PlayerPaper.Location = new System.Drawing.Point(343, 320);
            this.PlayerPaper.Name = "PlayerPaper";
            this.PlayerPaper.Size = new System.Drawing.Size(110, 107);
            this.PlayerPaper.TabIndex = 0;
            this.PlayerPaper.Text = "Paper";
            this.PlayerPaper.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PlayerPaper.UseVisualStyleBackColor = false;
            this.PlayerPaper.Click += new System.EventHandler(this.PlayerPaper_Click);
            // 
            // PlayerRock
            // 
            this.PlayerRock.BackColor = System.Drawing.Color.White;
            this.PlayerRock.BackgroundImage = global::RockPaperScissors.Properties.Resources.Rock;
            this.PlayerRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PlayerRock.Location = new System.Drawing.Point(175, 320);
            this.PlayerRock.Name = "PlayerRock";
            this.PlayerRock.Size = new System.Drawing.Size(113, 107);
            this.PlayerRock.TabIndex = 1;
            this.PlayerRock.Text = "Rock";
            this.PlayerRock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PlayerRock.UseVisualStyleBackColor = false;
            this.PlayerRock.Click += new System.EventHandler(this.PlayerRock_Click);
            // 
            // PlayerScissors
            // 
            this.PlayerScissors.BackColor = System.Drawing.Color.White;
            this.PlayerScissors.BackgroundImage = global::RockPaperScissors.Properties.Resources.Scissors;
            this.PlayerScissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PlayerScissors.Location = new System.Drawing.Point(501, 320);
            this.PlayerScissors.Name = "PlayerScissors";
            this.PlayerScissors.Size = new System.Drawing.Size(124, 107);
            this.PlayerScissors.TabIndex = 2;
            this.PlayerScissors.Text = "Scissors";
            this.PlayerScissors.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PlayerScissors.UseVisualStyleBackColor = false;
            this.PlayerScissors.Click += new System.EventHandler(this.PlayerScissors_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(343, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 116);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(702, 73);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rock, Paper, Scissors!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerScore
            // 
            this.PlayerScore.AutoSize = true;
            this.PlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerScore.Location = new System.Drawing.Point(0, 0);
            this.PlayerScore.Name = "PlayerScore";
            this.PlayerScore.Size = new System.Drawing.Size(141, 25);
            this.PlayerScore.TabIndex = 5;
            this.PlayerScore.Text = "Player Score:";
            // 
            // PCScore
            // 
            this.PCScore.AutoSize = true;
            this.PCScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCScore.Location = new System.Drawing.Point(563, 9);
            this.PCScore.Name = "PCScore";
            this.PCScore.Size = new System.Drawing.Size(173, 25);
            this.PCScore.TabIndex = 6;
            this.PCScore.Text = "Computer Score:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PCScore);
            this.Controls.Add(this.PlayerScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PlayerScissors);
            this.Controls.Add(this.PlayerRock);
            this.Controls.Add(this.PlayerPaper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Rock, Paper, Scissors!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayerPaper;
        private System.Windows.Forms.Button PlayerRock;
        private System.Windows.Forms.Button PlayerScissors;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PlayerScore;
        private System.Windows.Forms.Label PCScore;
    }
}

