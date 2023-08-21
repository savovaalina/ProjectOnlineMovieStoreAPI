using Newtonsoft.Json;

namespace OnlineMovieStore.Entities.Config
{
	public class UserSettings
	{
		[JsonProperty("adminCredentials")]
		public AdminCredentials AdminCredentials { get; set; } = null!;
	}
}
