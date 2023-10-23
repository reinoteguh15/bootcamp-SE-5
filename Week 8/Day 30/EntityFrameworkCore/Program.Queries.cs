using EFDatabase;
using Microsoft.EntityFrameworkCore;

namespace ProgramEFCore;

partial class Program
{
	static void QueryingCategories()
	{
		using (Northwind db = new())
		{
			SectionTitle("Querying Categories and Products");
			
			IQueryable<Category>? categories = db.Categories?.Include(c => c.Products);
			
			if ((categories == null) || (!categories.Any()))
			{
				Fail("No Categories Found");
				return;
			}
			Info($"ToQueryString: \n{categories.ToQueryString()}");
			
			foreach (Category? c in categories)
			{
				Printer($"Category: {c.CategoryName} has {c.Products.Count} products.");
			}
		}
	}
}
