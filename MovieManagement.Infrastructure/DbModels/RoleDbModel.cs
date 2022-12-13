namespace MovieManagement.Infrastructure.DbModels
{
    public class RoleDbModel : BaseEntity<Guid>
    {
        public Guid ActorId { get; set; }
        public Guid MovieId { get; set; }
        public ActorDbModel Actor { get; set; } = null!;
        public MovieDbModel Movie { get; set; } = null!;
    }
}
