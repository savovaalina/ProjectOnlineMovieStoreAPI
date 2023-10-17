namespace ProjectOnlineMovieStoreAPI.Controllers
{
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProjectOnlineMovieStoreAPI.Models;



	public class HomeController : BaseApiController
	{


		[HttpGet("Hollywood")]
		public async Task<ActionResult<Hollywood>> GetHollywoods()
		{
			try
			{
				var hollywoodsResult = await CallExternalApiHollywoods();
				
				return Ok(hollywoodsResult);
			}
			catch (Exception ex)
			{
				throw;
			}
		}


		#region Helper Methods

		
		[NonAction]
		public async Task<Hollywood> CallExternalApiHollywoods()
		{
			Hollywood hollywoodsData = new Hollywood();

			// TODO: logic for getting external data here
			using (var httpClient = new HttpClient())
			{
				using (var response = await httpClient.GetAsync("https://api.themoviedb.org/3/movie/popular?api_key=1e2f1f0c67745c9a8e6cb8e7f4727fe7"))
				{
					string apiResponse = await response.Content.ReadAsStringAsync();
					if (!string.IsNullOrEmpty(apiResponse))
					{
						hollywoodsData = JsonConvert.DeserializeObject<Hollywood>(apiResponse);
					}
				}
			}
			return hollywoodsData;
		}

		#endregion
	}
}
