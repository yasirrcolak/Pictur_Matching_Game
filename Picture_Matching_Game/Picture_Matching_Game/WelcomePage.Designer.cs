
namespace Picture_Matching_Game
{
    partial class WelcomePage
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
            this.playButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.highScoresButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(94)))));
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.playButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.playButton.Location = new System.Drawing.Point(175, 134);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(254, 82);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Oyna";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(98, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "Resim Eşleştirme Oyunu";
            // 
            // highScoresButton
            // 
            this.highScoresButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(94)))));
            this.highScoresButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.highScoresButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.highScoresButton.Location = new System.Drawing.Point(175, 233);
            this.highScoresButton.Name = "highScoresButton";
            this.highScoresButton.Size = new System.Drawing.Size(254, 82);
            this.highScoresButton.TabIndex = 10;
            this.highScoresButton.Text = "Yüksek Skorlar";
            this.highScoresButton.UseVisualStyleBackColor = false;
            this.highScoresButton.Click += new System.EventHandler(this.highScoresButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(94)))));
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.quitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.quitButton.Location = new System.Drawing.Point(175, 359);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(254, 82);
            this.quitButton.TabIndex = 11;
            this.quitButton.Text = "Çıkış";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(621, 465);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.highScoresButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playButton);
            this.MaximizeBox = false;
            this.Name = "WelcomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button highScoresButton;
        private System.Windows.Forms.Button quitButton;
    }
}

