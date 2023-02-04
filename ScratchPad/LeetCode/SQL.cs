using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.LeetCode
{
    // This is where various leetcode sql statements will be executed 
    // TODO-1: Access LeetCode database
    // TODO-2: Create function that allows user to populate person/address tables with values, then perform sql query (see MSSQL file)  
    public class SQL
    {
    

        // Constructor 1 (dependency injection - see program file)
        public SQL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Constructor 2 (instantiation)
        public SQL()
        {

        }

        public void WriteOutCitiesFromAddressTable()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT city from Address", conn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string currentCity = Convert.ToString(dr["city"]);
                    Console.WriteLine(currentCity);
                }
            }
                
        }


    }
}
