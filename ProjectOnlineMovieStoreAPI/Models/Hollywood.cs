namespace ProjectOnlineMovieStoreAPI.Models
{
	using Newtonsoft.Json;

	public class Hollywood
	{
		[JsonProperty("page")]
		public int page { get; set; }

		[JsonProperty("results")]
		public List<Result> results { get; set; }

		[JsonProperty("total_pages")]
		public int total_pages { get; set; }

        [JsonProperty("total_results")]
        public int total_results { get; set; }



		public class Result
		{
			public bool adult { get; set; }
			public string backdrop_path { get; set; }
			public List<int> genre_ids { get; set; }
			public int id { get; set; }
			public string original_language { get; set; }
			public string original_title { get; set; }
			public string overview { get; set; }
			public double popularity { get; set; }
			public string poster_path { get; set; }
			public string release_date { get; set; }
			public string title { get; set; }
			public bool video { get; set; }
			public double vote_average { get; set; }
			public int vote_count { get; set; }
		}

	}
}
