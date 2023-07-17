using Microsoft.AspNetCore.Identity;

namespace E_CommerceWebApplication.Models;

public class Invoice
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    public double TotalAmount { get; set; }
    public List<InvoiceItem> Items { get; set; } = new();
    public IdentityUser User { get; set; }

}
