using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        public List<Product> GetAll();
        public List<Product> GetAllByCategory(int id);
        public List<Product> GetAllByPrice(decimal minPrice, decimal maxPrice);
    }
}
