using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.LeetCode
{
    // This is where various leetcode sql statements will be executed 

    // SQLite Series: https://www.youtube.com/watch?v=WeNk7Izp_HY&list=PLEKPb3_Ne8orC6DcnkGXtnvxNN97BCb4G&ab_channel=tips%27ntricks
    // SQL Lite reference doc: https://www.sqlite.org/datatype3.html
    public class TableCreator
    {
        // TODO: ReadAndPostData() only returns values from one column

        public static void Run()
        {
            // Welcome screen
            Console.WriteLine("Welcome to the table creator!");
            Console.WriteLine("For now, you can create one table, with two columns, in which each contain two values");

            // Prompt for table name
            Console.Write("What would you like your table to be called? (needs to be one word)");
            string tableName = UI_Helper.ProperUserInput_String(Console.ReadLine());
            Console.Clear();

            // Prompt for column one + values
            Console.Write("Column one's name?");
            string col1Name = UI_Helper.ProperUserInput_String(Console.ReadLine());
            Console.Write("First value in column one?");
            string col1_Val1 = UI_Helper.ProperUserInput_String(Console.ReadLine());
            Console.Write("Second value in column one?");
            string col1_Val2 = UI_Helper.ProperUserInput_String(Console.ReadLine());
            Console.Clear();

            // Prompt for column two + values
            Console.Write("Column two's name?");
            string col2Name = UI_Helper.ProperUserInput_String(Console.ReadLine());
            Console.Write("First value in column two?");
            string col2_Val1 = UI_Helper.ProperUserInput_String(Console.ReadLine());
            Console.Write("Second value in column two?");
            string col2_Val2 = UI_Helper.ProperUserInput_String(Console.ReadLine());
            Console.Clear();



           
            Console.WriteLine("This is your table currently:");
            // Open connection
            SQLiteConnection sqlite_conn = CreateConnection();
            // Create table
            CreateTable(tableName, col1Name, col2Name, sqlite_conn);
            // Insert column and row values
            InsertData(tableName, col1Name, col2Name, col1_Val1, col1_Val2, col2_Val1, col2_Val2, sqlite_conn);
            // Post table data row-by-row
            // Close connection
            ReadAndPostData(tableName, sqlite_conn);
        }

        public static SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source= database.db; Version = 3; New = True; Compress = True; ");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {

            }
            return sqlite_conn;
        }

        //Creates custom table and columns 
        static void CreateTable(string tableName, string column1_Name, string column2_Name, SQLiteConnection conn)
        {
            // Original... 

           /* SQLiteCommand sqlite_cmd;
            string Createsql = "CREATE TABLE SampleTable (Col1 VARCHAR(20), Col2 VARCHAR(20))";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();*/


            // Using command parameters (doesn't work)...

            /*SQLiteCommand sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "CREATE TABLE @tableName (@columnOneName VARCHAR(20), @columnTwoName VARCHAR(20))";
            sqlite_cmd.Parameters.AddWithValue("@tableName", tableName);
            sqlite_cmd.Parameters.AddWithValue("@columnOneName", column1_Name);
            sqlite_cmd.Parameters.AddWithValue("@columnTwoName", column2_Name);
            sqlite_cmd.ExecuteNonQuery();*/


            // Using string concat (bad practice?)

            SQLiteCommand sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = $"CREATE TABLE {tableName} ({column1_Name} VARCHAR(20), {column2_Name} VARCHAR(20))";
            sqlite_cmd.ExecuteNonQuery();


        }

        static void InsertData(string tableName, string colOneName, string colTwoName, string colOneValOne, string colOneValTwo, string colTwoValOne, string colTwoValTwo, SQLiteConnection conn)
        {
            // Original...

            /*SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO SampleTable (Col1, Col2) VALUES('Test Text ', 1); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO SampleTable (Col1, Col2) VALUES('Test1 Text1 ', 2); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO SampleTable (Col1, Col2) VALUES('Test2 Text2 ', 3); ";
            sqlite_cmd.ExecuteNonQuery();*/


            // Using command parameters (doesn't work)...

            /*SQLiteCommand sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO @tableName (@columnOneName, @columnTwoName) VALUES(@colOneValOne, @colTwoValOne); ";
            sqlite_cmd.Parameters.Add(new SQLiteParameter("@tableName", tableName));
            sqlite_cmd.Parameters.Add(new SQLiteParameter("@columnOneName", colOneName));
            sqlite_cmd.Parameters.Add(new SQLiteParameter("@columnTwoName", colTwoName));
            sqlite_cmd.Parameters.Add(new SQLiteParameter("@colOneValOne", colOneValOne));
            sqlite_cmd.Parameters.Add(new SQLiteParameter("@colTwoValOne", colTwoValOne));
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO @tableName  (@columnOneName, @columnTwoName) VALUES(@colOneValTwo, @colTwoValTwo); ";
            sqlite_cmd.Parameters.Add(new SQLiteParameter("@tableName", tableName));
             sqlite_cmd.Parameters.Add(new SQLiteParameter("@columnOneName", colOneName));
            sqlite_cmd.Parameters.Add(new SQLiteParameter("@columnTwoName", colTwoName));
            sqlite_cmd.Parameters.Add(new SQLiteParameter("@colOneValTwo", colOneValTwo));
            sqlite_cmd.Parameters.Add(new SQLiteParameter("@colTwoValTwo", colTwoValTwo));
            sqlite_cmd.ExecuteNonQuery();*/




            SQLiteCommand sqlite_cmd = conn.CreateCommand();
            // String values need to be surrounded by single ticks 
            sqlite_cmd.CommandText = $"INSERT INTO {tableName} ({colOneName}, {colTwoName}) VALUES('{colOneValOne}', '{colTwoValOne}'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = $"INSERT INTO {tableName} ({colOneName}, {colTwoName}) VALUES('{colOneValTwo}', '{colTwoValTwo}'); ";
            sqlite_cmd.ExecuteNonQuery();


        }

        static void ReadAndPostData(string tableName, SQLiteConnection conn)
        {
            // Original... 

            /*SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM SampleTable";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                string myreader = sqlite_datareader.GetString(0);
                Console.WriteLine(myreader);
            }
            conn.Close();*/


            SQLiteCommand sqlite_cmd = conn.CreateCommand();

            // Using command parameters (doesn't work)
           /* sqlite_cmd.CommandText = "SELECT * FROM @TableName";
            sqlite_cmd.Parameters.AddWithValue("@TableName", tableName);*/



            // Using string concat
            sqlite_cmd.CommandText = $"SELECT * FROM {tableName}";



            SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                string myreader = sqlite_datareader.GetString(0);
                Console.WriteLine(myreader);
            }
            conn.Close();




        }

    }
}
