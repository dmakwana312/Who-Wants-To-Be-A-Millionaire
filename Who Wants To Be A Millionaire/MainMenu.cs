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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 179, 179, 179));

            // Draw Line For Title
            pen.Width = 2f;
            e.Graphics.DrawLine(pen, 0, 83, Width, 83);

            // Draw Line For Buttons
            pen.Width = 2f;
            e.Graphics.DrawLine(pen, 0, 179, Width, 179);
            e.Graphics.DrawLine(pen, 0, 262, Width, 262);

            pen.Dispose();
        }

        private void startGamebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new MainWindow()).Show();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
