namespace E_CommerceWebApplication.Models;

public class CartItem
{
    public int Id { get; set; }
    public int Quantity { get; set; }
    public int ProductId { get; set; }
    public double Price { get; set; }
    public DateTime AddedOn { get; set; }= DateTime.Now;
    public Product Product { get; set; }
}
