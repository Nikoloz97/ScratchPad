using ScratchPad.Karvonen;
using ScratchPad.LeetCode;
using ScratchPad.NBATrivia;
using ScratchPad.WebGen;
using System;
// Allows you to create lists/arrays
using System.Collections.Generic;
using System.Data.SQLite;
// Allows you to use Console.ReadLine()
using System.IO;
// Allows you to use query statements (like in SQL)
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace ScratchPad
{
    // Roadmap: 
    // Intro to Console apps: https://www.youtube.com/watch?v=8bOoiftm5wM&ab_channel=IAmTimCorey
    // Using SQLite in C#: https://www.youtube.com/watch?v=ayp3tHEkRc0&ab_channel=IAmTimCorey
    // IComparer: https://www.tutorialsteacher.com/articles/sort-object-array-by-specific-property-in-csharp
    // Creating a GUI (using WPF): https://www.youtube.com/watch?v=UMc1HLyBHSQ&list=RDCMUCsvqVGtbbyHaMoevxPAq9Fg&start_radio=1&rv=UMc1HLyBHSQ&t=830&ab_channel=Simplilearn	
    // ASP.NET MVC: https://www.danylkoweb.com/StartHere
    // Creating Web API with ASP.NET Core: https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-7.0&tabs=visual-studio
    // .NET Web API, Entity Framework, CodeFirst Migration: https://www.youtube.com/watch?v=Fbf_ua2t6v4&ab_channel=PatrickGod


    // Other resources:
    // Fibonacci explained: https://www.youtube.com/watch?v=WrWFfzt3ayc&ab_channel=NickWhite
    // SQL Lite reference doc: https://www.sqlite.org/datatype3.html
    // Exercise book: http://repo.darmajaya.ac.id/4045/1/Exercises%20for%20Programmers_%2057%20Challenges%20to%20Develop%20Your%20Coding%20Skills%20%28%20PDFDrive%20%29.pdf
    // How to document classes/functions for intellisense: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/documentation-comments
    // W3 Schools: https://www.w3schools.com/cs/cs_class_members.php
    // Random C# answers to problems: https://www.tutorialsteacher.com/articles/sort-object-array-by-specific-property-in-csharp
    // GforG: https://www.geeksforgeeks.org/c-sharp-tuple/
    // Brendan's Blog (C# Tips): https://brendoneus.com/category/Archives.html
    // Integration tests in ASP.NET Core: https://learn.microsoft.com/en-us/aspnet/core/test/integration-tests?view=aspnetcore-7.0
    // 


    class Program
    {
         static void Main(string[] args)
        {

            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            CreateTable(sqlite_conn);
            InsertData(sqlite_conn);
            ReadData(sqlite_conn);



            UI_Main.MainMenu();

        }

        static SQLiteConnection CreateConnection()
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

        static void CreateTable(SQLiteConnection conn)
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

