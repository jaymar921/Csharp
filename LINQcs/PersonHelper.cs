using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQcs
{
    public static class PersonHelper
    {

        public static IEnumerable<Person> ByAge(this IEnumerable<Person> query, int age)
        {
            return query.Where(person => person.Age == age);
        }
    }
}
