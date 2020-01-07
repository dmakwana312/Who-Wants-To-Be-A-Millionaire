using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Who_Wants_To_Be_A_Millionaire
{
    public class DatabaseConnectivity
    {
        private static OleDbConnection connection = null;

        // Open Connection
        public static OleDbConnection connect()
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

        // If Connection Is Not Open
        public static void disconnect()
        {
            if (connection != null && connection.State == ConnectionState.Open) connection.Close();
        }
    }
}