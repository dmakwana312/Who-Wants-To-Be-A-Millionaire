using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Who_Wants_To_Be_A_Millionaire
{
    public partial class MainWindow : Form
    {

        private int questionNo = 0;
        private QuestionBank bank = null;
        private Question currentQuestion = null;
        
        List<Button> buttons = new List<Button>();
        
        public MainWindow()
        {
            InitializeComponent();
            bank = new QuestionBank();
            buttons.Add(btnOptionA);
            buttons.Add(btnOptionB);
            buttons.Add(btnOptionC);
            buttons.Add(btnOptionD);

            disableOptionButtons();
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

        private void nextQuestionbtn_Click(object sender, System.EventArgs e)
        {
            enableOptionButtons();
            if (questionNo == 0)
            {
                nextQuestionbtn.Text = "Next Question";
            }
            if (questionNo < 15)
            {
                resetButtons();
                currentQuestion = bank.getQuestion(questionNo++);
                lblQuestion.Text = currentQuestion.getQuestionText();
                

                var optionsAndButtons = currentQuestion.getOptions().Zip(buttons, (option, button) => new { Option = option, Button = button });

                foreach (var ob in optionsAndButtons)
                {
                    ob.Button.Text = ob.Button.Text.Remove(3, ob.Button.Text.Length - 3).Insert(3, ob.Option);
                }
            }
        }

        private void btnOptionA_Click(object sender, System.EventArgs e)
        {
            answerCheck(btnOptionA);
        }

        private void btnOptionB_Click(object sender, System.EventArgs e)
        {
            answerCheck(btnOptionB);
        }

        private void btnOptionC_Click(object sender, System.EventArgs e)
        {
            answerCheck(btnOptionC);
        }

        private void btnOptionD_Click(object sender, System.EventArgs e)
        {
            answerCheck(btnOptionD);
        }

        private void answerCheck(Button selectedOption)
        {
            if(currentQuestion.checkAnswer(selectedOption.Text.Substring(3, selectedOption.Text.Length - 3)))
            {
                selectedOption.BackgroundImage = Image.FromFile("C:\\Users\\Dipesh\\Documents\\GitHub Projects\\Who Wants To Be A Millionaire\\Who Wants To Be A Millionaire\\img\\correct.png");
                
            }
            else
            {
                selectedOption.BackgroundImage = Image.FromFile("C:\\Users\\Dipesh\\Documents\\GitHub Projects\\Who Wants To Be A Millionaire\\Who Wants To Be A Millionaire\\img\\wrong.png");
            }

        }

        private void resetButtons()
        {
            foreach(Button button in buttons)
            {
                button.BackgroundImage = Image.FromFile("C:\\Users\\Dipesh\\Documents\\GitHub Projects\\Who Wants To Be A Millionaire\\Who Wants To Be A Millionaire\\img\\button.png");
            }
        }

        private void disableOptionButtons()
        {
            foreach(Button button in buttons)
            {
                button.Enabled = false;
            }
        }

        private void enableOptionButtons()
        {
            foreach (Button button in buttons)
            {
                button.Enabled = true;
            }
        }
    }
}