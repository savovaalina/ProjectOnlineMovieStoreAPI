namespace OnlineMovieStore.Entities
{
	using System.ComponentModel.DataAnnotations;
	public class Subscription
	{
		[Key]

		public int Id { get; set; }

		public double Price { get; set; }

		public int SoldSubscriptions { get; set; }

		public int SubscriptionId { get; set; }
	}
}
