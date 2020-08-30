namespace Who_Wants_To_Be_A_Millionaire
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.startGamebtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startGamebtn
            // 
            this.startGamebtn.BackColor = System.Drawing.Color.Transparent;
            this.startGamebtn.BackgroundImage = global::Who_Wants_To_Be_A_Millionaire.Properties.Resources.button;
            this.startGamebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startGamebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startGamebtn.FlatAppearance.BorderSize = 0;
            this.startGamebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startGamebtn.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold);
            this.startGamebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.startGamebtn.Location = new System.Drawing.Point(135, 158);
            this.startGamebtn.Name = "startGamebtn";
            this.startGamebtn.Size = new System.Drawing.Size(190, 42);
            this.startGamebtn.TabIndex = 7;
            this.startGamebtn.Text = "Start Game";
            this.startGamebtn.UseVisualStyleBackColor = false;
            this.startGamebtn.Click += new System.EventHandler(this.startGamebtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.Transparent;
            this.exitbtn.BackgroundImage = global::Who_Wants_To_Be_A_Millionaire.Properties.Resources.button;
            this.exitbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitbtn.FlatAppearance.BorderSize = 0;
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbtn.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold);
            this.exitbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.exitbtn.Location = new System.Drawing.Point(136, 241);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(190, 42);
            this.exitbtn.TabIndex = 8;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lblTitle.BackgroundImage")));
            this.lblTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblTitle.FlatAppearance.BorderSize = 0;
            this.lblTitle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.lblTitle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Maiandra GD", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.lblTitle.Location = new System.Drawing.Point(21, 51);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(422, 64);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Who Wants To Be A Millionaire";
            this.lblTitle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.lblTitle.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(465, 341);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.startGamebtn);
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainMenu_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startGamebtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button lblTitle;
    }
}