using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeToFood.Core.Interfaces;
using OdeToFood.Core.Model.Entities;
using System.Collections.Generic;

namespace OdeToFood.Web.Pages.Restaurants
{
	public class ListModel : PageModel
    {
		private readonly IConfiguration configuration;
		private readonly IRestaurantRepository restaurantRepository;

		public string Message { get; set; }
		public IEnumerable<Restaurant> Restaurants { get; set; }

		[BindProperty(SupportsGet=true)]
		public string SearchTerm { get; set; }

		public ListModel(IConfiguration configuration, IRestaurantRepository restaurantRepository)
		{
			this.configuration = configuration;
			this.restaurantRepository = restaurantRepository;
		}

		public void OnGet()
        {
			Message = configuration["Message"];
			Restaurants = restaurantRepository.GetRestaurantsByName(SearchTerm);
        }
    }
}