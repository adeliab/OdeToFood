﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OdeToFood.Core.Interfaces;
using OdeToFood.Core.Model.Entities;
using OdeToFood.Core.Model.Enums;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Web.Pages.Restaurants
{
	public class EditModel : PageModel
    {
		private readonly IRestaurantRepository restaurantRepository;
		private readonly IHtmlHelper htmlHelper;

		[BindProperty]
		public Restaurant Restaurant { get; set; }
		public IEnumerable<SelectListItem> Cuisines { get; set; }

		public EditModel(IRestaurantRepository restaurantRepository, IHtmlHelper htmlHelper)
		{
			this.restaurantRepository = restaurantRepository;
			this.htmlHelper = htmlHelper;
		}
		
        public IActionResult OnGet(int? restaurantId)
        {
			GetSelectableCuisines();

			if (restaurantId.HasValue)
			{
				Restaurant = restaurantRepository.GetById(restaurantId.Value);
				if (Restaurant == null) return RedirectToPage("./NotFound");
			}
			else
			{
				Restaurant = new Restaurant();
			}
						
			return Page();
        }

		private void GetSelectableCuisines()
		{
			Cuisines = htmlHelper.GetEnumSelectList<Cuisine>();
		}

		public IActionResult OnPost()
		{
			if (!ModelState.IsValid)
			{
				Cuisines = htmlHelper.GetEnumSelectList<Cuisine>();
				return Page();
			}

			if (Restaurant.Id > 0)
			{
				Restaurant = restaurantRepository.Update(Restaurant);
			}
			else
			{
				Restaurant = restaurantRepository.Create(Restaurant);
			}

			restaurantRepository.Commit();
			return RedirectToPage("./Detail", new { restaurantId = Restaurant.Id });
		}
    }
}