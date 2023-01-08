namespace FindChoombaBot.Persistence.Entities;

public class ChoombaProfileEntity
{
	public long Id { get; set; }

	public string? Nickname { get; set; }

	public string? Description { get; set; }

	public byte Age { get; set; }
}