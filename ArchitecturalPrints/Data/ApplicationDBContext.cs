using ArchitecturalPrints.Models;
using Microsoft.EntityFrameworkCore;

namespace ArchitecturalPrints.Data
{
	public class ApplicationDBContext : DbContext
	{
		public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) :
			base(options)
		{

		}

		public DbSet<Category> Categories { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Category>().HasData(
				new Category { Id = 1, Name = "Modernist", DisplayOrder = 1 },
				new Category { Id = 2, Name = "Conceptual", DisplayOrder = 2 },
				new Category { Id = 3, Name = "Other", DisplayOrder = 3 }
				);
		}
	}
}
