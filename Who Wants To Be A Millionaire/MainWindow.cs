using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Who_Wants_To_Be_A_Millionaire
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
           

        }

        private void questionPanel_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 179, 179, 179));

            // Draw Line For Question
            pen.Width = 3;
            e.Graphics.DrawLine(pen, 0, 64, questionPanel.Width, 64);

            // Draw Line For Options
            pen.Width = 2f;
            e.Graphics.DrawLine(pen, 0, 146, questionPanel.Width, 146);
            e.Graphics.DrawLine(pen, 0, 202, questionPanel.Width, 202);

            pen.Dispose();


        }

        private void prizePanel_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 179, 179, 179));

            pen.Width = 2f;

            int position = 40;

            for (int control = 0; control <= 15; control++)
            {
                e.Graphics.DrawLine(pen, 0, position, prizePanel.Width, position);
                position += 42;
            }

            pen = new Pen(Color.FromArgb(255, 212, 175, 55), 5);

            Rectangle rect = prizePanel.ClientRectangle;
            rect.Width--;
            rect.Height--;
            e.Graphics.DrawRectangle(pen, rect);

            pen.Dispose();

        }

        private void updateQuestionPanel()
        {
            int counter = 0;

            //List buttons = new List<Button>();
            //Button button;
            //foreach (var textbox in questionPanel.Controls)
            //{
            //    button = (Button)textbox;
            //    button.Text = counter.ToString();
            //    counter++;
            //}

            //foreach (Control ctrl in questionPanel.Controls)
            //{
            //    ctrl.Text = counter.ToString();
            //    counter++;
            //}

            List<Button> buttons = new List<Button>();
            buttons.Add(optionA);
            buttons.Add(optionB);
            buttons.Add(optionC);
            buttons.Add(optionD);

            foreach (Button btn in buttons)
            {
                btn.Text = counter.ToString();
                counter++;
            }



        }

    }
}
