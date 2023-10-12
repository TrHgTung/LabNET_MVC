namespace Tung.Models
{
    public interface IStoreRepository
    {
        //IQueryable<Product> GetAll();
        IQueryable<Product> Products { get; }
    }
}
