namespace CleanArchitecture.Domain.Products.IProductRepository
{
    public interface IProductRepository
    {
        List<Product> GetList();
        Product GetById(Guid Id);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        void SaveChanges();

    }
}
