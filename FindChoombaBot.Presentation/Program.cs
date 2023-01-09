var builder = WebApplication.CreateBuilder(args);

RegisterServices(services: builder.Services);

var app = builder.Build();

Configure(app);

var botRunner = app.Services.GetService<IBotRunner>();

botRunner?.Run();

app.Run();

void RegisterServices(IServiceCollection services)
{
	services.AddTelegramClient(configuration: builder.Configuration);

	services.AddMediatRConfiguration();

	services.AddServices();

	services.AddDatabaseConfiguration(configuration: builder.Configuration);

	services.AddLogging();

	services.AddControllers();
}

void Configure(WebApplication app)
{
	app.UseHttpsRedirection();

	app.MapControllers();
}