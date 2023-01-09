namespace FindChoombaBot.Persistence.DependencyInjection;

public static class DatabaseConfiguration
{
	public static void AddDatabaseConfiguration(
		this IServiceCollection services, IConfiguration configuration)
	{
		services.AddScoped<DbContext, ChoombaContext>();

		services.AddDbContext<ChoombaContext>(options => 
			options.UseSqlite(connectionString: configuration.GetConnectionString(name: "Sqlite")));
	}
}