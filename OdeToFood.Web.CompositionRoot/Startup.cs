using Microsoft.Extensions.DependencyInjection;
using OdeToFood.Core.Interfaces;
using OdeToFood.Data.Repositories;

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
