using Microsoft.Extensions.DependencyInjection;
using OdeToFood.Core.Interfaces;
using OdeToFood.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Web.CompositionRoot
{
	public static class Startup
	{
		public static void ConfigureServices(IServiceCollection services)
		{
			services.AddSingleton<IRestaurantRepository, InMemoryRestaurantRepository>();
		}
	}
}
