using Microsoft.VisualStudio.TestTools.UnitTesting;
using Who_Wants_To_Be_A_Millionaire;
namespace Who_Wants_To_Be_A_Millionaire_Tests
{
    [TestClass]
    public class Question_Tests
    {

        Question question = new Question(
            "Question Text",
            "optionA",
            "optionB",
            "optionC",
            "optionD",
            "Correct Answer"
            );

        [TestMethod]
        public void CheckAnswer_WithCorrectAnswer_ReturnsTrue()
        {
      
            // Arrange
            string selectedAnswer = "Correct Answer";

            // Act
            bool actual = question.checkAnswer(selectedAnswer);

            //Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void CheckAnswer_WithWrongAnswer_ReturnsFalse()
        {

            // Arrange
            string selectedAnswer = "Wrong Answer";

            // Act
            bool actual = question.checkAnswer(selectedAnswer);

            //Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void getQuestionText_ReturnsQuestionText()
        {

            // Arrange
            string expected = "Question Text";

            // Act
            string actual = question.getQuestionText();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void getOptions_ReturnsOptions()
        {

            // Arrange
            string[] expected = { "optionA", "optionB", "optionC", "optionD" };

            // Act
            string[] actual = question.getOptions();

            System.Console.WriteLine(actual);
            System.Console.WriteLine(expected);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
