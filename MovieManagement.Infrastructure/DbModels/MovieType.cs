namespace MovieManagement.Infrastructure.DbModels
{
    public class MovieType : BaseEntity<Guid>
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<Movie> Movies { get; set; } = null!;
    }
}
