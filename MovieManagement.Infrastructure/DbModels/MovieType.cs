namespace MovieManagement.Infrastructure.DbModels
{
    public class MovieType
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<Movie> Movies { get; set; } = null!;
    }
}
