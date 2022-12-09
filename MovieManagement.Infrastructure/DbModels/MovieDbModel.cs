namespace MovieManagement.Infrastructure.DbModels
{
    public class MovieDbModel : BaseEntity<Guid>
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<RoleDbModel> Roles { get; set; } = null!;
        public Guid MovieTypeId { get; set; }
        public MovieTypeDbModel MovieType { get; set; } = null!;
    }
}
