using System.Collections.Generic;
using MVCIntro.Models;

namespace MVCIntro
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);

        public void UpdateProduct(Product product);
    }


}
