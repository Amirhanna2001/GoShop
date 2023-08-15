using E_CommerceWebApplication.Models;
using E_CommerceWebApplication.Services;

public interface ICategoryServices:IServices<Category>
{
    //Task<List<Category>> GetAll();
    //Task<Category> Create(Category entity);
    //Category Update(Category entity);
    //Category Delete(Category entity);
    //Task<Category> Get(int id);
    Task<List<Product>> GetProducts(int id);

}
