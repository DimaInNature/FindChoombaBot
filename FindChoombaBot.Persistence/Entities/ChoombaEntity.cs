namespace FindChoombaBot.Persistence.Entities;

public class ChoombaEntity
{
	public long Id { get; set; }

	public long? ProfileId { get; set; }

	public ChoombaProfileEntity? Profile { get; set; }
}