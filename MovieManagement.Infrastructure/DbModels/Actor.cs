namespace MovieManagement.Infrastructure.DbModels
{
    public class Actor
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public ICollection<Role> Roles { get; set; } = null!;
    }
}
