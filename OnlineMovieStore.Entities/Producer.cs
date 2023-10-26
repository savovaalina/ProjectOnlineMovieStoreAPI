namespace OnlineMovieStore.Entities
{
	using System.ComponentModel.DataAnnotations;
	public class Producer
	{
		[Key]
		public int Id { get; set; }

		[StringLength(250)]
		public string Name { get; set; } = null!;
	}
}
