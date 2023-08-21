using Newtonsoft.Json;

namespace OnlineMovieStore.Entities.Config
{
	public class AdminCredentials
	{
		[JsonProperty("username")]
		public string Username { get; set; } = null!;

		[JsonProperty("password")]
		public string Password { get; set; } = null!;
	}
}