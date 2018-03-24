using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcLifeCycle
{
    interface IProductRepository
    {
        List<ProductVM> GetAll();
        ProductVM GetProduct(int Id);
        void Create(ProductVM product);
        void Update(ProductVM product);
        void Delete(int Id);

    }
}
