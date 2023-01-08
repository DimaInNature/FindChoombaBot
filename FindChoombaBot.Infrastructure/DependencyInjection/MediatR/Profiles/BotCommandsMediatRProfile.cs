namespace FindChoombaBot.Infrastructure.DependencyInjection.MediatR.Profiles;

public static class BotCommandsMediatRProfile
{
	public static void AddBotCommandsMediatRProfile(this IServiceCollection services)
	{
		services.AddTransient<IRequest<Message?>, UnknownCommand>();
		services.AddTransient<IRequestHandler<UnknownCommand, Message?>, UnknownCommandHandler>();

		services.AddTransient<IRequest<Message?>, TestCommand>();
		services.AddTransient<IRequestHandler<TestCommand, Message?>, TestCommandHandler>();
	}
}