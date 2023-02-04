﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.LeetCode
{
    // This is where various leetcode sql statements will be executed 
    // TODO-1: Implement getting SQLite program.cs over here (create address and person tables, implement the join)
    // TODO-2: Hook it up to UI 
    public class TableCreator
    {
    
        public static void Run()
        {
            // Welcome screen
            Console.WriteLine("Welcome to the table creator!");
            Console.WriteLine("For now, you can create two tables, each with two columns, in which each contain two values");

            // Prompt for table name
            Console.Write("What would you like your table to be called?");
            string TableName = UI_Helper.ProperUserInput_String(Console.ReadLine());
            Console.Clear();

            // Prompt for column one + values
            Console.Write("Column one's name?");
            string col1 = UI_Helper.ProperUserInput_String(Console.ReadLine());
            Console.Write("Column one's value one?");
            string col1_Val1 = UI_Helper.ProperUserInput_String(Console.ReadLine());
            Console.Write("Column one's value two?");
            string col1_Val2 = UI_Helper.ProperUserInput_String(Console.ReadLine());
            Console.Clear();

            // Prompt for column two + values
            Console.Write("Column two's name?");
            string columnTwo = UI_Helper.ProperUserInput_String(Console.ReadLine());








            // Place string variables as parameters in functions below


            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            CreateTable(sqlite_conn);
            InsertData(sqlite_conn);
            ReadData(sqlite_conn);
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
        static void CreateTable(string tableName, string column_one, string column_two, SQLiteConnection conn)
        {

            SQLiteCommand sqlite_cmd;
            string Createsql = "CREATE TABLE SampleTable (Col1 VARCHAR(20), Col2 INT)";
            string Createsql1 = "CREATE TABLE SampleTable1 (Col1 VARCHAR(20), Col2 INT)";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = Createsql1;
            sqlite_cmd.ExecuteNonQuery();

        }

        static void InsertData(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO SampleTable (Col1, Col2) VALUES('Test Text ', 1); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO SampleTable (Col1, Col2) VALUES('Test1 Text1 ', 2); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO SampleTable (Col1, Col2) VALUES('Test2 Text2 ', 3); ";
            sqlite_cmd.ExecuteNonQuery();


            sqlite_cmd.CommandText = "INSERT INTO SampleTable1 (Col1, Col2) VALUES('Test3 Text3 ', 3); ";
            sqlite_cmd.ExecuteNonQuery();

        }

        static void ReadData(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM SampleTable";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                string myreader = sqlite_datareader.GetString(0);
                Console.WriteLine(myreader);
            }
            conn.Close();
        }

    }
}
