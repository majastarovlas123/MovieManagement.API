namespace MovieManagement.Infrastructure.DbModels
{
    public class MovieTypeDbModel : BaseEntity<Guid>
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<MovieDbModel> Movies { get; set; } = null!;
    }
}
