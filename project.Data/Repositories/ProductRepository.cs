using project.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Data.Repositories
{
    public class ProductRepository:IProductRepository
    {
        private DataContext _context;
        public ProductRepository(DataContext context)
        {
            _context = context;
        }
        public List<Product> Get()
        {
            return _context.Products;
        }

        public Product Add(Product product)
        {
            _context.Products.Add(product);
            return product;
        }
    }
}
