namespace MovieManagement.API.DbModels
{
    public class Role
    {
        public Guid Id { get; set; }
        public Guid ActorId { get; set; }
        public Guid MovieId { get; set; }
        public Actor Actors { get; set; } = null!;
        public Movie Movies { get; set; } = null!;
    }
}
