namespace BestBuyCRUDApp.Models.Data
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();

    }
}
