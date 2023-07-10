using RepositoryPattern.DataClass;

namespace RepositoryPattern.Repositories.AnimalRepo
{
    public class AnimalRepository : IAnimalRepository
    {
        private LinkedList<Animal> Animals;
        public AnimalRepository() 
        {
            Animals = new LinkedList<Animal>();
        }
        public void Add(Animal entity)
        {
            Animals.AddLast(entity);
        }

        public void AnimalDance()
        {
            Console.WriteLine("[Dancing Animals]");
            Animals.ToList().ForEach(
                a => Console.WriteLine($"{a.Name} is dancing")
            );
            Console.WriteLine("...[End of Dancing]...");
        }

        public void Delete(int id)
        {
            var animal = Get(id);

            if(animal != null)
            {
                Animals.Remove(animal);
            }
        }

        public void DisplayData()
        {
            Console.WriteLine("[Animal Repository]");
            Animals.ToList().ForEach(
                a => Console.WriteLine($"ID: {a.Id} | Type: {a.AnimalType} | Name: {a.Name}")
            );
            Console.WriteLine("...[End of Repository]...");
        }

        public Animal Get(int id)
        {
            return Animals.First(a => a.Id == id);
        }

        public void Save()
        {
            /*
             * Nothing to do since this is just for example
             * 
             * Just assume we are saving the objects into the database
             */
        }

        public void Update(Animal entity)
        {
            var animal = Get(entity.Id);

            if(animal != null)
            {
                animal.AnimalType = entity.AnimalType;
                animal.Name = entity.Name;
                Save();
            }
        }
    }
}
