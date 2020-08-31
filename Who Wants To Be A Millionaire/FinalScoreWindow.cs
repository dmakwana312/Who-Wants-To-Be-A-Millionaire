using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Who_Wants_To_Be_A_Millionaire
{
    public partial class FinalScoreWindow : Form
    {
        private MainMenu mainMenuForm = null;
        public FinalScoreWindow(string score)
        {
            InitializeComponent();
            lblPrizeAmount.Text = score.Substring(3, score.Length - 3);
        }

        private void FinalScoreWindow_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 179, 179, 179));

            // Draw Line For Title
            pen.Width = 2f;
            e.Graphics.DrawLine(pen, 0, 83, Width, 83);

            // Draw Line For prize amount and button
            pen.Width = 2f;
            e.Graphics.DrawLine(pen, 0, 179, Width, 179);
            e.Graphics.DrawLine(pen, 0, 262, Width, 262);

            pen.Dispose();
        }

        private void btnReturnToMainMenu_Click(object sender, EventArgs e)
        {
            mainMenuForm.Show();
            this.Dispose();
        }

        public void setMainMenuForm(MainMenu form)
        {
            this.mainMenuForm = form;
        }

        private void FinalScoreWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
