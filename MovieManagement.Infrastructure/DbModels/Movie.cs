namespace MovieManagement.Infrastructure.DbModels
{
    public class Movie : BaseEntity<Guid>
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<Role> Roles { get; set; } = null!;

    }
}
