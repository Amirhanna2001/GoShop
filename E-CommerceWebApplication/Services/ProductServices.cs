using E_CommerceWebApplication.Data;
using Microsoft.EntityFrameworkCore;

namespace E_CommerceWebApplication.Services;
public class ProductServices : Services<Product>,IProductServices 
{
    private readonly ApplicationDbContext _context;

    public ProductServices(ApplicationDbContext context):base(context)
    {
        _context = context;
    }
    //public async Task<Product> Create(Product product)
    //{
    //    await _context.Products.AddAsync(product);
    //    _context.SaveChanges();

    //    return product;
    //}

    //public Product Delete(Product product)
    //{
    //    _context.Products.Remove(product);
    //    File.Delete(product.ImageURL);
    //    _context.SaveChanges();

    //    return product;
    //}

    //public async Task<Product> Get(int id)
    //    => await _context.Products.FindAsync(id);


    public async Task<List<Product>> GetAll()
        => await _context.Products.Include(p => p.Category).OrderBy(p => p.CategoryID).ToListAsync();


    //public Product Update(Product product)
    //{
    //    _context.Products.Update(product);
    //    _context.SaveChanges();
    //    return product;
    //}
    public async Task<List<Product>> SameCategory(int id)
        =>await _context.Products.Where(p=>p.CategoryID == id).ToListAsync();

    public async Task<List<Product>> Search(string key)
    {
        return await _context.Products
            .Where(p => EF.Functions.Like(p.Name, $"%{key}%") || EF.Functions.Like(p.Description, $"%{key}%"))
            .Include(p => p.Category)
            .ToListAsync();
    }

}
