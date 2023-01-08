namespace FindChoombaBot.Application.Handlers;

public class UnknownCommandHandler : IRequestHandler<UnknownCommand, Message?>
{
	private readonly ITelegramBotClient _telegramBotClient;

	public UnknownCommandHandler(ITelegramBotClient telegramBotClient) =>
		_telegramBotClient = telegramBotClient;

	public async Task<Message?> Handle(UnknownCommand request, CancellationToken cancellationToken) =>
		await _telegramBotClient.SendTextMessageAsync(
			chatId: request.ChatId,
			text: "Неизвестная команда",
			cancellationToken: cancellationToken);
}