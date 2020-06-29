using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Who_Wants_To_Be_A_Millionaire
{
    public class DatabaseHelper
    {
        private  OleDbConnection connection = null;

        // Open Connection
        private OleDbConnection connect()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\Who Wants To Be A Millionaire Database.accdb;"; ;

            connection = new OleDbConnection(connectionString);
            try
            {
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed: " + ex);
                return null;
            }
        }

        // Import N number of question from database
        public DataSet importNQuestions(int n)
        {


            string query = "SELECT top " + n + " * FROM Question ORDER BY rnd(ID)";

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connect());
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);

            disconnect();
            return dataset;
        }

        // If Connection Is Not Open
        private void disconnect()
        {
            if (connection != null && connection.State == ConnectionState.Open) connection.Close();
        }
    }
}