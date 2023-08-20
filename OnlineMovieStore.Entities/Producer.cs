using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieStore.Entities
{
	public class Producer
	{
		[Key]
		public int Id { get; set; }

		[StringLength(250)]
		public string Name { get; set; } = null!;
	}
}
