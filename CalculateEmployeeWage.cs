using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProgram
{
    public class CalculateEmployeeWage
    {
        /// <summary>
        /// UC -2 Calculates the wage.
        /// </summary>
        public static void CalculateWage()
        {
            int WagePerHour = 20;
            int FullWorkingDay = 8;
            int calculateWage = 0;

            Random random = new Random();
            int number = random.Next(2);

            if (number == 1)
            {
                 calculateWage = WagePerHour * FullWorkingDay;

                Console.WriteLine("Calculated Wage = " + calculateWage);

            }
            else
            {
                calculateWage = 0;
                Console.WriteLine("Calculated Wage = " + calculateWage);
            }
        }
    }
}
