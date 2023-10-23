using Microsoft.EntityFrameworkCore;

namespace EFDatabase;

public class Northwind : DbContext
{
	public DbSet<Product> Products {get; set;}
	public DbSet<Category> Categories {get; set;}
	
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		string path = Path.Combine(Environment.CurrentDirectory, "Northwind.db");
		string connectionPath = $"Data Source={path}";
		optionsBuilder.UseSqlite(connectionPath);
		
		// Alternative
		// optionsBuilder.UseSqlite(@"Filename=./Northwind.db");
	}
}
