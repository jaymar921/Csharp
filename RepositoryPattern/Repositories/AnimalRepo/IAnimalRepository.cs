using RepositoryPattern.DataClass;
namespace RepositoryPattern.Repositories.AnimalRepo
{
    public interface IAnimalRepository : IRepository<Animal>
    {
        public void AnimalDance();
    }
}
