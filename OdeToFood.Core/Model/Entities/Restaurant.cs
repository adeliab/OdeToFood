using OdeToCode.SharedKernel;
using OdeToFood.Core.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Core.Model.Entities
{
	public class Restaurant : Entity<int>
	{
		public string Name { get; set; }
		public string Location { get; set; }
		public Cuisine Cuisine { get; set; }
	}
}
