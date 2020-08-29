using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SQLite;

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
            SQLiteDataReader dataset = databaseHelper.importNQuestions(15);

            while (dataset.Read())
            {
                this.questions.Add(new Question(dataset.GetString(1), dataset.GetString(2), dataset.GetString(3), dataset.GetString(4), dataset.GetString(5), dataset.GetString(6)));

            }
        }

        // Set question for the swap lifeline
        public void setLifeLineSwapQuestion()
        {
            SQLiteDataReader dataset = databaseHelper.importNQuestions(1);
            dataset.Read();
            this.lifeLineSwapQuestion = new Question(dataset.GetString(1), dataset.GetString(2), dataset.GetString(3), dataset.GetString(4), dataset.GetString(5), dataset.GetString(6));
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