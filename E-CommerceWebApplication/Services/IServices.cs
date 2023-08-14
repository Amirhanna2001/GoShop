namespace E_CommerceWebApplication.Services;

public interface IServices<T>
{
    Task<List<T>> GetAll();
    //Task<List<T>> Search(string key);
    void Create(T entity);
    void Update(T entity);
    void Delete(int id);
    Task<T> Get(int id);
}
