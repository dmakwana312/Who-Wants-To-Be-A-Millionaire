using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace Who_Wants_To_Be_A_Millionaire
{
    public class QuestionBank
    {
        // Attributes
        private List<Question> questions = new List<Question>();
        private Question lifeLineSwapQuestion = null;
        private DatabaseHelper databaseHelper = null;

        // Constructor to retrieve and accordingly set questions
        public QuestionBank()
        {
            databaseHelper = new DatabaseHelper();
            setQuestions();
            setLifeLineSwapQuestion();
            
        }

        // Set the main 15 questions
        public void setQuestions()
        {
            DataSet dataset = databaseHelper.importNQuestions(15);

            for (int row = 0; row < dataset.Tables[0].Rows.Count; row++)
            {
                this.questions.Add(new Question(dataset.Tables[0].Rows[row].ItemArray[1].ToString(), dataset.Tables[0].Rows[row].ItemArray[2].ToString(), dataset.Tables[0].Rows[row].ItemArray[3].ToString(), dataset.Tables[0].Rows[row].ItemArray[4].ToString(), dataset.Tables[0].Rows[row].ItemArray[5].ToString(), dataset.Tables[0].Rows[row].ItemArray[6].ToString()));
                
            }
        }

        // Set question for the swap lifeline
        public void setLifeLineSwapQuestion()
        {
            DataSet dataset = databaseHelper.importNQuestions(1);
            this.lifeLineSwapQuestion = new Question(dataset.Tables[0].Rows[0].ItemArray[1].ToString(), dataset.Tables[0].Rows[0].ItemArray[2].ToString(), dataset.Tables[0].Rows[0].ItemArray[3].ToString(), dataset.Tables[0].Rows[0].ItemArray[4].ToString(), dataset.Tables[0].Rows[0].ItemArray[5].ToString(), dataset.Tables[0].Rows[0].ItemArray[6].ToString());
        }

        // Retrieve a question
        public Question getQuestion(int questionNumber)
        {
            return questions[questionNumber];
        }

        // Retrieve question for the swap lifeline
        public Question getLifeLineSwapQuestion()
        {
            return lifeLineSwapQuestion;
        }
    }
}