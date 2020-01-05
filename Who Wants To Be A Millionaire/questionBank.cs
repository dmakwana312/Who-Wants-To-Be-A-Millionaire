﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Who_Wants_To_Be_A_Millionaire
{
    class questionBank 
    {
        List<question> questions = new List<question>();
        question lifeLineSwapQuestion = null;

        // Constructor to retrieve and accordingly set questions
        public questionBank()
        {
            setQuestions();
            setLifeLineSwapQuestion();
        }

        // Import N number of question from database
        public DataSet importNQuestions(int n)
        {
            string query = "SELECT top " + n + " * FROM Question ORDER BY rnd(ID)";

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, databaseConnectivity.connect());
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);

            databaseConnectivity.disconnect();
            return dataset;
        }

        // Set the main 15 questions
        public void setQuestions()
        {
            DataSet dataset = importNQuestions(15);

            for (int row = 0; row < dataset.Tables[0].Rows.Count; row++)
            {
                this.questions.Add(new question(dataset.Tables[0].Rows[row].ItemArray[1].ToString(), dataset.Tables[0].Rows[row].ItemArray[2].ToString(), dataset.Tables[0].Rows[row].ItemArray[3].ToString(), dataset.Tables[0].Rows[row].ItemArray[4].ToString(), dataset.Tables[0].Rows[row].ItemArray[5].ToString(), dataset.Tables[0].Rows[row].ItemArray[6].ToString()));
            }

            Console.WriteLine("Questions: " + this.questions.Count);
        }

        // Set question for the swap lifeline
        public void setLifeLineSwapQuestion()
        {
            DataSet dataset = importNQuestions(1);
            this.lifeLineSwapQuestion = new question(dataset.Tables[0].Rows[0].ItemArray[1].ToString(), dataset.Tables[0].Rows[0].ItemArray[2].ToString(), dataset.Tables[0].Rows[0].ItemArray[3].ToString(), dataset.Tables[0].Rows[0].ItemArray[4].ToString(), dataset.Tables[0].Rows[0].ItemArray[5].ToString(), dataset.Tables[0].Rows[0].ItemArray[6].ToString());
        }

        // Retrieve a question
        public question getQuestion(int questionNumber)
        {
            return questions[questionNumber];
        }

        // Retrieve question for the swap lifeline
        public question getLifeLineSwapQuestion()
        {
            return lifeLineSwapQuestion;
        }
    }
}