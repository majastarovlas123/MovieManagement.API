namespace MovieManagement.Infrastructure.DbModels
{
    public class RoleDbModel : BaseEntity<Guid>
    {
        public Guid ActorId { get; set; }
        public Guid MovieId { get; set; }
        public ActorDbModel Actors { get; set; } = null!;
        public MovieDbModel Movies { get; set; } = null!;
    }
}
