namespace E_CommerceWebApplication.Services;
public interface IServicesType<T>
{
    Task<List<T>> GetAll();
    Task<List<T>> Search(string key);
    Task<T> Create(T entity);
    T Update(T entity);
    T Delete(T entity);
    Task<T> Get(int id);

}
