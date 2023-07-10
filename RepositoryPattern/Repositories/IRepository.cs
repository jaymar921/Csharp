namespace RepositoryPattern.Repositories
{
    public interface IRepository<T> where T : class
    {
        public T Get(int id);
        public void Add(T entity);
        public void Update(T entity);
        public void Delete(int id);
        public void Save();
        public void DisplayData(); // just for displaying stuff
    }
}
