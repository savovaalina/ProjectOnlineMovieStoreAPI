namespace ProjectOnlineMovieStoreAPI.Models
{
	using Newtonsoft.Json;

	public class Hollywood
	{
		[JsonProperty("Id")]
		public int Id { get; set; }

		[JsonProperty("Name")]
		public string Name { get; set; }
	}
}
