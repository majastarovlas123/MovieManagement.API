namespace MovieManagement.Infrastructure.DbModels
{
    public class Role : BaseEntity<Guid>
    {
        public Guid ActorId { get; set; }
        public Guid MovieId { get; set; }
        public Actor Actors { get; set; } = null!;
        public Movie Movies { get; set; } = null!;
    }
}
