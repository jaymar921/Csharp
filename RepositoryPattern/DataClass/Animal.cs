namespace RepositoryPattern.DataClass
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string AnimalType { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"{Name} - {AnimalType}";
        }
    }
}
