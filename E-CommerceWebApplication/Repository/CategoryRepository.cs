using E_CommerceWebApplication.Data;
using E_CommerceWebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace E_CommerceWebApplication.Repository;
public class CategoryRepository : Repository<Category>, ICategoryRepository
{
    private readonly ApplicationDbContext _context;

    public CategoryRepository(ApplicationDbContext context):base(context)
    {
        _context = context;
    }

    public async Task<List<Product>> GetProducts(int id)=>await _context.Products.Where(p=>p.CategoryID == id).ToListAsync();


}

