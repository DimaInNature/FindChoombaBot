namespace FindChoombaBot.Domain.Contracts.Services;

public interface ICommandProvider
{
	public Task<Message?> ProvideAsync(string message, long chatId);
}