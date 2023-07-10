using RepositoryPattern.DataClass;

namespace RepositoryPattern.Repositories.PersonRepo
{
    public class PersonRepository: IRepository<Person>
    {
        private LinkedList<Person> People;
        public PersonRepository() {
            People = new LinkedList<Person>();
        }
        public void Add(Person entity)
        {
            People.AddLast(entity);
        }

        public void Delete(int id)
        {
            var person = Get(id);

            if (person != null)
            {
                People.Remove(person);
            }
        }

        public void DisplayData()
        {
            Console.WriteLine("[Person Repository]");
            People.ToList().ForEach(
                p => Console.WriteLine($"ID: {p.Id} | Age: {p.Age} | Name: {p.Name}")
            );
            Console.WriteLine("...[End of Repository]...");
        }

        public Person Get(int id)
        {
            return People.First(p => p.Id == id);
        }

        public void Save()
        {
            /*
             * Nothing to do since this is just for example
             * 
             * Just assume we are saving the objects into the database
             */
        }

        public void Update(Person entity)
        {
            var person = Get(entity.Id);

            if (person != null)
            {
                person.Age = entity.Age;
                person.Name = entity.Name;
                Save();
            }
        }
    }
}
