using OdeToFood.Core.Interfaces;
using OdeToFood.Core.Model.Entities;
using OdeToFood.Core.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Repositories
{
	public class InMemoryRestaurantRepository : IRestaurantRepository
	{
		List<Restaurant> restaurants;

		public InMemoryRestaurantRepository()
		{
			restaurants = new List<Restaurant>
			{
				new Restaurant { Id = 1, Name = "Hakata Senpachi", Location = "Amsterdam", Cuisine = Cuisine.Japanese },
				new Restaurant { Id = 2, Name = "Giuliano's", Location = "Den Haag", Cuisine = Cuisine.Italian },
				new Restaurant { Id = 3, Name = "Seleraku", Location = "Den Haag", Cuisine = Cuisine.Indonesian },
				new Restaurant { Id = 4, Name = "Vamos a Ver", Location = "Amsterdam", Cuisine = Cuisine.Spanish },
			};
		}

		public Restaurant GetById(int id)
		{
			return restaurants.SingleOrDefault(r => r.Id == id);
		}

		public IEnumerable<Restaurant> GetRestaurantsByName(string name)
		{
			return restaurants.Where(r => string.IsNullOrEmpty(name) || r.Name.Contains(name, StringComparison.InvariantCultureIgnoreCase)).OrderBy(r => r.Name);
		}
	}
}
