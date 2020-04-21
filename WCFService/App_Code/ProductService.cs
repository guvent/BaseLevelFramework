using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Business.Utilities.DependencyResolvers.Ninject;

/// <summary>
/// Summary description for ProductService
/// </summary>
public class ProductService : IProductService
{
    private IProductService _productService = InstanceFactory.GetInstance<IProductService>();
    public Product Add(Product product)
    {
        return _productService.Add(product);
    }

    public void Delete(Product product)
    {
        _productService.Delete(product);
    }

    public List<Product> GetAll()
    {
        return _productService.GetAll();
    }

    public Product GetByid(int id)
    {
        return _productService.GetByid(id);
    }

    public void TransactionalOperation(Product product1, Product product2)
    {
        _productService.TransactionalOperation(product1,product2);
    }

    public Product Update(Product product)
    {
        return _productService.Update(product);
    }
}