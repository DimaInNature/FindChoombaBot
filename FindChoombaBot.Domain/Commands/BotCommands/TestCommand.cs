namespace FindChoombaBot.Domain.Commands.BotCommands;

public sealed record TestCommand : IRequest<Message?>
{
    public long ChatId { get; }

    public TestCommand(long chatId) => ChatId = chatId;

	public TestCommand() { }
}