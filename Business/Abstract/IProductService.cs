using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    [ServiceContract]
    public interface IProductService
    {
        //List<Product> GetAll();
        //Product GetByid(int id);
        //Product Add(Product product);
        //Product Update(Product product);
        //void Delete(Product product);
        //void TransactionalOperation(Product product1, Product product2);

        [OperationContract]
        List<Product> GetAll();

        [OperationContract]
        Product GetByid(int id);

        [OperationContract]
        Product Add(Product product);

        [OperationContract]
        Product Update(Product product);

        [OperationContract]
        void Delete(Product product);

        [OperationContract]
        void TransactionalOperation(Product product1, Product product2);
    }
}
