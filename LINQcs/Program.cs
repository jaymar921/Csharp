using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQcs
{
    public class Program
    {
        private static bool useQuerySyntax = true;
        private static List<Person> personRepository = new PersonRepository().GetPeople;
        static void Main(string[] args)
        {
            //GetAll();
            //GetSingleColumn();
            //GetSpecificColumns();
            //AnonymousClass();
            //OrderBy();
            //OrderByDescending();
            //OrderByTwoField();
            //WhereExpression();
            //WhereExpressionWithTwoField();
            //CustomExtension();
            //First();
            //FirstOrDefault();
            //Last();
            //LastOrDefault();
            Single();
            SingleOrDefault();
        }


        static void GetAll()
        {
            List<Person> list = new List<Person>();
            if (useQuerySyntax)
            {
                // use the query syntax
                list = (from p in personRepository select p).ToList();
            }
            else
            {
                // use the method syntax
                list = personRepository.Select(person => person).ToList();
            }
            DisplayOutput(list);
        }
        static void GetSingleColumn()
        {
            List<string> list = new List<string>();
            if (useQuerySyntax)
            {
                list.AddRange(from person in personRepository select person.City);
            }
            else
            {
                // use the method syntax
                //list.AddRange(list.Select(person => person.Name));
            }
            foreach (string str in list) Console.Write("{0}, ", str);
        }

        static void GetSpecificColumns()
        {
            List<Person> list = new List<Person>();
            if (useQuerySyntax)
            {
                // use the query syntax
                list = (from person in personRepository select new Person { City = person.City }).ToList();
            }
            else
            {
                // use the method syntax
                list = personRepository.Select(person => new Person { Name = person.Name }).ToList();
            }
            DisplayOutput(list);
        }

        static void AnonymousClass()
        {
            StringBuilder sb = new StringBuilder(2048);
            if (useQuerySyntax)
            {
                // use the query syntax
                var persons = (from p in personRepository select new { n = p.Name });

                foreach(var person in persons)
                {
                    sb.AppendLine($"Person name: {person.n}");
                }
            }
            else
            {
                // use the method syntax
            }
            Console.WriteLine(sb);
        }

        static void OrderBy()
        {
            List<Person> list = new List<Person>();
            if (useQuerySyntax)
            {
                // use the query syntax
                list = (from person in personRepository orderby person.Age select person).ToList();
            }
            else
            {
                // use the method syntax
                list = personRepository.OrderBy(person => person.Age).ToList();
            }
            DisplayOutput(list);
        }

        static void OrderByDescending()
        {
            List<Person> list = new List<Person>();
            if (useQuerySyntax)
            {
                // use the query syntax
                list = (from person in personRepository orderby person.Age descending select person).ToList();
            }
            else
            {
                // use the method syntax
                list = personRepository.OrderByDescending(person => person.Age).ToList();
            }
            DisplayOutput(list);
        }

        static void OrderByTwoField()
        {
            List<Person> list = new List<Person>();
            if (useQuerySyntax)
            {
                // use the query syntax
                list = (from person in personRepository orderby person.Age ascending, person.Name descending select person).ToList();
            }
            else
            {
                // use the method syntax
                list = personRepository.OrderBy(person => person.Age).ThenByDescending(person => person.Name).ToList();
            }
            DisplayOutput(list);
        }

        static void WhereExpression()
        {
            string search = "Jay";
            List<Person> list = new List<Person>();
            if (useQuerySyntax)
            {
                // use the query syntax
                list = (from person in personRepository where person.Name.StartsWith(search) select person).ToList();
            }
            else
            {
                // use the method syntax
                list = personRepository.Where(person => person.Name.StartsWith(search)).ToList();
            }
            DisplayOutput(list);
        }

        static void WhereExpressionWithTwoField()
        {
            string search = "a";
            List<Person> list = new List<Person>();
            if (useQuerySyntax)
            {
                // use the query syntax
                list = (from person in personRepository where person.Name.Contains(search) && person.Age == 21 select person).ToList();
            }
            else
            {
                // use the method syntax
                list = personRepository.Where(person => person.Name.Contains(search) && person.Age == 21).ToList();
            }
            DisplayOutput(list);
        }

        static void CustomExtension()
        {
            List<Person> list = new List<Person>();

            list = personRepository.ByAge(22).ToList();

            DisplayOutput(list);
        }


        static void First()
        {
            string search = "Jay";
            Person value;
            List<Person> list = new List<Person>();
            try
            {
                if (useQuerySyntax)
                {
                    // use the query syntax
                    value = (from person in personRepository select person).First(person => person.Name.StartsWith(search));
                }
                else
                {
                    // use the method syntax
                    value = personRepository.First(person => person.Name.StartsWith(search));
                }
                Console.WriteLine(value.ToString());
            }
            catch
            {
                Console.WriteLine("Not found {0}", search);
            }
            
        }

        static void FirstOrDefault()
        {
            string search = "R";
            Person value;
            List<Person> list = new List<Person>();
            try
            {
                if (useQuerySyntax)
                {
                    // use the query syntax
                    value = (from person in personRepository select person).FirstOrDefault(person => person.Name.StartsWith(search));
                }
                else
                {
                    // use the method syntax
                    value = personRepository.FirstOrDefault(person => person.Name.StartsWith(search));
                }
                Console.WriteLine(value.ToString());
            }
            catch
            {
                Console.WriteLine("Not found {0}", search);
            }

        }


        static void Last()
        {
            string search = "a";
            Person value;
            List<Person> list = new List<Person>();
            try
            {
                if (useQuerySyntax)
                {
                    // use the query syntax
                    value = (from person in personRepository select person).Last(person => person.Name.Contains(search));
                }
                else
                {
                    // use the method syntax
                    value = personRepository.Last(person => person.Name.Contains(search));
                }
                Console.WriteLine(value.ToString());
            }
            catch
            {
                Console.WriteLine("Not found {0}", search);
            }

        }

        static void LastOrDefault()
        {
            string search = "a";
            Person value;
            List<Person> list = new List<Person>();
            try
            {
                if (useQuerySyntax)
                {
                    // use the query syntax
                    value = (from person in personRepository select person).LastOrDefault(person => person.Name.Contains(search));
                }
                else
                {
                    // use the method syntax
                    value = personRepository.LastOrDefault(person => person.Name.Contains(search));
                }
                Console.WriteLine(value.ToString());
            }
            catch
            {
                Console.WriteLine("Not found {0}", search);
            }

        }

        // only 1 should be in the collection, there should only be 1 item in the collection that contains 'Jay'
        static void Single()
        {
            string search = "Jay";
            Person value;
            List<Person> list = new List<Person>();
            try
            {
                if (useQuerySyntax)
                {
                    // use the query syntax
                    value = (from person in personRepository select person).Single(person => person.Name.Contains(search));
                }
                else
                {
                    // use the method syntax
                    value = personRepository.Single(person => person.Name.Contains(search));
                }
                Console.WriteLine(value.ToString());
            }
            catch
            {
                Console.WriteLine("Not found {0}", search);
            }

        }

        // only 1 should be in the collection, there should only be 1 item in the collection that contains 'Jay'
        static void SingleOrDefault()
        {
            string search = "Jay";
            Person value;
            List<Person> list = new List<Person>();
            try
            {
                if (useQuerySyntax)
                {
                    // use the query syntax
                    value = (from person in personRepository select person).SingleOrDefault(person => person.Name.Contains(search));
                }
                else
                {
                    // use the method syntax
                    value = personRepository.SingleOrDefault(person => person.Name.Contains(search));
                }
                Console.WriteLine(value.ToString());
            }
            catch
            {
                Console.WriteLine("Not found {0}", search);
            }

        }

        static void TODO()
        {
            List<Person> list = new List<Person>();
            if (useQuerySyntax)
            {
                // use the query syntax
            }
            else
            {
                // use the method syntax
            }
            DisplayOutput(list);
        }

        // displaying the stuff
        private static void DisplayOutput(List<Person> list)
        {
            Console.WriteLine("\nDisplaying output - using method {0}", useQuerySyntax);
            foreach (Person person in list)
                Console.WriteLine(person);
            Console.WriteLine("");
        }
    }
}
