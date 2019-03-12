using OdeToCode.SharedKernel;
using OdeToFood.Core.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Core.Model.Entities
{
	public class Restaurant : Entity<int>
	{
		[Required, StringLength(50)]
		public string Name { get; set; }

		[Required, StringLength(255)]
		public string Location { get; set; }

		[Required]
		public Cuisine Cuisine { get; set; }
	}
}
