using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product {ProductId = 1, CategoryId = 1 , ProductName = "PS5" , UnitPrice = 22000 , UnitsInStock = 10},
                new Product {ProductId = 2, CategoryId = 1 , ProductName = "Xbox" , UnitPrice = 20000 , UnitsInStock = 15},
                new Product {ProductId = 3, CategoryId = 2 , ProductName = "Mouse" , UnitPrice = 600 , UnitsInStock = 30},
                new Product {ProductId = 4, CategoryId = 2 , ProductName = "Keyboard" , UnitPrice = 1000 , UnitsInStock = 20},
                new Product {ProductId = 5, CategoryId = 2 , ProductName = "Microphone" , UnitPrice = 900 , UnitsInStock = 25}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p=>p.CategoryId == categoryId).ToList();
        }
    }
}