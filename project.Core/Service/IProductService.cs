using project.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Core.Service
{
    internal interface IProductService
    {
        public List<Product> Get();
        public Product Add(Product product);
    }
}
