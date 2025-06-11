
using CleanArchitecture.Domain.Products;
using CleanArchitecture.Domain.Products.IProductRepository;

namespace CleanArchitecture.Infrastructure.Presistance.Memory.Products
{
   public class ProdutcRepository : IProductRepository
    {

        private Context _context;
        private List<Product> _product;

        public ProdutcRepository(Context context)
        {
            _context = context;
            _product = new List<Product>();
        }
        public List<Product> GetList()
        {
            return _context.Products;
        }
        public Product GetById(Guid Id)
        {
            return _context.Products.FirstOrDefault(f => f.Id == Id)!;
        }
        public void Add(Product product)
        {
            _context.Products.Add(product);
        }
        public void Update(Product product)
        {
            var oldProdouct = GetById(product.Id);
            _context.Products.Remove(oldProdouct);
            Add(product);
        }
        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
