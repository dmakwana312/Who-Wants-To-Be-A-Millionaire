using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Serialization;

namespace Who_Wants_To_Be_A_Millionaire
{
    public partial class MainWindow : Form
    {

        private int questionNo = 0;
        private QuestionBank bank = null;
        private Question currentQuestion = null;

        List<Button> buttons = new List<Button>();
        LinkedList prizeList = new LinkedList();

        LinkedListNode currentPrize = null;
        LinkedListNode lastCheckpoint = null;

        Random randomNumberGenerator = new Random();


        public MainWindow()
        {
            InitializeComponent();
            bank = new QuestionBank();
            buttons.Add(btnOptionA);
            buttons.Add(btnOptionB);
            buttons.Add(btnOptionC);
            buttons.Add(btnOptionD);

            disableOptionButtons();

            prizeList.addToList(new LinkedListNode(prize1, false));
            prizeList.addToList(new LinkedListNode(prize2, false));
            prizeList.addToList(new LinkedListNode(prize3, false));
            prizeList.addToList(new LinkedListNode(prize4, false));
            prizeList.addToList(new LinkedListNode(prize5, true));
            prizeList.addToList(new LinkedListNode(prize6, false));
            prizeList.addToList(new LinkedListNode(prize7, false));
            prizeList.addToList(new LinkedListNode(prize8, false));
            prizeList.addToList(new LinkedListNode(prize9, false));
            prizeList.addToList(new LinkedListNode(prize10, true));
            prizeList.addToList(new LinkedListNode(prize11, false));
            prizeList.addToList(new LinkedListNode(prize12, false));
            prizeList.addToList(new LinkedListNode(prize13, false));
            prizeList.addToList(new LinkedListNode(prize14, false));
            prizeList.addToList(new LinkedListNode(prize15, true));


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
            chartPollResults.Visible = false;
            if (questionNo == 0)
            {
                nextQuestionbtn.Text = "Next Question";
            }
            if (questionNo < 15)
            {
                resetButtons();
                currentQuestion = bank.getQuestion(questionNo);
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
            if (currentQuestion.checkAnswer(selectedOption.Text.Substring(3, selectedOption.Text.Length - 3)))
            {
                selectedOption.BackgroundImage = Image.FromFile("C:\\Users\\Dipesh\\Documents\\GitHub Projects\\Who Wants To Be A Millionaire\\Who Wants To Be A Millionaire\\img\\correct.png");

                if (questionNo == 0)
                {

                    currentPrize = prizeList.getHead();
                }
                else
                {
                    currentPrize.resetBackground();
                    currentPrize = currentPrize.getNext();
                }

                currentPrize.setPrizeBackground();
                if (currentPrize.getCheckpoint())
                {
                    lastCheckpoint = currentPrize;
                }

                questionNo += 1;
            }
            else
            {
                selectedOption.BackgroundImage = Image.FromFile("C:\\Users\\Dipesh\\Documents\\GitHub Projects\\Who Wants To Be A Millionaire\\Who Wants To Be A Millionaire\\img\\wrong.png");
                if (lastCheckpoint != null)
                {
                    currentPrize.setWrongBackground();
                    lastCheckpoint.setPrizeBackground();
                }
            }

        }

        private void resetButtons()
        {
            foreach (Button button in buttons)
            {
                button.BackgroundImage = Image.FromFile("C:\\Users\\Dipesh\\Documents\\GitHub Projects\\Who Wants To Be A Millionaire\\Who Wants To Be A Millionaire\\img\\button.png");
            }
        }

        private void disableOptionButtons()
        {
            foreach (Button button in buttons)
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

        private void btnLifelineSwap_Click(object sender, EventArgs e)
        {
            currentQuestion = bank.getLifeLineSwapQuestion();

            lblQuestion.Text = currentQuestion.getQuestionText();


            var optionsAndButtons = currentQuestion.getOptions().Zip(buttons, (option, button) => new { Option = option, Button = button });

            foreach (var ob in optionsAndButtons)
            {
                ob.Button.Text = ob.Button.Text.Remove(3, ob.Button.Text.Length - 3).Insert(3, ob.Option);
            }

            btnLifelineSwap.BackgroundImage = Image.FromFile("C:\\Users\\Dipesh\\Documents\\GitHub Projects\\Who Wants To Be A Millionaire\\Who Wants To Be A Millionaire\\img\\swapDisabled.png");

            btnLifelineSwap.Enabled = false;

        }

        private void btnLifeline5050_Click(object sender, EventArgs e)
        {
            int firstOptionToRemove = randomNumberGenerator.Next(0, buttons.Count);

            while (currentQuestion.checkAnswer(buttons[firstOptionToRemove].Text.Substring(3, buttons[firstOptionToRemove].Text.Length - 3)))
            {
                firstOptionToRemove = randomNumberGenerator.Next(0, buttons.Count);
            }

            buttons[firstOptionToRemove].Enabled = false;

            int secondOptionToRemove = randomNumberGenerator.Next(0, buttons.Count);

            while (currentQuestion.checkAnswer(buttons[secondOptionToRemove].Text.Substring(3, buttons[secondOptionToRemove].Text.Length - 3)) || secondOptionToRemove == firstOptionToRemove)
            {
                secondOptionToRemove = randomNumberGenerator.Next(0, buttons.Count);
            }

            buttons[secondOptionToRemove].Enabled = false;

            btnLifeline5050.BackgroundImage = Image.FromFile("C:\\Users\\Dipesh\\Documents\\GitHub Projects\\Who Wants To Be A Millionaire\\Who Wants To Be A Millionaire\\img\\5050Disabled.png");

            btnLifeline5050.Enabled = false;

        }

        private void btnLifelineAudience_Click(object sender, EventArgs e)
        {

            List<PollResult> pollResults = new List<PollResult>();

            List<int> randomNumbers = generateRandomPollResults();

            Boolean correctAnswerPollResultAdded = false;
            for (int idx = 0; idx < buttons.Count; idx++)
            {
                if (buttons[idx].Enabled == true)
                {

                    if (currentQuestion.checkAnswer(buttons[idx].Text.Substring(3)))
                    {

                        pollResults.Add(new PollResult(buttons[idx].Text.Substring(0, 1), randomNumbers[randomNumbers.Count - 1]));

                        correctAnswerPollResultAdded = true;
                        randomNumbers.RemoveAt(randomNumbers.Count - 1);

                    }
                    else
                    {
                        int randomPollResultIndex;
                        if (correctAnswerPollResultAdded)
                        {
                            if (randomNumbers.Count != 1)
                            {
                                randomPollResultIndex = randomNumberGenerator.Next(0, randomNumbers.Count - 2);
                            }
                            else
                            {
                                randomPollResultIndex = 0;
                            }

                        }
                        else
                        {
                            randomPollResultIndex = randomNumberGenerator.Next(0, randomNumbers.Count - 1);

                        }
                        pollResults.Add(new PollResult(buttons[idx].Text.Substring(0, 1), randomNumbers[randomPollResultIndex]));


                        randomNumbers.RemoveAt(randomPollResultIndex);
                    }
                }

            }

            displayPollResultsOnGraph(pollResults);

            btnLifelineAudience.BackgroundImage = Image.FromFile("C:\\Users\\Dipesh\\Documents\\GitHub Projects\\Who Wants To Be A Millionaire\\Who Wants To Be A Millionaire\\img\\audienceDisabled.png");

            btnLifelineAudience.Enabled = false;

        }

        private void displayPollResultsOnGraph(List<PollResult> pollResults)
        {
            chartPollResults.Series.Clear();
            chartPollResults.Series.Add("poll");

            chartPollResults.Series[0].BackGradientStyle = GradientStyle.LeftRight;
            chartPollResults.Series[0].Color = Color.FromArgb(212, 175, 55);
            chartPollResults.Series[0].BackSecondaryColor = Color.Black;


            foreach (PollResult poll in pollResults)
            {

                chartPollResults.Series["poll"].Points.AddXY(Convert.ToString(poll.getoptionKey()), poll.getValue());

            }

            chartPollResults.Visible = true;
        }

        private List<int> generateRandomPollResults()
        {

            List<int> randomNumbers = new List<int>();

            if (btnLifeline5050.Enabled == true)
            {
                randomNumbers.Add(randomNumberGenerator.Next(1, 25));

                randomNumbers.Add(randomNumberGenerator.Next(25, 50) - randomNumbers[0]);

                randomNumbers.Add(randomNumberGenerator.Next(50, 75) - randomNumbers[1]);

                randomNumbers.Add(100 - (randomNumbers[0] + randomNumbers[1] + randomNumbers[2]));
            }
            else
            {
                randomNumbers.Add(randomNumberGenerator.Next(1, 50));

                randomNumbers.Add(100 - randomNumbers[0]);
            }

            randomNumbers.Sort();

            return randomNumbers;

        }

    }

    
}