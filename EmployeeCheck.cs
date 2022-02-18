using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProgram
{
    public class EmployeeCheck
    {
        /// <summary>
        /// UC1 - Employees the present or not.
        /// </summary>
        public static void EmployeePresentOrNot()
        {
            Random random = new Random();
            int number = random.Next(2);

            if (number == 1)
            {
                Console.WriteLine("Employee Present");
            }
            else
            {
                Console.WriteLine("Employee Absent");
            }
        }
    }
}
