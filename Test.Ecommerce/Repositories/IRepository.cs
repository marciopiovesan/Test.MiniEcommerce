namespace Test.Ecommerce.Repositories
{
    public interface IRepository<T>
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Post(T entity);
        void Delete(T entity);
        void Update(T entity);

    }
}
