using OdeToFood.Core.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Core.Interfaces
{
	public interface IRestaurantRepository
	{
		IEnumerable<Restaurant> GetRestaurantsByName(string name);
	}
}
