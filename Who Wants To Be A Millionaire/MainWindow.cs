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
        // Attributes to keep track of questions
        private int questionNo = 0;
        private QuestionBank bank = null;
        private Question currentQuestion = null;

        // Linked List that will hold the prize signs on the right of the screen and list for option buttons
        List<Button> buttons = new List<Button>();
        LinkedList prizeList = new LinkedList();

        // Attributes to keep track of current prize and previously achieved checkpoint
        LinkedListNode currentPrize = null;
        LinkedListNode lastCheckpoint = null;

        // Random Number Generator
        Random randomNumberGenerator = new Random();

        // Constructor
        public MainWindow()
        {
            InitializeComponent();
            
            // Import questions from database
            bank = new QuestionBank();

            // Add option buttons to list and disable them
            buttons.Add(btnOptionA);
            buttons.Add(btnOptionB);
            buttons.Add(btnOptionC);
            buttons.Add(btnOptionD);
            disableOptionButtons();

            // Add prize signs to linked list
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


        // Draw lines on question panel
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


        // Draw lines on prize panel on right of screen
        private void prizePanel_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 179, 179, 179));

            // Draw lines for each prize
            pen.Width = 2f;
            int position = 40;

            for (int control = 0; control <= 15; control++)
            {
                e.Graphics.DrawLine(pen, 0, position, prizePanel.Width, position);
                position += 42;
            }
            
            // Draw border around prize panel;
            pen = new Pen(Color.FromArgb(255, 212, 175, 55), 5);

            Rectangle rect = prizePanel.ClientRectangle;
            rect.Width--;
            rect.Height--;
            e.Graphics.DrawRectangle(pen, rect);

            pen.Dispose();
        }

        // Next question button event handler
        private void nextQuestionbtn_Click(object sender, System.EventArgs e)
        {
            
            // Enable option buttons and set audience poll chart visibility to false
            enableOptionButtons();
            chartPollResults.Visible = false;

            // If first question set text of start button to next question
            if (questionNo == 0)
            {
                nextQuestionbtn.Text = "Next Question";
            }

            if (questionNo < 15)
            {
                // Reset buttons backgrounds and get next question
                resetButtonBackgrounds();
                currentQuestion = bank.getQuestion(questionNo);
                lblQuestion.Text = currentQuestion.getQuestionText();

                // Set option button texts
                var optionsAndButtons = currentQuestion.getOptions().Zip(buttons, (option, button) => new { Option = option, Button = button });

                foreach (var ob in optionsAndButtons)
                {
                    ob.Button.Text = ob.Button.Text.Remove(3, ob.Button.Text.Length - 3).Insert(3, ob.Option);
                }
            }

            // Set text of countdown timer, hide next question button and start timer.
            setCountdownTimerText();
            nextQuestionbtn.Visible = false;
            countdownTimer.Start();
        }

        // Set countdown timer start value based on question number
        public void setCountdownTimerText()
        {
            if(questionNo < 10)
            {
                timer.Text = "60";
            }
            else
            {
                timer.Text = "45";
            }
        }

        // Option A button event handler
        private void btnOptionA_Click(object sender, System.EventArgs e)
        {
            answerCheck(btnOptionA);
        }

        // Option B button event handler
        private void btnOptionB_Click(object sender, System.EventArgs e)
        {
            answerCheck(btnOptionB);
        }

        // Option C button event handler
        private void btnOptionC_Click(object sender, System.EventArgs e)
        {
            answerCheck(btnOptionC);
        }

        // Option D button event handler
        private void btnOptionD_Click(object sender, System.EventArgs e)
        {
            answerCheck(btnOptionD);
        }

        // Check answer selected
        private void answerCheck(Button selectedOption)
        {

            // Stop countdown and make next question button invisible
            countdownTimer.Stop();
            nextQuestionbtn.Visible = true;

            // If correct answer selected
            if (currentQuestion.checkAnswer(selectedOption.Text.Substring(3, selectedOption.Text.Length - 3)))
            {
                // Set background image of option selected to correct
                selectedOption.BackgroundImage = Image.FromFile("C:\\Users\\Dipesh\\Documents\\GitHub Projects\\Who Wants To Be A Millionaire\\Who Wants To Be A Millionaire\\img\\correct.png");

                // If first question, current prize is head of prize linked list
                if (questionNo == 0)
                {
                    currentPrize = prizeList.getHead();
                }

                // Else reset background of current prize and current prize assigned to next node in list
                else
                {
                    currentPrize.resetBackground();
                    currentPrize = currentPrize.getNext();
                }

                // Set prize background of current prize
                currentPrize.setPrizeBackground();

                // If current prize is checkpoint, set lastcheckpoint accordingly
                if (currentPrize.getCheckpoint())
                {
                    lastCheckpoint = currentPrize;
                }

                // Increment question number
                questionNo += 1;
            }

            // If selected option incorrect
            else
            {
                // Set selected option background image to incorrect background
                selectedOption.BackgroundImage = Image.FromFile("C:\\Users\\Dipesh\\Documents\\GitHub Projects\\Who Wants To Be A Millionaire\\Who Wants To Be A Millionaire\\img\\wrong.png");

                // If checkpoint has been passed set prize background of checkpoint
                if (lastCheckpoint != null)
                {
                    lastCheckpoint.setPrizeBackground();
                }

                // Set wrong background to current prize and disable option buttons
                currentPrize.setWrongBackground();
                disableOptionButtons();
            }

        }

        // Reset button backgrounds
        private void resetButtonBackgrounds()
        {
            foreach (Button button in buttons)
            {
                button.BackgroundImage = Image.FromFile("C:\\Users\\Dipesh\\Documents\\GitHub Projects\\Who Wants To Be A Millionaire\\Who Wants To Be A Millionaire\\img\\button.png");
            }
        }

        // Disable option buttons
        private void disableOptionButtons()
        {
            foreach (Button button in buttons)
            {
                button.Enabled = false;
            }
        }

        // Enable option buttons
        private void enableOptionButtons()
        {
            foreach (Button button in buttons)
            {
                button.Enabled = true;
            }
        }

        // Swap the question
        private void btnLifelineSwap_Click(object sender, EventArgs e)
        {

            // Current question assigned to life line question and question text set
            currentQuestion = bank.getLifeLineSwapQuestion();
            lblQuestion.Text = currentQuestion.getQuestionText();

            // Set text of option buttons
            var optionsAndButtons = currentQuestion.getOptions().Zip(buttons, (option, button) => new { Option = option, Button = button });

            foreach (var ob in optionsAndButtons)
            {
                ob.Button.Text = ob.Button.Text.Remove(3, ob.Button.Text.Length - 3).Insert(3, ob.Option);
            }

            // Set background of swap lifeline buttons and disable
            btnLifelineSwap.BackgroundImage = Image.FromFile("C:\\Users\\Dipesh\\Documents\\GitHub Projects\\Who Wants To Be A Millionaire\\Who Wants To Be A Millionaire\\img\\swapDisabled.png");
            btnLifelineSwap.Enabled = false;

        }

        // 50/50 lifeline button
        private void btnLifeline5050_Click(object sender, EventArgs e)
        {
            // Generate number between 0 and 3 based on which option to remove
            int firstOptionToRemove = randomNumberGenerator.Next(0, buttons.Count);

            // If the number generated is for the correct answer, generate a new number
            while (currentQuestion.checkAnswer(buttons[firstOptionToRemove].Text.Substring(3, buttons[firstOptionToRemove].Text.Length - 3)))
            {
                firstOptionToRemove = randomNumberGenerator.Next(0, buttons.Count);
            }

            // Disable removed option button
            buttons[firstOptionToRemove].Enabled = false;

            // Generate number between 0 and 3 based on which option to remove
            int secondOptionToRemove = randomNumberGenerator.Next(0, buttons.Count);

            // If the number generated is for the correct answer, generate a new number
            while (currentQuestion.checkAnswer(buttons[secondOptionToRemove].Text.Substring(3, buttons[secondOptionToRemove].Text.Length - 3)) || secondOptionToRemove == firstOptionToRemove)
            {
                secondOptionToRemove = randomNumberGenerator.Next(0, buttons.Count);
            }

            // Disable removed option button
            buttons[secondOptionToRemove].Enabled = false;

            // Set background of 50/50 lifeline buttons and disable
            btnLifeline5050.BackgroundImage = Image.FromFile("C:\\Users\\Dipesh\\Documents\\GitHub Projects\\Who Wants To Be A Millionaire\\Who Wants To Be A Millionaire\\img\\5050Disabled.png");
            btnLifeline5050.Enabled = false;

        }

        // Audience poll lifeline
        private void btnLifelineAudience_Click(object sender, EventArgs e)
        {

            // List of poll results
            List<PollResult> pollResults = new List<PollResult>();

            // List to hold generated random numbers (last value in list will be highest)
            List<int> randomNumbers = generateRandomPollResults();

            // Value to check if poll is added for correct
            Boolean correctAnswerPollResultAdded = false;

            // Loop through buttons
            for (int idx = 0; idx < buttons.Count; idx++)
            {

                // If button is enabled
                if (buttons[idx].Enabled == true)
                {

                    // If the button is for the correct option, add the final value from list and remove value from list
                    if (currentQuestion.checkAnswer(buttons[idx].Text.Substring(3)))
                    {

                        pollResults.Add(new PollResult(buttons[idx].Text.Substring(0, 1), randomNumbers[randomNumbers.Count - 1]));

                        correctAnswerPollResultAdded = true;
                        randomNumbers.RemoveAt(randomNumbers.Count - 1);

                    }
                    else
                    {
                        int randomPollResultIndex;

                        // If poll for correct answer is added, add random number from whole, else exclude final value
                        if (correctAnswerPollResultAdded)
                        {
                            if (randomNumbers.Count != 1)
                            {
                                randomPollResultIndex = randomNumberGenerator.Next(0, randomNumbers.Count - 1);
                            }
                            else
                            {
                                randomPollResultIndex = 0;
                            }

                        }
                        else
                        {
                            randomPollResultIndex = randomNumberGenerator.Next(0, randomNumbers.Count - 2);

                        }

                        // Add poll result to list
                        pollResults.Add(new PollResult(buttons[idx].Text.Substring(0, 1), randomNumbers[randomPollResultIndex]));
                        
                        // Remove value from list to prevent repetition
                        randomNumbers.RemoveAt(randomPollResultIndex);
                    }
                }

            }

            // Display results on graph
            displayPollResultsOnGraph(pollResults);

            // Set disabled background of lifeline and disable button
            btnLifelineAudience.BackgroundImage = Image.FromFile("C:\\Users\\Dipesh\\Documents\\GitHub Projects\\Who Wants To Be A Millionaire\\Who Wants To Be A Millionaire\\img\\audienceDisabled.png");
            btnLifelineAudience.Enabled = false;

        }

        // Add poll results to graph
        private void displayPollResultsOnGraph(List<PollResult> pollResults)
        {
            // Clear graph and add series
            chartPollResults.Series.Clear();
            chartPollResults.Series.Add("poll");

            // Set styling
            chartPollResults.Series[0].BackGradientStyle = GradientStyle.LeftRight;
            chartPollResults.Series[0].Color = Color.FromArgb(212, 175, 55);
            chartPollResults.Series[0].BackSecondaryColor = Color.Black;

            // Add each poll results with letter to correspond to button
            foreach (PollResult poll in pollResults)
            {
                chartPollResults.Series["poll"].Points.AddXY(Convert.ToString(poll.getoptionKey()), poll.getValue());
            }

            // Set chart to visible
            chartPollResults.Visible = true;
        }

        // Generate poll results
        private List<int> generateRandomPollResults()
        {

            List<int> randomNumbers = new List<int>();

            // If 50/50 lifeline has not been used generate 4 numbers else generate 2
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

            // Sort list of numbers and return
            randomNumbers.Sort();
            return randomNumbers;

        }

        // Countdown timer
        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            // If visible timer is not 0, decrement value, else stop countdown
            if(Convert.ToInt32(timer.Text) != 0)
            {
                timer.Text = Convert.ToString(Convert.ToInt32(timer.Text) - 1);
            }

            else
            {
                countdownTimer.Stop();
                
            }
        }
    }

    
}