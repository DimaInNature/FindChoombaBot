namespace FindChoombaBot.Application.Services;

public sealed class BotRunnerService : IBotRunner
{
	private readonly ITelegramBotClient _botClient;

	private readonly ICommandProvider _commandProvider;

	public BotRunnerService(
		ITelegramBotClient botClient,
		ICommandProvider commandProvider) =>
		(_botClient, _commandProvider) = (botClient, commandProvider);

	public void Run() =>
		_botClient.StartReceiving(
			updateHandler: HandleUpdateAsync,
			pollingErrorHandler: HandlePollingErrorAsync,
			receiverOptions: new()
			{
				AllowedUpdates = Array.Empty<UpdateType>()
			});

	private async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
	{
		if (update.Message is not { } message)
			return;

		if (message.Text is not { } messageText)
			return;

		var chatId = message.Chat.Id;

		await _commandProvider.ProvideAsync(messageText, chatId)
			.ConfigureAwait(continueOnCapturedContext: false);
	}

	private Task HandlePollingErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
	{
		var ErrorMessage = exception switch
		{
			ApiRequestException apiRequestException
				=> $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
			_ => exception.ToString()
		};

		Console.WriteLine(ErrorMessage);

		return Task.CompletedTask;
	}
}