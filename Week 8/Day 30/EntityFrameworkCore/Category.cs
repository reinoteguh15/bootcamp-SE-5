using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDatabase;

public class Category
{
	public int CategoryId {get; set;}
	
	[Required]
	[StringLength(15)]
	public string CategoryName {get; set;} = null!;
	
	[Column(TypeName = "ntext")]
	public string? Description {get; set;}
	
	[Column(TypeName = "image")]
	public byte[]? Picture {get; set;}
	
	public virtual ICollection<Product> Products {get; set;}
	
	public Category()
	{
		Products = new HashSet<Product>();
	}
}
