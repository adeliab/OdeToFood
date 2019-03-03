﻿using OdeToFood.Core.Interfaces;
using OdeToFood.Core.Model.Entities;
using OdeToFood.Core.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OdeToFood.Data.Repositories
{
	public class InMemoryRestaurantRepository : IRestaurantRepository
	{
		List<Restaurant> _restaurants;

		public InMemoryRestaurantRepository()
		{
			_restaurants = new List<Restaurant>
			{
				new Restaurant { Id = 1, Name = "Hakata Senpachi", Location = "Amsterdam", Cuisine = Cuisine.Japanese },
				new Restaurant { Id = 2, Name = "Giuliano's", Location = "Den Haag", Cuisine = Cuisine.Italian },
				new Restaurant { Id = 3, Name = "Seleraku", Location = "Den Haag", Cuisine = Cuisine.Indonesian },
				new Restaurant { Id = 4, Name = "Vamos a Ver", Location = "Amsterdam", Cuisine = Cuisine.Spanish },
			};
		}

		public IEnumerable<Restaurant> GetAll()
		{
			return _restaurants.OrderBy(r => r.Name);
		}
	}
}