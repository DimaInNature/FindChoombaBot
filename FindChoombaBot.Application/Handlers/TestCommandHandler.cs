namespace FindChoombaBot.Application.Handlers;

public class TestCommandHandler : IRequestHandler<TestCommand, Message?>
{
	private readonly ITelegramBotClient _telegramBotClient;

	public TestCommandHandler(ITelegramBotClient telegramBotClient) =>
		_telegramBotClient = telegramBotClient;

	public async Task<Message?> Handle(TestCommand request, CancellationToken cancellationToken) =>
		await _telegramBotClient.SendTextMessageAsync(
			chatId: request.ChatId, 
			text: "Выполнена команда test",
			cancellationToken: cancellationToken);
}