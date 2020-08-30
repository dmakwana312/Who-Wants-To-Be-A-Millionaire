namespace Who_Wants_To_Be_A_Millionaire
{
    partial class FinalScoreWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalScoreWindow));
            this.lblTitle = new System.Windows.Forms.Button();
            this.btnReturnToMainMenu = new System.Windows.Forms.Button();
            this.lblPrizeAmount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lblTitle.BackgroundImage")));
            this.lblTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblTitle.FlatAppearance.BorderSize = 0;
            this.lblTitle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.lblTitle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Maiandra GD", 25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblTitle.Location = new System.Drawing.Point(21, 51);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(422, 64);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "You Won:";
            this.lblTitle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.lblTitle.UseVisualStyleBackColor = true;
            // 
            // btnReturnToMainMenu
            // 
            this.btnReturnToMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnReturnToMainMenu.BackgroundImage = global::Who_Wants_To_Be_A_Millionaire.Properties.Resources.button;
            this.btnReturnToMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturnToMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturnToMainMenu.FlatAppearance.BorderSize = 0;
            this.btnReturnToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnToMainMenu.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold);
            this.btnReturnToMainMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnReturnToMainMenu.Location = new System.Drawing.Point(136, 241);
            this.btnReturnToMainMenu.Name = "btnReturnToMainMenu";
            this.btnReturnToMainMenu.Size = new System.Drawing.Size(190, 42);
            this.btnReturnToMainMenu.TabIndex = 11;
            this.btnReturnToMainMenu.Text = "Main Menu";
            this.btnReturnToMainMenu.UseVisualStyleBackColor = false;
            // 
            // lblPrizeAmount
            // 
            this.lblPrizeAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblPrizeAmount.BackgroundImage = global::Who_Wants_To_Be_A_Millionaire.Properties.Resources.button;
            this.lblPrizeAmount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblPrizeAmount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPrizeAmount.FlatAppearance.BorderSize = 0;
            this.lblPrizeAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrizeAmount.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold);
            this.lblPrizeAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblPrizeAmount.Location = new System.Drawing.Point(135, 158);
            this.lblPrizeAmount.Name = "lblPrizeAmount";
            this.lblPrizeAmount.Size = new System.Drawing.Size(190, 42);
            this.lblPrizeAmount.TabIndex = 10;
            this.lblPrizeAmount.UseVisualStyleBackColor = false;
            // 
            // FinalScoreWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(465, 341);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnReturnToMainMenu);
            this.Controls.Add(this.lblPrizeAmount);
            this.MaximizeBox = false;
            this.Name = "FinalScoreWindow";
            this.Text = "FinalScoreWindow";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FinalScoreWindow_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lblTitle;
        private System.Windows.Forms.Button btnReturnToMainMenu;
        private System.Windows.Forms.Button lblPrizeAmount;
    }
}