﻿namespace E_CommerceWebApplication.Models;

public class InvoiceItem
{
    public int Id { get; set; }
    public int ProductId { get; set; } 
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal TotalPrice { get; set; }
    public Invoice Invoice { get; set; } 
    public Product Product { get; set; }
}
