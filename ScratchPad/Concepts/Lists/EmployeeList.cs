using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ScratchPad.Concepts.Lists
{
    public class EmployeeList
    {
        public static void GenerateFourEmployees()
        {
            // Create new array List
            ArrayList employees = new ArrayList();


            // Use employee class like a function (when instantiating an object) 
            // Curly brackets = what each class attributes will equal to
            employees.Add(new Employee() { Id = 1, Name = "E1" });
            employees.Add(new Employee() { Id = 2, Name = "E2" });
            employees.Add(new Employee() { Id = 3, Name = "E3" });
            employees.Add(new Employee() { Id = 4, Name = "E4" });

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);

            }
        }
    }
}
