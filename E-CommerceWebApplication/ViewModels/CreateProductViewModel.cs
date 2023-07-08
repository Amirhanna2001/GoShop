using E_CommerceWebApplication.Models;

namespace E_CommerceWebApplication.ViewModels;
public class CreateProductViewModel
{
    public int ID { get; set; }
    public string Name { get; set; }
    public IFormFile? Image { get; set; }
    public string Description { get; set; }
    public string OutLink { get; set; }

    public DateTime CreatedOn { get; set; } = DateTime.Now;
    public int CategoryId { get; set; } 
    public List<Category>? Categories { get; set; }
}
