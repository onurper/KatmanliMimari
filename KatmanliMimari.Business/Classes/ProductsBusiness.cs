using KatmanliMimari.Business.Interfaces;
using KatmanliMimari.Dto;
using KatmanliMimari.Repository.Classes;
using KatmanliMimari.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using KatmanliMimari.Entity;

namespace KatmanliMimari.Business.Classes
{
    public class ProductsBusiness : IProductsBusiness
    {
        readonly IRepositoryProducts _repProducts;
        public ProductsBusiness(IRepositoryProducts repProduct)
        {
            _repProducts = repProduct;
        }
        public ICollection<ProductsDto> GetProducts()
        {
            return _repProducts.Set().Select(x => new ProductsDto
            {
                ProductId = x.ProductId,
                ProductName = x.ProductName,
                CategoryName = x.Categories.CategoryName
            }).ToList();
        }

        public void Comit()
        {
            _repProducts.Comit();
        }

        public bool Create(Products p)
        {
            return _repProducts.Create(p);
        }

        public bool Delete(Products p)
        {
            return _repProducts.Delete(p);
        }

        public Products Find(int id)
        {
           return _repProducts.Find(id);
        }
        public ICollection<Products> List()
        {
            return _repProducts.List();
        }

        public bool Update(Products p)
        {
            return _repProducts.Update(p);
        }
    }
}
