namespace MovieManagement.Infrastructure.DbModels
{
    public class ActorDbModel : BaseEntity<Guid>
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public ICollection<RoleDbModel> Roles { get; set; } = null!;
    }
}
