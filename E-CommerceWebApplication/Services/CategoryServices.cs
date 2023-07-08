using E_CommerceWebApplication.Data;
using E_CommerceWebApplication.Models;
using Microsoft.EntityFrameworkCore;
namespace E_CommerceWebApplication.Services;
public class CategoryServices : ICategoryServices
{
    private readonly ApplicationDbContext _context;

    public CategoryServices(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<Category> Create(Category category)
    {
        await _context.Categories.AddAsync(category);
        _context.SaveChanges();

        return category;
    }

    public Category Delete(Category category)
    {
            _context.Categories.Remove(category);
        File.Delete(category.ImageURL);
        _context.SaveChanges();

        return category;
    }

    public async Task< Category> Get(int id)
    {
        return await _context.Categories.FindAsync(id);
    }

    public async Task<List<Category>> GetAll()
    {
        return await _context.Categories.ToListAsync();
    }

    public async Task<List<Product>> GetProducts(int id)
         => (await _context.Products.Where(p => p.CategoryID == id).Include(p=>p.Category).ToListAsync());


    public Category Update(Category category)
    {
        _context.Categories.Update(category);
        _context.SaveChanges();
        return category;
    }
}

