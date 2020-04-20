using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int id);

        Product Add(Product product);
        Product Update(Product product);
        void Delete(Product product);

        void TransactionalOperation(Product product1, Product product2);
    }
}
