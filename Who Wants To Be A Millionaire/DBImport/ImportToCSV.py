import csv

import fileinput


QuestionBank = []
Question = []

with open("Questions.txt") as question_txt_file:

    
        

    for line in question_txt_file:

    

        if line.startswith("#"):
            Question.append(line[6:])

        if line.startswith("*"):
            Question.append(line[1:])
        
        if line.startswith("Answer:"):
            Question.append(line[8:])

        if len(Question) == 6:
            print(Question)
            QuestionBank.append(Question)
            Question = []



with open('Questions.csv', 'w', newline = '') as question_csv_file:
    question_writer = csv.writer(question_csv_file)

    
    for Question in QuestionBank:
        question_writer.writerow(Question)
    

