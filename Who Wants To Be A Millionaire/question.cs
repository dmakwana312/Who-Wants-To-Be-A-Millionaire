using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Who_Wants_To_Be_A_Millionaire
{
    class question
    {

        string questionText { get; }
        string[] options { get; }
        string answer;

        // Constructor to set question, add options to array and set answer
        public question(string questionText, string optionA, string optionB, string optionC, string optionD, string answer)
        {
            this.questionText = questionText;
            options.Append(optionA);
            options.Append(optionB); 
            options.Append(optionC); 
            options.Append(optionD);
            this.answer = answer;
        }

        // Check if selected option is correct
        public bool checkAnswer (string selectedOpttion)
        {
            if(this.answer == selectedOpttion)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
