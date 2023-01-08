namespace FindChoombaBot.Application.Services;

public sealed class CommandProviderService : ICommandProvider
{
    private readonly IMediator _mediator;

    public CommandProviderService(IMediator mediator) =>
        _mediator = mediator;

    public async Task<Message?> ProvideAsync(string message, long chatId) =>
        message switch
        {
            "test" => await _mediator.Send(request: new TestCommand(chatId)),
            _ => await _mediator.Send(request: new UnknownCommand(chatId))
		};
}