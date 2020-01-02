import pyodbc

QuestionBank = []
Question = []

with open("Questions.txt") as question_txt_file:

    for line in question_txt_file:

        if line.startswith("#"):
            Question.append(line[6:].strip())

        if line.startswith("*"):
            Question.append(line[1:].strip())
        
        if line.startswith("Answer:"):
            Question.append(line[8:].strip())

        if len(Question) == 6:
            
            QuestionBank.append(Question)
            Question = []

conn = pyodbc.connect(
    r'Driver={MIcrosoft Access Driver (*.mdb, *.accdb)};'
    r'DBQ=D:\\Who Wants To Be A Millionaire\\Who Wants To Be A Millionaire\\Who Wants To Be A Millionaire Database.accdb;'
)

cursor = conn.cursor()

for i in range(len(QuestionBank)):
    Question = QuestionBank[i][0]
    OptionA = QuestionBank[i][1]
    OptionB = QuestionBank[i][2]
    OptionC = QuestionBank[i][3]
    OptionD = QuestionBank[i][4]
    Answer = QuestionBank[i][5]
    cursor.execute("INSERT INTO Question (ID, Question, OptionA, OptionB, OptionC, OptionD, Answer) VALUES(?,?,?,?,?,?,?)", str(i), Question, OptionA, OptionB, OptionC, OptionD, Answer)
    conn.commit()


