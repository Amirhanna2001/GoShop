using System.ComponentModel;
namespace MyPortfolio.ViewModels;
public class ProducttDetails
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string ImageURL { get; set; }
    public string Description { get; set; }
    public DateTime CreatedOn { get; set; } = DateTime.Now;
    [DisplayName("Category Name")]
    public string CategoryName { get;set; }
}
