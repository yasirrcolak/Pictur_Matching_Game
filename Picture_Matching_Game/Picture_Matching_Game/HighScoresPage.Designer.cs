
namespace Picture_Matching_Game
{
    partial class HighScoresPage
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
            this.resetbutton = new System.Windows.Forms.Button();
            this.scoreBoardListView = new System.Windows.Forms.ListView();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resetbutton
            // 
            this.resetbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(94)))));
            this.resetbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resetbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.resetbutton.Location = new System.Drawing.Point(108, 504);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(254, 82);
            this.resetbutton.TabIndex = 8;
            this.resetbutton.Text = "Sıfırla";
            this.resetbutton.UseVisualStyleBackColor = false;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // scoreBoardListView
            // 
            this.scoreBoardListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoreBoardListView.HideSelection = false;
            this.scoreBoardListView.Location = new System.Drawing.Point(22, 23);
            this.scoreBoardListView.Name = "scoreBoardListView";
            this.scoreBoardListView.Size = new System.Drawing.Size(444, 463);
            this.scoreBoardListView.TabIndex = 7;
            this.scoreBoardListView.UseCompatibleStateImageBehavior = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(94)))));
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.backButton.Location = new System.Drawing.Point(108, 605);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(254, 82);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Geri";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // HighScoresPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(488, 711);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.scoreBoardListView);
            this.Controls.Add(this.backButton);
            this.MaximizeBox = false;
            this.Name = "HighScoresPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HighScoresPage";
            this.Load += new System.EventHandler(this.HighScoresPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.ListView scoreBoardListView;
        private System.Windows.Forms.Button backButton;
    }
}