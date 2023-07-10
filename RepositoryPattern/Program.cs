using RepositoryPattern.DataClass;
using RepositoryPattern.Repositories;
using RepositoryPattern.Repositories.AnimalRepo;
using RepositoryPattern.Repositories.PersonRepo;

namespace RepositoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRepository<Person> personRepository = new PersonRepository();

            personRepository.Add(new Person { Id = 1, Name = "Jayharron", Age = 22 });
            personRepository.Add(new Person { Id = 2, Name = "Pia", Age = 21 });


            IRepository<Animal> animalRepository = new AnimalRepository();

            animalRepository.Add(new Animal { Id = 1, Name = "Taro", AnimalType = "Shitzu" });
            animalRepository.Add(new Animal { Id = 2, Name = "Ham", AnimalType = "Hamster" });


            personRepository.DisplayData();
            animalRepository.DisplayData();
            
        }
    }
}