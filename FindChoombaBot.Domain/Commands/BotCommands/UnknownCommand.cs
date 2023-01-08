namespace FindChoombaBot.Domain.Commands.BotCommands;

public sealed record UnknownCommand : IRequest<Message?>
{
    public long ChatId { get; }

    public UnknownCommand(long chatId) => ChatId = chatId;

	public UnknownCommand() { }
}