using Microsoft.AspNetCore.Identity;

namespace E_CommerceWebApplication.Models;

public class ShoppingCart
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public IdentityUser User { get; set; }
    public List<CartItem> Items { get; set; } = new(); 
}
