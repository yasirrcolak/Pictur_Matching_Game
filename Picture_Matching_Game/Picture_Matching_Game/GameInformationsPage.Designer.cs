
namespace Picture_Matching_Game
{
    partial class GameInformationsPage
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
            this.label11 = new System.Windows.Forms.Label();
            this.player1NameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.player2NameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.startButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(208, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(413, 39);
            this.label11.TabIndex = 23;
            this.label11.Text = "Oyuncu bilgilerini giriniz.";
            // 
            // player1NameTextBox
            // 
            this.player1NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.player1NameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.player1NameTextBox.Location = new System.Drawing.Point(213, 34);
            this.player1NameTextBox.Name = "player1NameTextBox";
            this.player1NameTextBox.Size = new System.Drawing.Size(309, 38);
            this.player1NameTextBox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(94)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.label6.Location = new System.Drawing.Point(60, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 31);
            this.label6.TabIndex = 14;
            this.label6.Text = "Oyuncu 1:";
            // 
            // player2NameTextBox
            // 
            this.player2NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.player2NameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.player2NameTextBox.Location = new System.Drawing.Point(213, 78);
            this.player2NameTextBox.Name = "player2NameTextBox";
            this.player2NameTextBox.Size = new System.Drawing.Size(309, 38);
            this.player2NameTextBox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(94)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.label1.Location = new System.Drawing.Point(60, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "Oyuncu 2:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.player2NameTextBox);
            this.panel1.Controls.Add(this.player1NameTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(94, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 148);
            this.panel1.TabIndex = 25;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(94)))));
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.startButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.startButton.Location = new System.Drawing.Point(408, 301);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(254, 82);
            this.startButton.TabIndex = 26;
            this.startButton.Text = "Başla";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(94)))));
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.backButton.Location = new System.Drawing.Point(116, 301);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(254, 82);
            this.backButton.TabIndex = 27;
            this.backButton.Text = "Geri";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // GameInformationsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(800, 432);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.MinimizeBox = false;
            this.Name = "GameInformationsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oyun Bilgileri";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox player2NameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox player1NameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button backButton;
    }
}