using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpPractice
{
    class MathUtility
    {
        public static int AddTwoNumbers(int a, int b) => a + b;

        public static int AddNumbers(params int[] values)
        {
            int res = 0;
            foreach (int value in values)
                res += value;
            return res;
        }

        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
        {
            //Console.WriteLine($"Yearly wage: P{monthlyWage * numberOfMonthsWorked}");
            if (numberOfMonthsWorked == 12) // let's add a bonus month
                return monthlyWage * (numberOfMonthsWorked + 1);
            return monthlyWage * numberOfMonthsWorked;
        }

        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus) 
        {
            return monthlyWage * (numberOfMonthsWorked + bonus);
        }

        public static double CalculateYearlyWage(double monthlyWage, double numberOfMonthsWorked, int bonus)
        {
            return monthlyWage * (numberOfMonthsWorked + bonus);
        }

        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, ref int bonus)
        {
            bonus *= 2;
            return monthlyWage * (numberOfMonthsWorked + bonus);
        }

        public static void GenerateBonus(out int bonus)
        {
            bonus = new Random().Next(1, 10);
        }

        public static int CalculateAverageWage(params int[] wages)
        {
            return AddNumbers(wages) / wages.Length;
        }

    }
}
