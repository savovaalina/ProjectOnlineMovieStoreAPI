using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProjectOnlineMovieStoreAPI.Models;
using System.Security.Cryptography.X509Certificates;

namespace ProjectOnlineMovieStoreAPI.Controllers
{

	public class HomeController : BaseAPIController
	{
		[HttpGet("Hollywood")]
		public async Task<ActionResult<IEnumerable<HollywoodsData>>> GetHollywoods()
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

		public async Task<List<Hollywood>> CallExternalApiHollywoods()
		{
			List<Hollywood> hollywoodsData = new List<Hollywood>();

			// TODO: logic for getting external data here
			using (var httpClient = new HttpClient())
			{
				using (var response = await httpClient.GetAsync("https://api.themoviedb.org/3/movie/550?api_key=1e2f1f0c67745c9a8e6cb8e7f4727fe7"))
				{
				 string apiResponse = await response.Content.ReadAsStringAsync();
					
					if (!string.IsNullOrEmpty(apiResponse)) 
					{
						hollywoodsData = JsonConvert.DeserializeObject<List<Hollywood>>(apiResponse);
					}
				}
			}
			return hollywoodsData;
		}

		#endregion
	}
}
