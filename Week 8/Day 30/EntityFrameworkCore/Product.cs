using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDatabase;

public class Product
{
	public int ProductId {get; set;}
	
	[Required]
	[StringLength(40)]
	public string ProductName {get; set;} =null!;
	
	[Column("UnitPrice", TypeName = "money")]
	public decimal? Price {get; set;}
	
	[Column("UnitsInStock")]
	public short? Stock {get; set;}
	
	[Required]
	public bool Discontinued {get; set;}
		
	public int CategoryId {get; set;}
	public virtual Category Category {get; set;} = null!;
}
