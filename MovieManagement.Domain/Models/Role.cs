namespace MovieManagement.Domain.Models
{
    public class Role
    {
        public Guid Id { get; set; }
        public string ActorFirstName { get; set; } = string.Empty;
        public string ActorLastName { get; set; } = string.Empty;
        public string MovieName { get; set; } = string.Empty;
    }
}
