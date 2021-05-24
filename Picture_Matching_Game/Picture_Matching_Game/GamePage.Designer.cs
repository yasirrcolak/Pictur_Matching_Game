
namespace Picture_Matching_Game
{
    partial class GamePage
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nextPlayerLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.player2ScoreLabel = new System.Windows.Forms.Label();
            this.player1ScoreLabel = new System.Windows.Forms.Label();
            this.player2NameLabel = new System.Windows.Forms.Label();
            this.player1NameLabel = new System.Windows.Forms.Label();
            this.cardShowTimer = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.roundTimer = new System.Windows.Forms.Timer(this.components);
            this.quitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.timeLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nextPlayerLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.player2ScoreLabel);
            this.panel1.Controls.Add(this.player1ScoreLabel);
            this.panel1.Controls.Add(this.player2NameLabel);
            this.panel1.Controls.Add(this.player1NameLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 104);
            this.panel1.TabIndex = 26;
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.timeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.timeLabel.Location = new System.Drawing.Point(364, 35);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(96, 31);
            this.timeLabel.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(94)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.label3.Location = new System.Drawing.Point(286, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 31);
            this.label3.TabIndex = 24;
            this.label3.Text = "Süre:";
            // 
            // nextPlayerLabel
            // 
            this.nextPlayerLabel.BackColor = System.Drawing.SystemColors.Control;
            this.nextPlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nextPlayerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.nextPlayerLabel.Location = new System.Drawing.Point(95, 35);
            this.nextPlayerLabel.Name = "nextPlayerLabel";
            this.nextPlayerLabel.Size = new System.Drawing.Size(172, 31);
            this.nextPlayerLabel.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(94)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.label2.Location = new System.Drawing.Point(24, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 31);
            this.label2.TabIndex = 22;
            this.label2.Text = "Sıra:";
            // 
            // player2ScoreLabel
            // 
            this.player2ScoreLabel.AutoSize = true;
            this.player2ScoreLabel.BackColor = System.Drawing.SystemColors.Control;
            this.player2ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.player2ScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.player2ScoreLabel.Location = new System.Drawing.Point(640, 53);
            this.player2ScoreLabel.Name = "player2ScoreLabel";
            this.player2ScoreLabel.Size = new System.Drawing.Size(30, 31);
            this.player2ScoreLabel.TabIndex = 21;
            this.player2ScoreLabel.Text = "0";
            // 
            // player1ScoreLabel
            // 
            this.player1ScoreLabel.AutoSize = true;
            this.player1ScoreLabel.BackColor = System.Drawing.SystemColors.Control;
            this.player1ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.player1ScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.player1ScoreLabel.Location = new System.Drawing.Point(640, 13);
            this.player1ScoreLabel.Name = "player1ScoreLabel";
            this.player1ScoreLabel.Size = new System.Drawing.Size(30, 31);
            this.player1ScoreLabel.TabIndex = 20;
            this.player1ScoreLabel.Text = "0";
            // 
            // player2NameLabel
            // 
            this.player2NameLabel.AutoSize = true;
            this.player2NameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(94)))));
            this.player2NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.player2NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.player2NameLabel.Location = new System.Drawing.Point(487, 53);
            this.player2NameLabel.Name = "player2NameLabel";
            this.player2NameLabel.Size = new System.Drawing.Size(147, 31);
            this.player2NameLabel.TabIndex = 19;
            this.player2NameLabel.Text = "Oyuncu 2:";
            // 
            // player1NameLabel
            // 
            this.player1NameLabel.AutoSize = true;
            this.player1NameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(94)))));
            this.player1NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.player1NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.player1NameLabel.Location = new System.Drawing.Point(487, 13);
            this.player1NameLabel.Name = "player1NameLabel";
            this.player1NameLabel.Size = new System.Drawing.Size(147, 31);
            this.player1NameLabel.TabIndex = 14;
            this.player1NameLabel.Text = "Oyuncu 1:";
            // 
            // cardShowTimer
            // 
            this.cardShowTimer.Interval = 1000;
            this.cardShowTimer.Tick += new System.EventHandler(this.cardShowTimer_Tick);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Location = new System.Drawing.Point(127, 122);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(545, 526);
            this.flowLayoutPanel.TabIndex = 9999;
            // 
            // roundTimer
            // 
            this.roundTimer.Interval = 1000;
            this.roundTimer.Tick += new System.EventHandler(this.roundTimer_Tick);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(94)))));
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.quitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.quitButton.Location = new System.Drawing.Point(272, 685);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(254, 82);
            this.quitButton.TabIndex = 10000;
            this.quitButton.Text = "Çıkış";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // GamePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(801, 801);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "GamePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oyun sahası";
            this.Load += new System.EventHandler(this.GamePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label player2NameLabel;
        private System.Windows.Forms.Label player1NameLabel;
        private System.Windows.Forms.Label player2ScoreLabel;
        private System.Windows.Forms.Label player1ScoreLabel;
        private System.Windows.Forms.Label nextPlayerLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer cardShowTimer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Timer roundTimer;
        private System.Windows.Forms.Button quitButton;
    }
}