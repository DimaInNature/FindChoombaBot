namespace FindChoombaBot.Presentation.Configurations;

public static class LoggingConfiguration
{
	public static void AddLogging(
		this IServiceCollection services,
		ConfigureHostBuilder hostBuilder)
	{
		hostBuilder.UseSerilog();

		Log.Logger = new LoggerConfiguration()
			.MinimumLevel.Override(source: "Microsoft", minimumLevel: LogEventLevel.Information)
			.WriteTo.Console()
			.CreateLogger();

		services.AddHttpContextAccessor();
	}
}