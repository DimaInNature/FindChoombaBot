namespace FindChoombaBot.Persistence.Context.Choomba;

public class ChoombaContext : DbContext
{
	public DbSet<ChoombaEntity> Choombas => Set<ChoombaEntity>();

	public DbSet<ChoombaProfileEntity> ChoombasProfiles => Set<ChoombaProfileEntity>();

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
	}
}