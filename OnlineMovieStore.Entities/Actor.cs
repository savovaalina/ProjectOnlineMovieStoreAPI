using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieStore.Entities
{
	public class Actor
	{
		[Key]
		public int Id { get; set; }

		[StringLength(100)]
		public string Name { get; set; } = null!;

		[StringLength(1000)]
		public string? ShortDescription { get; set; }

		public bool IsPopular { get; set; }

		public virtual ICollection<Movie>? Movies{ get; set; }
	}
}
