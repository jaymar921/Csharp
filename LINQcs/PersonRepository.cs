using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQcs
{
    public class PersonRepository
    {
        public List<Person> GetPeople { get; private set; }
        
        public PersonRepository()
        {
            GetPeople = new List<Person>();
            GetPeople.Add(new Person { Name = "Jayharron", Age = 22, City= "Talisay"});
            GetPeople.Add(new Person { Name = "Pia", Age = 21, City = "Talisay" });
            GetPeople.Add(new Person { Name = "Rey", Age = 22, City = "Pardo" });
            GetPeople.Add(new Person { Name = "Pabz", Age = 21, City = "Talisay" });
            GetPeople.Add(new Person { Name = "Arlo", Age = 21, City = "Talisay" });
            GetPeople.Add(new Person { Name = "Jester", Age = 21, City = "Talisay" });
            GetPeople.Add(new Person { Name = "Kent", Age = 21, City = "Talisay" });
            GetPeople.Add(new Person { Name = "Trisha", Age = 21, City = "Cebu" });
            GetPeople.Add(new Person { Name = "Harold", Age = 21, City = "Cebu" });
        }
    }
}
