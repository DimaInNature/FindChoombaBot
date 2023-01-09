namespace FindChoombaBot.Infrastructure.DependencyInjection;

public static class DependencyInjectionExtensions
{
	public static void AddServices(this IServiceCollection services)
	{
		services.AddTransient<ICommandProvider, CommandProviderService>();

		services.AddTransient<IBotRunner, BotRunnerService>();
	}

	public static void AddTelegramClient(this IServiceCollection services, IConfiguration configuration)
	{
		services.AddTransient<ITelegramBotClient>(implementationFactory: 
			factory => new TelegramBotClient(token: configuration[key: "Bot:SecureToken"]!));
	}
}