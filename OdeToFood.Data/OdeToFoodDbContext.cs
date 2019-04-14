using Microsoft.EntityFrameworkCore;
using OdeToFood.Core.Model.Entities;

namespace OdeToFood.Data
{
	public class OdeToFoodDbContext : DbContext
	{
		public DbSet<Restaurant> Restaurants { get; set; }
	}
}
