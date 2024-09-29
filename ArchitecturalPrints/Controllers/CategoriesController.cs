using ArchitecturalPrints.Data;
using ArchitecturalPrints.Models;
using Microsoft.AspNetCore.Mvc;

namespace ArchitecturalPrints.Controllers
{
	public class CategoriesController : Controller
	{

		public CategoriesController(ApplicationDBContext database)
		{
			m_database = database;
		}

		public IActionResult Index()
		{
			List<Category> categories = m_database.Categories.ToList();
			return View(categories);
		}
		
		private ApplicationDBContext m_database;
	}
}
