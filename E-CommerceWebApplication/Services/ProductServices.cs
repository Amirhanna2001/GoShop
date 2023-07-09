﻿using E_CommerceWebApplication.Data;
using Microsoft.EntityFrameworkCore;

namespace E_CommerceWebApplication.Services;
public class ProductServices : IServicesType<Product>
{
    private readonly ApplicationDbContext _context;

    public ProductServices(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<Product> Create(Product product)
    {
        await _context.Products.AddAsync(product);
        _context.SaveChanges();

        return product;
    }

    public Product Delete(Product product)
    {
        _context.Products.Remove(product);
        File.Delete(product.ImageURL);
        _context.SaveChanges();

        return product;
    }

    public async Task<Product> Get(int id)
        => await _context.Products.FindAsync(id);
    

    public async Task<List<Product>> GetAll()
        => await _context.Products.Include(p=>p.Category).ToListAsync();
    

    public Product Update(Product product)
    {
        _context.Products.Update(product);
        _context.SaveChanges();
        return product;
    }
    public async Task<List<Product>> SameCategory(int id)
        =>await _context.Products.Where(p=>p.CategoryID == id).ToListAsync();
    
}