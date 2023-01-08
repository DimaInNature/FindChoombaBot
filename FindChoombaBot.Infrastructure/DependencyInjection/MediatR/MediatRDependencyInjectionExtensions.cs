namespace FindChoombaBot.Infrastructure.DependencyInjection.MediatR;

public static class MediatRDependencyInjectionExtensions
{
	public static void AddMediatRConfiguration(this IServiceCollection services)
	{
		ArgumentNullException.ThrowIfNull(argument: services, paramName: nameof(services));

		services.AddMediatR(assemblies: Assembly.GetExecutingAssembly());

		services.AddBotCommandsMediatRProfile();
	}
}