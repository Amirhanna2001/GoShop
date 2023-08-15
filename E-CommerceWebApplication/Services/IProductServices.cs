namespace E_CommerceWebApplication.Services;

public interface IProductServices: IServices<Product>
{
    Task<List<Product>> Search(string key);
    Task<List<Product>> SameCategory(int id);



}
