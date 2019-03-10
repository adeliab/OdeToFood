using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Core.Interfaces;
using OdeToFood.Core.Model.Entities;

namespace OdeToFood.Web.Pages.Restaurants
{
	public class EditModel : PageModel
    {
		private readonly IRestaurantRepository restaurantRepository;

		public Restaurant Restaurant { get; set; }

		public EditModel(IRestaurantRepository restaurantRepository)
		{
			this.restaurantRepository = restaurantRepository;
		}
		
        public IActionResult OnGet(int restaurantId)
        {
			Restaurant = restaurantRepository.GetById(restaurantId);
			if (Restaurant == null) return RedirectToPage("./NotFound");
			return Page();
        }
    }
}