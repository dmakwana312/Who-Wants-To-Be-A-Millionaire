using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Who_Wants_To_Be_A_Millionaire
{
    public class DatabaseHelper
    {
        private OleDbConnection connection = null;

        // Open Connection
        private SQLiteConnection connect()
        {
            // Create a new database connection:
            SQLiteConnection connection = new SQLiteConnection("Data Source=questionsDatabase.db; Version = 3; New = True; Compress = True; ");
            // Open the connection:
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return connection;
        }

        // Import N number of question from database
        public SQLiteDataReader importNQuestions(int n)
        {
            // Connect to database & create command
            SQLiteConnection connection = connect();
            SQLiteCommand command = connection.CreateCommand();
            
            // Set Query and execute
            command.CommandText = "SELECT * FROM Question WHERE ID IN (SELECT ID FROM Question ORDER BY RANDOM() LIMIT " + n + ")";
            SQLiteDataReader dataReader = command.ExecuteReader();

            // Disconnect and return data from database
            disconnect();
            return dataReader;

        }

        // If Connection Is Not Open
        private void disconnect()
        {
            if (connection != null && connection.State == ConnectionState.Open) connection.Close();
        }
    }
}