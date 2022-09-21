using System;
using System.Collections.Generic;
using math = CsharpPractice.MathUtility;
using CsharpPractice.HR;
using CsharpPractice.Accounting;
using Polygons.Library;

namespace CsharpPractice
{

    class Program
    {
        static void Main(string[] args)
        {
            //UsingValueParameter();
            //UsingRefParameter();
            //UsingOutParameter();
            //UsingParamsKeyword();
            //UsingNamedArguments();
            //UsingAStruct();
            //displayHexconvertion(56734);
            //EmployeeTester.Test();
            PolygonTester.Test();

        }

        static void UsingValueParameter()
        {
            Console.WriteLine("USING VALUE PARAMETERS");
            int monthlyWage = 75_000;
            int months = 12;
            int yearlyWageForEmployee_1 = math.CalculateYearlyWage(monthlyWage, months, 4);
            int yearlyWageForEmployee_2 = math.CalculateYearlyWage(monthlyWage, months, 5);

            Console.WriteLine($"Yearly wage for (Jayharron): {yearlyWageForEmployee_1}");
            Console.WriteLine($"Yearly wage for (Pia): {yearlyWageForEmployee_2}");
        }

        static void UsingRefParameter()
        {
            Console.WriteLine("USING REF PARAMETERS");
            int monthlyWage = 75_000;
            int months = 12;
            int bonus = 3;
            int yearlyWageForEmployee_1 = math.CalculateYearlyWage(monthlyWage, months, ref bonus);
            int yearlyWageForEmployee_2 = math.CalculateYearlyWage(monthlyWage, months, ref bonus);

            Console.WriteLine($"Yearly wage for (Jayharron): {yearlyWageForEmployee_1}");
            Console.WriteLine($"Yearly wage for (Pia): {yearlyWageForEmployee_2}");
        }

        static void UsingOutParameter()
        {
            Console.WriteLine("USING OUT PARAMETERS");
            int monthlyWage = 75_000;
            int months = 12;
            int bonus;

            math.GenerateBonus(out bonus);

            int yearlyWageForEmployee_1 = math.CalculateYearlyWage(monthlyWage, months, ref bonus);
            int yearlyWageForEmployee_2 = math.CalculateYearlyWage(monthlyWage, months, ref bonus);

            Console.WriteLine($"Yearly wage for (Jayharron): {yearlyWageForEmployee_1}");
            Console.WriteLine($"Yearly wage for (Pia): {yearlyWageForEmployee_2}");
        }

        static void UsingParamsKeyword()
        {
            Console.WriteLine("USING PARAMS KEYWORD");
            int wage1 = 1000;
            int wage2 = 1234;
            int wage3 = 1500;
            int wage4 = 2500;

            int average_wage = math.CalculateAverageWage(wage1, wage2, wage3, wage4);
            Console.WriteLine($"The average wage is P{average_wage}");
        }

        static void UsingNamedArguments()
        {
            Console.WriteLine("USING NAMED ARGUMENTS");
            int wage = 1000;

            int yearlyWage = math.CalculateYearlyWage(numberOfMonthsWorked: 12, monthlyWage: wage);
            Console.WriteLine($"The yearly wage of Rey is P{yearlyWage}");
        }

        static void UsingAStruct()
        {
            Console.WriteLine("USING A STRUCTURE");
            EmployeeStruct employee;
            employee.name = "Jayharron";
            employee.age = 22;
            employee.occupation = Occupation.Employee;
            employee.Work();
        }

        static int displayHexconvertion(int n)
        {
            if (n > 0)
            {
                int rem = n % 16;
                switch (rem)
                {
                    case 10:
                        Console.Write("A");
                        break;
                    case 11:
                        Console.Write("B");
                        break;
                    case 12:
                        Console.Write("C");
                        break;
                    case 13:
                        Console.Write("D");
                        break;
                    case 14:
                        Console.Write("E");
                        break;
                    case 15:
                        Console.Write("F");
                        break;
                    default:
                        Console.Write(rem);
                        break;
                }

                return displayHexconvertion(n / 16);
            }
            return -1;
        }

        static void e()
        {
            int fn = 4;
            int sson = 100;

            double res = 20 / 10 * fn - 5 + 20 * 5 / sson;

            Console.WriteLine(res);
        }

        static void z()
        {
            int fn = 0;
            int sn = 0;
            int tn = 100;
            double sson = tn / fn;

            while (sn < tn)
            {
                if (sn == 10)
                    break;
                Console.WriteLine(sn);
                sn++;
            }
        }
    }

    enum Occupation
    {
        Student,
        Employee,
        House_Wife
    }

    class Person
    {
        public int age;
        public string name;
        public Occupation occupation;

        public Person(string name, int age, Occupation occupation)
        {
            this.age = age;
            this.name = name;
            this.occupation = occupation;
        }

        public override string ToString()
        {
            return $"{name} is {age} years old and is a {occupation}";
        }
    }

    struct EmployeeStruct
    {
        public string name;
        public int age;
        public Occupation occupation;

        public void Work()
        {
            Console.WriteLine($"{name} is working");
        }
    }


}
